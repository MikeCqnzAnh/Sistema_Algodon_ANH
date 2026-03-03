Imports System.Net
Imports System.Net.Sockets
Imports System.ServiceProcess
Imports System.Text
Imports System.Threading

Namespace ccotton_services

    Public Class CcottonService
        Inherits ServiceBase

        ' ─── Campos privados ────────────────────────────────────────────────
        Private _udpListener As UdpClient
        Private _listenerThread As Thread
        Private _running As Boolean = False
        Private ReadOnly _eventLog As System.Diagnostics.EventLog

        ' ─── Constructor ────────────────────────────────────────────────────
        Public Sub New()
            ServiceName = "ccotton_services"
            CanStop = True
            CanPauseAndContinue = False
            AutoLog = True

            ' Configurar EventLog propio
            _eventLog = New System.Diagnostics.EventLog()
            If Not System.Diagnostics.EventLog.SourceExists("CcottonServices") Then
                System.Diagnostics.EventLog.CreateEventSource("CcottonServices", "Application")
            End If
            _eventLog.Source = "CcottonServices"
            _eventLog.Log = "Application"
        End Sub

        ' ─── Inicio del servicio ────────────────────────────────────────────
        Protected Overrides Sub OnStart(args() As String)
            _running = True

            _listenerThread = New Thread(AddressOf EscucharDiscovery) With {
                .IsBackground = True,
                .Name = "CcottonDiscoveryListener"
            }
            _listenerThread.Start()

            LogInfo($"{NOMBRE_SISTEMA} - Servicio iniciado. Escuchando en puerto UDP {PUERTO_DISCOVERY}.")
        End Sub

        ' ─── Detención del servicio ─────────────────────────────────────────
        Protected Overrides Sub OnStop()
            _running = False

            Try
                _udpListener?.Close()
            Catch ex As Exception
                ' Ignorar errores al cerrar el socket
            End Try

            If _listenerThread IsNot Nothing AndAlso _listenerThread.IsAlive Then
                _listenerThread.Join(2000)
            End If

            LogInfo($"{NOMBRE_SISTEMA} - Servicio detenido.")
        End Sub

        ' ─── Loop principal: escucha mensajes UDP de discovery ───────────────
        Private Sub EscucharDiscovery()
            Try
                _udpListener = New UdpClient(PUERTO_DISCOVERY)
                _udpListener.EnableBroadcast = True

                LogInfo($"Listener UDP activo en puerto {PUERTO_DISCOVERY}.")

                Dim remoteEP As New IPEndPoint(IPAddress.Any, 0)

                Do While _running
                    Try
                        ' Bloquea hasta recibir un datagrama
                        Dim datos() As Byte = _udpListener.Receive(remoteEP)
                        Dim mensaje As String = Encoding.UTF8.GetString(datos).Trim()

                        LogInfo($"Mensaje recibido desde {remoteEP.Address}: '{mensaje}'")

                        If mensaje = MSG_BUSQUEDA Then
                            ResponderDiscovery(remoteEP)
                        End If

                    Catch ex As SocketException When Not _running
                        ' Socket cerrado intencionalmente al detener el servicio
                        Exit Do
                    Catch ex As Exception
                        If _running Then
                            LogError($"Error al recibir datagrama: {ex.Message}")
                            Thread.Sleep(500) ' Pequeña pausa antes de reintentar
                        End If
                    End Try
                Loop

            Catch ex As Exception
                LogError($"Error fatal en listener UDP: {ex.Message}")
            End Try
        End Sub

        ' ─── Responde con la IP del servidor al cliente que preguntó ─────────
        Private Sub ResponderDiscovery(clienteEP As IPEndPoint)
            Try
                Dim ipServidor As String = ObtenerIPLocal()
                Dim respuesta As String = PREFIJO_RESPUESTA & ipServidor
                Dim bytes() As Byte = Encoding.UTF8.GetBytes(respuesta)

                ' Responder directamente al cliente (unicast de regreso)
                Using udpReply As New UdpClient()
                    udpReply.Send(bytes, bytes.Length, clienteEP)
                End Using

                LogInfo($"Discovery respondido a {clienteEP.Address}:{clienteEP.Port} → '{respuesta}'")

            Catch ex As Exception
                LogError($"Error al responder discovery: {ex.Message}")
            End Try
        End Sub

        ' ─── Obtiene la primera IP local válida del servidor ─────────────────
        Private Function ObtenerIPLocal() As String
            Try
                Dim hostName As String = Dns.GetHostName()
                Dim addresses() As IPAddress = Dns.GetHostAddresses(hostName)

                For Each addr As IPAddress In addresses
                    ' Preferir IPv4, descartar loopback
                    If addr.AddressFamily = Sockets.AddressFamily.InterNetwork AndAlso
                       Not IPAddress.IsLoopback(addr) Then
                        Return addr.ToString()
                    End If
                Next

                Return "127.0.0.1"
            Catch
                Return "127.0.0.1"
            End Try
        End Function

        ' ─── Helpers de log ──────────────────────────────────────────────────
        Private Sub LogInfo(mensaje As String)
            Try
                _eventLog.WriteEntry(mensaje, System.Diagnostics.EventLogEntryType.Information)
            Catch
                ' Ignorar si no hay permisos de log
            End Try
        End Sub

        Private Sub LogError(mensaje As String)
            Try
                _eventLog.WriteEntry(mensaje, System.Diagnostics.EventLogEntryType.Error)
            Catch
            End Try
        End Sub

    End Class

End Namespace