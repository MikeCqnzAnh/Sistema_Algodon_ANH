' Capa_Datos/Repositorios/UsuarioRepositorio.vb
Imports System
Imports System.Threading.Tasks
Imports Capa_Entidad
Imports Dapper

Public Class UsuarioRepositorio
    Implements IUsuarioRepositorio

    '' ─── Obtener usuario por email ────────────────────────────────────────────
    'Public Async Function ObtenerPorEmailAsync(
    '    email As String) As Task(Of Usuario) _
    '    Implements IUsuarioRepositorio.ObtenerPorEmailAsync

    '    Const sql As String =
    '        "SELECT Id, Nombre, Email, PasswordHash, Salt, Activo, " &
    '        "       TokenRecuperacion, TokenExpiracion " &
    '        "FROM Usuarios " &
    '        "WHERE Email = @Email AND Activo = 1"

    '    Using conn = DatabaseConfig.CrearConexion()
    '        Return Await conn.QueryFirstOrDefaultAsync(Of Usuario)(
    '            sql, New With {.Email = email})
    '    End Using
    'End Function
    Public Async Function ObtenerPorUsuarioAsync(
    usuario As String) As Task(Of Usuario) _
    Implements IUsuarioRepositorio.ObtenerPorUsuarioAsync

        Const sql As String =
        "SELECT Id, Nombre, Usuario, Email, PasswordHash, Salt, Activo, " &
        "       TokenRecuperacion, TokenExpiracion " &
        "FROM Usuarios " &
        "WHERE Usuario = @Usuario AND Activo = 1"

        Using conn = DatabaseConfig.CrearConexion()
            Return Await conn.QueryFirstOrDefaultAsync(Of Usuario)(
            sql, New With {.Usuario = usuario})
        End Using
    End Function
    ' ─── Guardar token de recuperación ───────────────────────────────────────
    Public Async Function GuardarTokenRecuperacionAsync(
        id As Integer,
        token As String,
        expiracion As DateTime) As Task(Of Boolean) _
        Implements IUsuarioRepositorio.GuardarTokenRecuperacionAsync

        Const sql As String =
            "UPDATE Usuarios " &
            "SET TokenRecuperacion = @Token, TokenExpiracion = @Expiracion " &
            "WHERE Id = @Id AND Activo = 1"

        Using conn = DatabaseConfig.CrearConexion()
            Dim filas As Integer = Await conn.ExecuteAsync(
                sql, New With {
                    .Token = token,
                    .Expiracion = expiracion,
                    .Id = id
                })
            Return filas > 0
        End Using
    End Function

    ' ─── Actualizar contraseña ────────────────────────────────────────────────
    Public Async Function ActualizarPasswordAsync(
        id As Integer,
        hash As String,
        salt As String) As Task(Of Boolean) _
        Implements IUsuarioRepositorio.ActualizarPasswordAsync

        Const sql As String =
            "UPDATE Usuarios " &
            "SET PasswordHash = @Hash, Salt = @Salt, " &
            "    TokenRecuperacion = NULL, TokenExpiracion = NULL " &
            "WHERE Id = @Id"

        Using conn = DatabaseConfig.CrearConexion()
            Dim filas As Integer = Await conn.ExecuteAsync(
                sql, New With {
                    .Hash = hash,
                    .Salt = salt,
                    .Id = id
                })
            Return filas > 0
        End Using
    End Function

    ' ─── Obtener usuario por token ────────────────────────────────────────────
    Public Async Function ObtenerPorTokenAsync(
        token As String) As Task(Of Usuario) _
        Implements IUsuarioRepositorio.ObtenerPorTokenAsync

        Const sql As String =
            "SELECT Id, Email, TokenExpiracion " &
            "FROM Usuarios " &
            "WHERE TokenRecuperacion = @Token " &
            "  AND TokenExpiracion > GETUTCDATE() " &
            "  AND Activo = 1"

        Using conn = DatabaseConfig.CrearConexion()
            Return Await conn.QueryFirstOrDefaultAsync(Of Usuario)(
                sql, New With {.Token = token})
        End Using
    End Function

End Class