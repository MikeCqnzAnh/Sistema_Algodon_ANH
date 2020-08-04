Imports System.Net
Imports System.Net.Mail
Module EnviarEmail
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Sub enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String, ByVal puertosmtp As Integer, ByVal hostsmpt As String, ByVal activassl As Boolean, Optional archivoadjunto As String = "")
        Try
            If archivoadjunto <> "" Then
                correos.To.Clear()
                correos.Attachments.Clear()
                correos.Body = ""
                correos.Subject = ""
                correos.From = New MailAddress(emisor)
                correos.Body = mensaje
                correos.Subject = asunto
                correos.IsBodyHtml = True
                correos.To.Add(Trim(destinatario))

                Dim adjuntar As New Net.Mail.Attachment(archivoadjunto)
                correos.Attachments.Add(adjuntar)

                correos.Priority = MailPriority.Normal
                envios.EnableSsl = activassl
                envios.Port = puertosmtp
                envios.Host = hostsmpt
                envios.Credentials = New Net.NetworkCredential(emisor, password)
                envios.Send(correos)
                MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Aviso")
            Else
                correos.To.Clear()
                correos.Attachments.Clear()

                correos.Body = ""
                correos.Subject = ""
                correos.From = New MailAddress(emisor)
                correos.Body = mensaje
                correos.Subject = asunto
                correos.IsBodyHtml = True
                correos.To.Add(Trim(destinatario))

                correos.Priority = MailPriority.Normal
                envios.EnableSsl = activassl
                envios.Port = puertosmtp
                envios.Host = hostsmpt
                envios.Credentials = New Net.NetworkCredential(emisor, password)
                envios.Send(correos)
                MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
