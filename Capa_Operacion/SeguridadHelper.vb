Imports System.Security.Cryptography
Imports System.Text
Public Module SeguridadHelper

        ' ─── Hash de contraseña PBKDF2-SHA512 ─────────────────────────────────
        Public Function GenerarHashPassword(password As String) _
            As Tuple(Of String, String)

            Dim saltBytes(31) As Byte
            Using rng = New RNGCryptoServiceProvider()
                rng.GetBytes(saltBytes)
            End Using

            Dim salt As String = Convert.ToBase64String(saltBytes)
            Dim hash As String = HashPassword(password, salt)
            Return Tuple.Create(hash, salt)
        End Function

        Public Function HashPassword(password As String,
                                     salt As String) As String
            Dim saltBytes As Byte() = Convert.FromBase64String(salt)
            Using pbkdf2 = New Rfc2898DeriveBytes(
                password, saltBytes, 100000, HashAlgorithmName.SHA512)
                Return Convert.ToBase64String(pbkdf2.GetBytes(64))
            End Using
        End Function

    ' ─── AES-256 ──────────────────────────────────────────────────────────
    Public Function EncryptString(texto As String, clave As String) As String
        Dim claveBytes As Byte() = ObtenerClave256(clave)

        ' ✅ Renombrar variable a "cifrador" para evitar conflicto con Aes
        Using cifrador As Aes = Aes.Create()
            cifrador.Key = claveBytes
            cifrador.Mode = CipherMode.CBC
            cifrador.Padding = PaddingMode.PKCS7
            cifrador.GenerateIV()

            Using enc = cifrador.CreateEncryptor()
                Dim textoBytes As Byte() = Encoding.UTF8.GetBytes(texto)
                Dim cifrado As Byte() = enc.TransformFinalBlock(
                textoBytes, 0, textoBytes.Length)

                Dim resultado(cifrador.IV.Length + cifrado.Length - 1) As Byte
                Buffer.BlockCopy(cifrador.IV, 0, resultado, 0, cifrador.IV.Length)
                Buffer.BlockCopy(cifrado, 0, resultado,
                cifrador.IV.Length, cifrado.Length)

                Return Convert.ToBase64String(resultado)
            End Using
        End Using
    End Function

    Public Function DecryptString(textoCifrado As String, clave As String) As String
        Dim claveBytes As Byte() = ObtenerClave256(clave)
        Dim datos As Byte() = Convert.FromBase64String(textoCifrado)

        ' ✅ Renombrar variable a "descifrador"
        Using descifrador As Aes = Aes.Create()
            descifrador.Key = claveBytes
            descifrador.Mode = CipherMode.CBC
            descifrador.Padding = PaddingMode.PKCS7

            Dim iv(15) As Byte
            Dim cifrado(datos.Length - 17) As Byte
            Buffer.BlockCopy(datos, 0, iv, 0, 16)
            Buffer.BlockCopy(datos, 16, cifrado, 0, cifrado.Length)
            descifrador.IV = iv

            Using dec = descifrador.CreateDecryptor()
                Dim descifrado As Byte() = dec.TransformFinalBlock(cifrado, 0, cifrado.Length)
                Return Encoding.UTF8.GetString(descifrado)
            End Using
        End Using
    End Function

    ' ─── SHA-256 ──────────────────────────────────────────────────────────
    Public Function ComputeSHA256(datos As String) As String
            Using sha = SHA256.Create()
                Dim hash As Byte() = sha.ComputeHash(
                    Encoding.UTF8.GetBytes(datos))
                Return BitConverter.ToString(hash).Replace("-", "").ToLower()
            End Using
        End Function

        ' ─── HMAC-SHA256 ──────────────────────────────────────────────────────
        Public Function ComputeHMAC(datos As String,
                                    secret As String) As String
            Dim secretBytes As Byte() = Encoding.UTF8.GetBytes(secret)
            Dim datosBytes As Byte() = Encoding.UTF8.GetBytes(datos)
            Using hmac = New HMACSHA256(secretBytes)
                Return BitConverter.ToString(
                    hmac.ComputeHash(datosBytes)).Replace("-", "").ToLower()
            End Using
        End Function

        ' ─── Comparación en tiempo constante ──────────────────────────────────
        Public Function FixedTimeEquals(a As String, b As String) As Boolean
            If a Is Nothing OrElse b Is Nothing Then Return False
            If a.Length <> b.Length Then Return False
            Dim diff As Integer = 0
            For i As Integer = 0 To a.Length - 1
                diff = diff Or (AscW(a(i)) Xor AscW(b(i)))
            Next
            Return diff = 0
        End Function

        ' ─── Token seguro ─────────────────────────────────────────────────────
        Public Function GenerarTokenSeguro() As String
            Dim bytes(31) As Byte
            Using rng = New RNGCryptoServiceProvider()
                rng.GetBytes(bytes)
            End Using
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Function

        Private Function ObtenerClave256(clave As String) As Byte()
            Using sha = SHA256.Create()
                Return sha.ComputeHash(Encoding.UTF8.GetBytes(clave))
            End Using
        End Function

End Module