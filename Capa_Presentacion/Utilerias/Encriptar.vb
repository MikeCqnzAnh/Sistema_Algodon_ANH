Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class Encriptar
    Private des As New TripleDESCryptoServiceProvider 'Algorithmo TripleDES
    Private hashmd5 As New MD5CryptoServiceProvider 'objeto md5

    'Funcion para el Encriptado de Cadenas de Texto
    'Public Function Encriptar(ByVal texto As String) As String

    '    If Trim(texto) = "" Then
    '        Encriptar = ""
    '    Else
    '        des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(texto))
    '        des.Mode = CipherMode.ECB
    '        Dim encrypt As ICryptoTransform = des.CreateEncryptor()
    '        Dim buff() As Byte = UnicodeEncoding.ASCII.GetBytes(texto)
    '        Encriptar = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length))
    '    End If
    '    Return Encriptar
    'End Function
    Public Function Encriptar(ByVal texto As String) As String
        Dim cifrador As New SHA512Managed
        Dim contraseñaOriginal As Byte() = Encoding.ASCII.GetBytes(texto)
        Dim contraseñaCifrada As Byte() = cifrador.ComputeHash(contraseñaOriginal)
        Dim textoContraseñaCifrada As String = Convert.ToBase64String(contraseñaCifrada)
        Return textoContraseñaCifrada
    End Function
    'Funcion para el Desencriptado de Cadenas de Texto
    Public Function Desencriptar(ByVal texto As String) As String
        If Trim(texto) = "" Then
            Desencriptar = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(texto))
            des.Mode = CipherMode.ECB
            Dim desencrypta As ICryptoTransform = des.CreateDecryptor()
            Dim buff() As Byte = Convert.FromBase64String(texto)
            Desencriptar = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Desencriptar
    End Function
End Class
