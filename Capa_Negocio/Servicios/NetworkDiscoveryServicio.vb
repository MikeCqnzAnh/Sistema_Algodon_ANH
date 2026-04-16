' Capa_Negocio/Servicios/NetworkDiscoveryServicio.vb
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports Capa_Operacion
Imports Capa_Entidad
Imports Capa_Operacion.Configuracion
Imports NLog

Public Class NetworkDiscoveryServicio
    Implements IDisposable

    Private ReadOnly _logger As Logger = LogManager.GetCurrentClassLogger()

    Private _servidorUdp As UdpClient
    Private _hiloEscucha As Thread
    Private _escuchando As Boolean
    Private _disposed As Boolean

    ' ─── SERVIDOR: iniciar escucha de discovery ───────────────────────────────
    Public Sub IniciarServidor()
        Try
            _servidorUdp = New UdpClient(Constantes.PUERTO_DISCOVERY)
            _escuchando = True

            _hiloEscucha = New Thread(AddressOf EscucharSolicitudes) With {
                .IsBackground = True,
                .Name = "NetworkDiscovery"
            }
            _hiloEscucha.Start()

            _logger.Info("Servidor de discovery iniciado en puerto {0}.",
                Constantes.PUERTO_DISCOVERY)

        Catch ex As Exception
            _logger.Warn(ex, "No se pudo iniciar servidor de discovery.")
        End Try
    End Sub

    ' ─── SERVIDOR: escuchar y responder solicitudes ───────────────────────────
    Private Sub EscucharSolicitudes()
        While _escuchando
            Try
                Dim remoto As New IPEndPoint(IPAddress.Any, 0)
                Dim datos As Byte() = _servidorUdp.Receive(remoto)
                Dim mensaje As String = Encoding.UTF8.GetString(datos)

                _logger.Info("Discovery recibido desde {0}: {1}",
                    remoto.Address, mensaje)

                If mensaje = Constantes.MSG_BUSQUEDA Then
                    Dim ipLocal As String = ObtenerIpLocal()
                    Dim respuesta As String =
                        Constantes.PREFIJO_RESPUESTA & ipLocal
                    Dim bytesResp As Byte() =
                        Encoding.UTF8.GetBytes(respuesta)

                    _servidorUdp.Send(bytesResp, bytesResp.Length,
                        remoto.Address.ToString(), remoto.Port)

                    _logger.Info("Discovery respondido a {0} con IP {1}",
                        remoto.Address, ipLocal)
                End If

            Catch ex As SocketException
                ' Socket cerrado — salir del loop
                Exit While

            Catch ex As Exception
                If _escuchando Then
                    _logger.Warn(ex, "Error en escucha de discovery.")
                End If
            End Try
        End While
    End Sub

    ' ─── ESTACIÓN: buscar servidor en la red ──────────────────────────────────
    Public Async Function BuscarServidorAsync() As Task(Of ResultadoDiscovery)
        Return Await Task.Run(Function() BuscarServidor()).ConfigureAwait(False)
    End Function

    Private Function BuscarServidor() As ResultadoDiscovery
        Dim cliente As UdpClient = Nothing

        Try
            cliente = New UdpClient()
            cliente.Client.ReceiveTimeout = Constantes.TIMEOUT_DISCOVERY_MS
            cliente.EnableBroadcast = True

            ' Enviar broadcast a toda la red local
            Dim datos As Byte() = Encoding.UTF8.GetBytes(Constantes.MSG_BUSQUEDA)
            Dim broadcast As IPEndPoint = New IPEndPoint(IPAddress.Broadcast, Constantes.PUERTO_DISCOVERY)

            cliente.Send(datos, datos.Length, broadcast)
            _logger.Info("Broadcast de discovery enviado.")

            ' Esperar respuesta del servidor
            Dim remoto As New IPEndPoint(IPAddress.Any, 0)
            Dim respuesta As Byte() = cliente.Receive(remoto)
            Dim mensaje As String = Encoding.UTF8.GetString(respuesta)

            _logger.Info("Respuesta de discovery recibida: {0}", mensaje)

            If mensaje.StartsWith(Constantes.PREFIJO_RESPUESTA) Then
                Dim ipServidor As String = mensaje _
                    .Substring(Constantes.PREFIJO_RESPUESTA.Length) _
                    .Trim()

                Return New ResultadoDiscovery With {
                    .Encontrado = True,
                    .ipServidor = ipServidor,
                    .mensaje = String.Format(
                        "Servidor encontrado en {0}", ipServidor)
                }
            End If

            Return New ResultadoDiscovery With {
                .Encontrado = False,
                .mensaje = "Respuesta de servidor no reconocida."
            }

        Catch ex As SocketException
            ' Timeout — no hay servidor en la red
            _logger.Info("No se encontró servidor en la red (timeout).")
            Return New ResultadoDiscovery With {
                .Encontrado = False,
                .Mensaje = "No se encontró ningún servidor en la red."
            }

        Catch ex As Exception
            _logger.Warn(ex, "Error durante discovery de red.")
            Return New ResultadoDiscovery With {
                .Encontrado = False,
                .Mensaje = "Error al buscar servidor en la red."
            }

        Finally
            If cliente IsNot Nothing Then
                Try
                    cliente.Close()
                Catch
                End Try
            End If
        End Try
    End Function

    ' ─── Obtener IP local del equipo ──────────────────────────────────────────
    Public Shared Function ObtenerIpLocal() As String
        Try
            For Each ip In Dns.GetHostAddresses(Dns.GetHostName())
                If ip.AddressFamily = Sockets.AddressFamily.InterNetwork AndAlso
               Not IPAddress.IsLoopback(ip) Then
                    Return ip.ToString()
                End If
            Next
        Catch
            Return "127.0.0.1"
        End Try
    End Function

    ' ─── Detener servidor de discovery ────────────────────────────────────────
    Public Sub Detener()
        _escuchando = False
        Try
            If _servidorUdp IsNot Nothing Then
                _servidorUdp.Close()
            End If
        Catch
        End Try
    End Sub

    ' ─── IDisposable ─────────────────────────────────────────────────────────
    Public Sub Dispose() Implements IDisposable.Dispose
        If Not _disposed Then
            Detener()
            _disposed = True
        End If
    End Sub

End Class