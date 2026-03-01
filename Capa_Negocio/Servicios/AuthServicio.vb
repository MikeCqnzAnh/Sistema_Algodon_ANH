' Capa_Negocio/Servicios/AuthServicio.vb
Imports System.Threading.Tasks
Imports System.Web.SessionState
Imports Capa_Datos
Imports Capa_Entidad
Imports Capa_Operacion
Imports NLog

Public Class AuthServicio

    Private ReadOnly _logger As Logger = LogManager.GetCurrentClassLogger()
    Private ReadOnly _usuarioRepo As IUsuarioRepositorio
    Private ReadOnly _emailServicio As IEmailServicio

    Public Sub New()
        _usuarioRepo = New UsuarioRepositorio()
        _emailServicio = New EmailServicio()
    End Sub

    ' ─── Login ───────────────────────────────────────────────────────────────
    Public Async Function LoginAsync(dto As LoginDTO) As Task(Of ResultadoLogin)

        Await Task.Delay(300).ConfigureAwait(False)

        ' ✅ Validar usuario en lugar de email
        If String.IsNullOrWhiteSpace(dto.Usuario) OrElse
       String.IsNullOrWhiteSpace(dto.Password) Then
            Return ResultadoLogin.CrearFallido("Credenciales inválidas.")
        End If

        Dim usuario As Usuario = Nothing

        Try
            ' ✅ Buscar por usuario en lugar de email
            usuario = Await _usuarioRepo _
            .ObtenerPorUsuarioAsync(dto.Usuario.Trim().ToLower()) _
            .ConfigureAwait(False)
        Catch ex As Exception
            _logger.Error(ex, "Error al consultar usuario en BD.")
            Return ResultadoLogin.CrearFallido(
            "Error al conectar. Intente más tarde.")
        End Try

        If usuario Is Nothing Then
            Return ResultadoLogin.CrearFallido("Credenciales inválidas.")
        End If

        Dim hashIngresado As String = SeguridadHelper.HashPassword(
        dto.Password, usuario.Salt)

        Dim passwordValido As Boolean = SeguridadHelper.FixedTimeEquals(
        hashIngresado, usuario.PasswordHash)

        If Not passwordValido Then
            Return ResultadoLogin.CrearFallido("Credenciales inválidas.")
        End If

        ' ✅ Guardar por usuario en lugar de email
        If dto.Recordar Then
            SessionManager.GuardarCredenciales(dto.Usuario.Trim(), dto.Password)
        Else
            SessionManager.LimpiarCredenciales()
        End If

        SessionManager.UsuarioActual = usuario

        Return ResultadoLogin.CrearExitoso(usuario)
    End Function

    ' ─── Solicitar recuperación de contraseña ────────────────────────────────
    Public Async Function SolicitarRecuperacionAsync(email As String) As Task(Of Boolean)

        'If String.IsNullOrWhiteSpace(email) Then Return True

        'Try
        '    Dim usuario As Usuario = Await _usuarioRepo _
        '        .ObtenerPorEmailAsync(email.Trim().ToLower()) _
        '        .ConfigureAwait(False)

        '    ' No revelar si el email existe o no
        '    If usuario Is Nothing Then Return True

        '    Dim token As String = SeguridadHelper.GenerarTokenSeguro()
        '    Dim expiracion As DateTime = DateTime.UtcNow.AddHours(2)

        '    Await _usuarioRepo _
        '        .GuardarTokenRecuperacionAsync(
        '            usuario.Id, token, expiracion) _
        '        .ConfigureAwait(False)

        '    Await _emailServicio _
        '        .EnviarRecuperacionAsync(email, token) _
        '        .ConfigureAwait(False)

        'Catch ex As Exception
        '    _logger.Error(ex, "Error en SolicitarRecuperacionAsync.")
        'End Try

        Return True
    End Function

    ' ─── Restablecer contraseña ───────────────────────────────────────────────
    Public Async Function RestablecerPasswordAsync(
        token As String,
        nuevoPassword As String) As Task(Of Boolean)

        If String.IsNullOrWhiteSpace(token) OrElse
           String.IsNullOrWhiteSpace(nuevoPassword) Then
            Return False
        End If

        Try
            Dim usuario As Usuario = Await _usuarioRepo _
                .ObtenerPorTokenAsync(token) _
                .ConfigureAwait(False)

            If usuario Is Nothing Then Return False

            ' Generar nuevo hash — Tuple en lugar de deconstruction
            Dim resultado As Tuple(Of String, String) =
                SeguridadHelper.GenerarHashPassword(nuevoPassword)

            Dim hash As String = resultado.Item1
            Dim salt As String = resultado.Item2

            Return Await _usuarioRepo _
                .ActualizarPasswordAsync(usuario.Id, hash, salt) _
                .ConfigureAwait(False)

        Catch ex As Exception
            _logger.Error(ex, "Error en RestablecerPasswordAsync.")
            Return False
        End Try
    End Function

End Class