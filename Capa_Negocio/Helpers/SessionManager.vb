' Capa_Negocio/Helpers/SessionManager.vb
Imports System.Security.Cryptography
Imports System.Text
Imports Capa_Entidad
Imports Microsoft.Win32

Public Module SessionManager

    Public Property UsuarioActual As Usuario

    Private Const REG_KEY As String = "SOFTWARE\Algodon ANH\Session"

    ' ─── Guardar credenciales cifradas con DPAPI ──────────────────────────────
    Public Sub GuardarCredenciales(email As String, password As String)
        Try
            Dim datos As String = String.Format("{0}|{1}", email, password)

            Dim encrypted As Byte() = ProtectedData.Protect(Encoding.UTF8.GetBytes(datos), Nothing, DataProtectionScope.CurrentUser)

            Using clave = Registry.CurrentUser.CreateSubKey(REG_KEY)
                If clave IsNot Nothing Then
                    clave.SetValue("cred", Convert.ToBase64String(encrypted))
                End If
            End Using
        Catch
            ' Silencioso — no crítico
        End Try
    End Sub

    ' ─── Cargar credenciales guardadas ────────────────────────────────────────
    Public Function CargarCredenciales() As Tuple(Of String, String)
        Try
            Using clave = Registry.CurrentUser.OpenSubKey(REG_KEY)
                If clave Is Nothing Then
                    Return New Tuple(Of String, String)(Nothing, Nothing)
                End If

                Dim valorReg As Object = clave.GetValue("cred")
                Dim base64 As String = If(
                    valorReg IsNot Nothing,
                    valorReg.ToString(),
                    String.Empty)

                If String.IsNullOrEmpty(base64) Then
                    Return New Tuple(Of String, String)(Nothing, Nothing)
                End If

                Dim decrypted As Byte() = ProtectedData.Unprotect(Convert.FromBase64String(base64), Nothing, DataProtectionScope.CurrentUser)

                Dim partes As String() =
                    Encoding.UTF8.GetString(decrypted).Split("|"c)

                If partes.Length = 2 Then
                    Return New Tuple(Of String, String)(partes(0), partes(1))
                End If

                Return New Tuple(Of String, String)(Nothing, Nothing)
            End Using
        Catch
            Return New Tuple(Of String, String)(Nothing, Nothing)
        End Try
    End Function

    ' ─── Limpiar credenciales guardadas ──────────────────────────────────────
    Public Sub LimpiarCredenciales()
        Try
            Using clave = Registry.CurrentUser.OpenSubKey(REG_KEY, True)
                If clave IsNot Nothing Then
                    clave.DeleteValue("cred", False)
                End If
            End Using
        Catch
        End Try
    End Sub

    ' ─── Cerrar sesión ────────────────────────────────────────────────────────
    Public Sub CerrarSesion()
        UsuarioActual = Nothing
    End Sub

End Module