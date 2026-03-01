' Capa_Negocio/Servicios/EmailServicio.vb
Imports System.Net
Imports System.Net.Mail
Imports System.Threading.Tasks
Imports Capa_Operacion
Imports Capa_Operacion.Configuracion
Imports NLog

Public Class EmailServicio
    'Implements IEmailServicio

    Private ReadOnly _logger As Logger =
        LogManager.GetCurrentClassLogger()

    ' ─── Enviar recuperación de contraseña ───────────────────────────────────
    Public Async Function EnviarRecuperacionAsync(emailDestino As String, token As String) As Task(Of Boolean)
        'Implements IEmailServicio.EnviarRecuperacionAsync

        'Dim asunto As String = "Recuperación de contraseña — Algodon ANH"
        'Dim cuerpo As String = String.Format(
        '    "Hola,{0}{0}" &
        '    "Recibimos una solicitud para restablecer tu contraseña.{0}{0}" &
        '    "Tu token de recuperación es:{0}{1}{0}{0}" &
        '    "Este token expira en 2 horas.{0}{0}" &
        '    "Si no solicitaste esto, ignora este mensaje.",
        '    Environment.NewLine, token)

        'Return Await EnviarAsync(emailDestino, asunto, cuerpo)
    End Function

    ' ─── Enviar bienvenida ────────────────────────────────────────────────────
    Public Async Function EnviarBienvenidaAsync(emailDestino As String, nombre As String) As Task(Of Boolean)
        'Implements IEmailServicio.EnviarBienvenidaAsync

        'Dim asunto As String = "Bienvenido a Algodon ANH"
        'Dim cuerpo As String = String.Format(
        '    "Hola {0},{1}{1}" &
        '    "Tu cuenta ha sido creada exitosamente.{1}{1}" &
        '    "Bienvenido al sistema Algodon ANH.",
        '    nombre, Environment.NewLine)

        'Return Await EnviarAsync(emailDestino, asunto, cuerpo)
    End Function

    ' ─── Enviar aviso de licencia ─────────────────────────────────────────────
    Public Async Function EnviarAvisoLicenciaAsync(emailDestino As String, diasRestantes As Integer) As Task(Of Boolean)
        'Implements IEmailServicio.EnviarAvisoLicenciaAsync

        'Dim asunto As String = "Aviso de vencimiento de licencia — Algodon ANH"
        'Dim cuerpo As String = String.Format(
        '    "Estimado usuario,{0}{0}" &
        '    "Su licencia del sistema Algodon ANH vencerá en {1} día(s).{0}{0}" &
        '    "Por favor renueve su licencia para continuar usando el sistema.",
        '    Environment.NewLine, diasRestantes)

        'Return Await EnviarAsync(emailDestino, asunto, cuerpo)
    End Function

    ' ─── Método base de envío ─────────────────────────────────────────────────
    Private Async Function EnviarAsync(
        destino As String,
        asunto As String,
        cuerpo As String) As Task(Of Boolean)

        Try
            Using cliente As New SmtpClient(AppConfig.SmtpHost, AppConfig.SmtpPort)
                cliente.EnableSsl = AppConfig.SmtpUsarSsl
                cliente.UseDefaultCredentials = False
                cliente.Credentials = New NetworkCredential(
                    AppConfig.SmtpUser, AppConfig.SmtpPassword)

                Using mensaje As New MailMessage()
                    mensaje.From = New MailAddress(AppConfig.SmtpUser)
                    mensaje.Subject = asunto
                    mensaje.Body = cuerpo
                    mensaje.IsBodyHtml = False
                    mensaje.To.Add(destino)

                    Await cliente.SendMailAsync(mensaje)
                End Using
            End Using

            _logger.Info("Email enviado a {0}", destino)
            Return True

        Catch ex As Exception
            _logger.Error(ex, "Error al enviar email a {0}", destino)
            Return False
        End Try
    End Function

End Class