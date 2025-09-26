Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime

Module EnviarEmail
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Dim emisor As String
    Dim password As String
    Dim hostsmpt As String
    Dim puertosmtp As String
    Dim activassl As Boolean

    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\conf\"
    Dim archivo As String = "confemail.ini"
    Private Sub ObtenerArchivoConfiguracion()
        Dim leer As New StreamReader(Ruta & archivo)
        Try
            While leer.Peek <> -1
                Dim linea As String = leer.ReadToEnd()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                Dim arreglocadena() As String = Split(linea, vbCrLf)
                emisor = ObtenerValor(arreglocadena(0))
                password = ObtenerValor(arreglocadena(1))
                hostsmpt = ObtenerValor(arreglocadena(2))
                puertosmtp = ObtenerValor(arreglocadena(3))
                activassl = ObtenerValor(arreglocadena(4))
            End While
            leer.Close()
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function ObtenerValor(ByVal cadena As String)
        Dim Resultado As String
        Dim ArregloCadena() As String = Split(cadena, "=")
        Resultado = ArregloCadena(1)
        Return Resultado
    End Function
    Sub enviarCorreo(ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String, Optional archivoadjunto As String = "")
        Try
            ObtenerArchivoConfiguracion()
            correos.To.Clear()
            correos.Attachments.Clear()
            correos.AlternateViews.Clear()
            correos.Body = ""
            correos.Subject = ""

            correos.From = New MailAddress(emisor)
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))

            ' --- Crear cuerpo con firma e imagen ---
            Dim htmlbody As String = "
                <p>" & mensaje & "</p>
                <img src=""cid:MiFirma"" alt=""Firma"" style=""width:400px;""/>
            "

            Dim avHtml As AlternateView = AlternateView.CreateAlternateViewFromString(htmlbody, Nothing, MediaTypeNames.Text.Html)

            ' Ruta de la imagen (asegúrate que esté marcada como "Copy to Output Directory")
            Dim imgPath As String = IO.Path.Combine(Application.StartupPath, "firmaemail.jpg")
            Dim logo As New LinkedResource(imgPath, MediaTypeNames.Image.Jpeg)
            logo.ContentId = "MiFirma"
            avHtml.LinkedResources.Add(logo)

            ' Asignar vista HTML al correo
            correos.AlternateViews.Add(avHtml)

            ' --- Adjuntar archivo si existe ---
            If archivoadjunto <> "" Then
                Dim adjuntar As New Net.Mail.Attachment(archivoadjunto)
                correos.Attachments.Add(adjuntar)
            End If

            correos.Priority = MailPriority.Normal

            ' --- Configuración SMTP ---
            envios.EnableSsl = activassl
            envios.Port = puertosmtp
            envios.Host = hostsmpt
            envios.Credentials = New Net.NetworkCredential(emisor, password)

            ' --- Enviar ---
            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente.", MsgBoxStyle.Information, "Aviso")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
