Imports System.IO
Imports System.Net.Http
Imports System.Security.Cryptography
Imports System.Text
Imports Newtonsoft.Json

Public Class licenciahelper
    Public Class LicenciaResponse
        Public Property estado As String       ' Solo se usa en la respuesta de API
        Public Property licencia As Licencia   ' Solo se usa en la respuesta de API
        Public Property datos As String        ' Se usa al leer el archivo .dat local
        Public Property firma As String
        Public Property info As Info           ' Se usa al leer el archivo .dat local
    End Class

    Public Class Info
        Public Property cantidad As Integer
        Public Property fecha As DateTime?
        Public Property idestatuserial As Integer
        Public Property idperiodo As Integer
    End Class

    Public Class Licencia
        Public Property nombrerazonsocial As String
        Public Property email As String
        Public Property licencia As String
        Public Property cpuid As String
        Public Property serialencryp As String
        Public Property idperiodo As Integer
        Public Property periodo As String
        Public Property cantidad As Integer
        Public Property fechaactivacionserial As DateTime?
        Public Property fechavencimientoserial As DateTime?
        Public Property idestatusserial As Integer
        Public Property nombrecontacto As String
        Public Property telfonocontacto As String
    End Class

    Public Class LicenciaCifrada
        Public Property datos As String
        Public Property firma As String
    End Class

    Public Class LicenciaHelper
        Private Shared ReadOnly Clave As String = "qZFt9oKNb7kZzEG8hUWTAd8xL8ZvcOcf"
        Private Shared ReadOnly IV As String = "9sG7YxVpA4zLq2Xe"

        Public Shared Async Function VerificarLicenciaAsync(cpuid As String) As Task(Of LicenciaResponse)
            Dim url As String = $"http://localhost:5000/licencia/{cpuid}"
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12

            Using client As New HttpClient()
                Try
                    Dim response As HttpResponseMessage = Await client.GetAsync(url)
                    If response.IsSuccessStatusCode Then
                        Dim json As String = Await response.Content.ReadAsStringAsync()
                        Dim datos = JsonConvert.DeserializeObject(Of LicenciaResponse)(json)
                        Return datos
                    End If
                Catch
                End Try
                Return Nothing
            End Using
        End Function

        Public Shared Async Function datoslicencia(serialorig As String) As Task(Of LicenciaResponse)
            Dim url As String = $"http://localhost:5000/licencia_info/{serialorig}"
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12

            Using client As New HttpClient()
                Try
                    Dim response As HttpResponseMessage = Await client.GetAsync(url)
                    If response.IsSuccessStatusCode Then
                        Dim json As String = Await response.Content.ReadAsStringAsync()
                        Dim datos = JsonConvert.DeserializeObject(Of LicenciaResponse)(json)
                        Return datos
                    End If
                Catch
                End Try
                Return Nothing
            End Using
        End Function

        Public Shared Function Encriptar(textoPlano As String) As String
            Dim key As Byte() = Encoding.UTF8.GetBytes(Clave)
            Dim iv As Byte() = Encoding.UTF8.GetBytes(iv)

            Using aes As Aes = Aes.Create()
                aes.Key = key
                aes.IV = iv

                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write)
                        Using sw As New StreamWriter(cs)
                            sw.Write(textoPlano)
                        End Using
                    End Using
                    Return Convert.ToBase64String(ms.ToArray())
                End Using
            End Using
        End Function

        Public Shared Function Desencriptar(textoCifrado As String) As String
            Try
                If String.IsNullOrWhiteSpace(textoCifrado) Then
                    Throw New ArgumentException("Texto cifrado vacío.")
                End If

                Dim key As Byte() = Encoding.UTF8.GetBytes(Clave)
                Dim iv As Byte() = Encoding.UTF8.GetBytes(iv)
                Dim buffer As Byte() = Convert.FromBase64String(textoCifrado)

                Using aes As Aes = Aes.Create()
                    aes.Key = key
                    aes.IV = iv

                    Using ms As New MemoryStream(buffer)
                        Using cs As New CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read)
                            Using sr As New StreamReader(cs)
                                Return sr.ReadToEnd()
                            End Using
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error al desencriptar: " & ex.Message)
            End Try
        End Function

        Public Shared Function ObtenerHash(texto As String) As String
            Using sha As SHA256 = SHA256.Create()
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(texto)
                Dim hashBytes As Byte() = sha.ComputeHash(bytes)
                Return Convert.ToBase64String(hashBytes)
            End Using
        End Function

        Public Shared Sub GuardarLicenciaCifrada(licencia As Licencia)
            Dim jsonDatos As String = JsonConvert.SerializeObject(licencia)
            Dim hash As String = ObtenerHash(jsonDatos)

            Dim obj As New LicenciaCifrada With {
                .datos = Encriptar(jsonDatos),
                .firma = hash
            }

            Dim jsonFinal As String = JsonConvert.SerializeObject(obj, Formatting.Indented)
            File.WriteAllText("licencia_cifrada.dat", jsonFinal)
        End Sub

        Public Shared Function LeerLicenciaLocal() As Licencia
            Try
                Dim rutaArchivo As String = Path.Combine(Application.StartupPath, "licencia_cifrada.dat")
                If Not File.Exists(rutaArchivo) Then Return Nothing

                Dim jsonEnvoltura As String = File.ReadAllText(rutaArchivo)
                Dim objetoCifrado = JsonConvert.DeserializeObject(Of LicenciaCifrada)(jsonEnvoltura)

                If String.IsNullOrWhiteSpace(objetoCifrado?.datos) Then Return Nothing

                Dim jsonDesencriptado As String = Desencriptar(objetoCifrado.datos)
                Return JsonConvert.DeserializeObject(Of Licencia)(jsonDesencriptado)
            Catch ex As Exception
                MessageBox.Show("Error al leer o desencriptar licencia: " & ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Function LicenciaEsValida(licencia As Licencia) As Boolean
            If licencia Is Nothing Then Return False
            If licencia.idestatusserial <> 1 Then Return False
            If Not licencia.fechavencimientoserial.HasValue OrElse licencia.fechavencimientoserial.Value < DateTime.Now Then Return False
            Return True
        End Function
    End Class
End Class
