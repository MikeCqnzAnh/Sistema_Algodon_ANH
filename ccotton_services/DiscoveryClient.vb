Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Namespace ccotton_services

    ''' <summary>
    ''' Clase utilitaria para usar en la APLICACIÓN CLIENTE.
    ''' Envía un broadcast UDP y espera la respuesta del servidor.
    ''' </summary>
    Public Class DiscoveryClient

        ''' <summary>
        ''' Busca un servidor Calcula Cotton en la red local.
        ''' </summary>
        ''' <returns>
        ''' La IP del servidor si se encontró, Nothing en caso contrario.
        ''' </returns>
        Public Shared Function BuscarServidor() As String
            Try
                Using udp As New UdpClient()
                    udp.EnableBroadcast = True
                    udp.Client.ReceiveTimeout = TIMEOUT_DISCOVERY_MS

                    ' Enviar broadcast en la red local
                    Dim msg() As Byte = Encoding.UTF8.GetBytes(MSG_BUSQUEDA)
                    Dim broadcast As New IPEndPoint(IPAddress.Broadcast, PUERTO_DISCOVERY)
                    udp.Send(msg, msg.Length, broadcast)

                    ' Esperar respuesta
                    Dim remoteEP As New IPEndPoint(IPAddress.Any, 0)
                    Dim respuestaBytes() As Byte = udp.Receive(remoteEP)
                    Dim respuesta As String = Encoding.UTF8.GetString(respuestaBytes).Trim()

                    If respuesta.StartsWith(PREFIJO_RESPUESTA) Then
                        Dim ip As String = respuesta.Substring(PREFIJO_RESPUESTA.Length)
                        Return ip
                    End If
                End Using

            Catch ex As SocketException
                ' Timeout o sin respuesta → no hay servidor en la red
            Catch ex As Exception
                ' Otro error inesperado
            End Try

            Return Nothing
        End Function

        ''' <summary>
        ''' Versión asíncrona compatible con Await.
        ''' </summary>
        Public Shared Async Function BuscarServidorAsync() As Threading.Tasks.Task(Of String)
            Return Await Threading.Tasks.Task.Run(Function() BuscarServidor())
        End Function

    End Class

End Namespace