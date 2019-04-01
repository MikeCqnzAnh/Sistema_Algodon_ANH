Imports System.Security.Cryptography
Public Class Encriptar
    Dim ue As New System.Text.UTF8Encoding
    Dim sec As New RSACryptoServiceProvider
    Dim bytString(), bytCifrar(), bytDesCifrar() As Byte
    Public Function Cifrar(ByVal EncriptString As String) As String
        Dim strEncriptar As String = ""
        If EncriptString <> "" Then
            Try
                bytString = ue.GetBytes(EncriptString)
                bytCifrar = sec.Encrypt(bytString, False)
                strEncriptar = Convert.ToBase64String(bytCifrar)
            Catch ex As Exception
                MessageBox.Show("No se realizo el cifrado " & ex.Message)
            End Try
        End If
        Return strEncriptar
    End Function
    Public Function DesCifrar(ByVal TextEncripted As String) As String
        Dim strDesencriptar As String = ""
        If TextEncripted <> "" Then
            Try
                bytDesCifrar = sec.Decrypt(Convert.FromBase64String(TextEncripted), False)
                strDesencriptar = ue.GetString(bytDesCifrar)
            Catch ex As Exception
                MessageBox.Show("No se realizo el descifrado " & ex.Message)
            End Try
        End If
        Return strDesencriptar
    End Function
End Class
