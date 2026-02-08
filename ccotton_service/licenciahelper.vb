Imports System
Imports System.Configuration
Imports System.Management
Imports System.IO
Imports System.Net.Http
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Deployment

Public NotInheritable Class LicenciaHelper
    Shared parametros As Parametros
    Shared apikey As String = "zM4yl7mEVEaG3YXg9ad9kJt"
    Public Class LicenciaResponse
        Public Property estado As String                ' Solo se usa en la respuesta de API
        Public Property licencia As Licencia            ' Solo se usa en la respuesta de API
        Public Property datos As String                 ' Se usa al leer el archivo .dat local
        Public Property firma As String
        Public Property info As Info                    ' Se usa al leer el archivo .dat local
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
        Public Property fechaservidor As DateTime?
        Public Property idestatusserial As Integer
        Public Property nombrecontacto As String
        Public Property telfonocontacto As String
        Public Property estado As String
    End Class

    Public Class LicenciaCifrada
        Public Property datos As String
        Public Property firma As String
    End Class

    Private Shared ReadOnly Clave As String = "qZFt9oKNb7kZzEG8hUWTAd8xL8ZvcOcf" ' 32 chars ✔
    Private Shared ReadOnly IV As String = "9sG7YxVpA4zLq2Xe"                   ' 16 chars ✔

    Public Shared Async Function VerificarLicenciaAsync(cpuid As String) As Task(Of LicenciaResponse)
        Dim url As String = $"https://147.93.191.170/licencia/{cpuid}" ' Ideal HTTPS
        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12

        Using client As New HttpClient()
            ' Agregar header Authorization
            client.DefaultRequestHeaders.Clear()
            client.DefaultRequestHeaders.Add("Authorization", apikey)
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(url)
                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()
                    Dim datos = JsonConvert.DeserializeObject(Of LicenciaResponse)(json)
                    Return datos
                Else
                    ' Opcional: manejar 401 Unauthorized
                    Console.WriteLine($"Error: {response.StatusCode}")
                End If
            Catch ex As Exception
                Console.WriteLine($"Excepción: {ex.Message}")
            End Try

            Return Nothing
        End Using
    End Function
    Public Shared Async Function datoslicencia(serialorig As String) As Task(Of LicenciaResponse)
        'Dim url As String = $"http://localhost:5000/licencia_info/{serialorig}"
        Dim url As String = $"http://147.93.191.170/licencia_info/{serialorig}"
        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Clear()
            client.DefaultRequestHeaders.Add("Authorization", apikey)
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
    Public Shared Async Function consultalic(serialencypt As String) As Task(Of LicenciaResponse)
        'Dim url As String = $"http://localhost:5000/licencia/serial/{serialencypt}"
        Dim url As String = $"http://147.93.191.170/licencia/serial/{serialencypt}"
        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Clear()
            client.DefaultRequestHeaders.Add("Authorization", apikey)
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(url)
                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()
                    Dim wrapper = JsonConvert.DeserializeObject(Of LicenciaResponse)(json)
                    Return wrapper
                Else
                    ' Error HTTP → devuelvo LicenciaResponse con estado = error
                    Return New LicenciaResponse With {
                    .estado = "error_http_" & response.StatusCode.ToString(),
                    .licencia = Nothing
                }
                End If
            Catch ex As Exception
                EventLog.WriteEntry("ccotton_service", "Excepción: " & ex.Message, EventLogEntryType.Error)
                ' Error inesperado → devuelvo LicenciaResponse con estado = error
                Return New LicenciaResponse With {
                .estado = "error",
                .licencia = Nothing,
                .datos = Nothing,
                .firma = Nothing,
                .info = Nothing
            }
            End Try
        End Using
    End Function
    Public Shared Function Encriptar(textoPlano As String) As String
        Dim key As Byte() = Encoding.UTF8.GetBytes(Clave)
        Dim ivBytes As Byte() = Encoding.UTF8.GetBytes(IV)

        Using aes As Aes = Aes.Create()
            aes.Key = key
            aes.IV = ivBytes

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
            Dim ivBytes As Byte() = Encoding.UTF8.GetBytes(IV)
            Dim buffer As Byte() = Convert.FromBase64String(textoCifrado)

            Using aes As Aes = Aes.Create()
                aes.Key = key
                aes.IV = ivBytes

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
        parametros = Parametros.Cargar

        'Dim rutaArchivo As String = Path.Combine(Application.StartupPath, "licencia_cifrada.dat")
        Dim rutaArchivo As String = parametros.RutaLc.ToString()
        Dim directorio As String = Path.GetDirectoryName(rutaArchivo)
        If Not Directory.Exists(directorio) Then
            Directory.CreateDirectory(directorio)
        End If
        Dim jsonDatos As String = JsonConvert.SerializeObject(licencia)
        Dim hash As String = ObtenerHash(jsonDatos)

        Dim obj As New LicenciaCifrada With {
            .datos = Encriptar(jsonDatos),
            .firma = hash
        }

        Dim jsonFinal As String = JsonConvert.SerializeObject(obj, Formatting.Indented)
        File.WriteAllText(rutaArchivo, jsonFinal)
    End Sub

    Public Shared Function LeerLicenciaLocal() As Licencia
        Try
            parametros = Parametros.Cargar

            'Dim rutaArchivo As String = Path.Combine(Application.StartupPath, "licencia_cifrada.dat")
            Dim rutaArchivo As String = parametros.RutaLc.ToString()
            If Not File.Exists(rutaArchivo) Then Return Nothing

            Dim jsonEnvoltura As String = File.ReadAllText(rutaArchivo)
            Dim objetoCifrado = JsonConvert.DeserializeObject(Of LicenciaCifrada)(jsonEnvoltura)

            If String.IsNullOrWhiteSpace(objetoCifrado?.datos) Then Return Nothing

            Dim jsonDesencriptado As String = Desencriptar(objetoCifrado.datos)
            Return JsonConvert.DeserializeObject(Of Licencia)(jsonDesencriptado)
        Catch ex As Exception
            'MessageBox.Show("Error al leer o desencriptar licencia: " & ex.Message)
            Return Nothing
        End Try
    End Function
    Private Function validar(licencia As Licencia)
        ' Validar licencia local si no fue válida la online
        Dim resultado As String = ""
        If licencia Is Nothing Then
            licencia = LicenciaHelper.LeerLicenciaLocal()
        End If

        If Not LicenciaHelper.LicenciaEsValida(licencia) Then
            'MessageBox.Show("La licencia no es válida o ha expirado. Vencida desde la fecha " &
            '            licencia.fechavencimientoserial?.ToString("dd/MM/yyyy"),
            '            "Licencia inválida", MessageBoxButtons.OK, MessageBoxIcon.[Stop])
            'controleslicencia(False)
            resultado = licencia.serialencryp
        Else
            'MessageBox.Show("Licencia válida hasta: " &
            '            licencia.fechavencimientoserial?.ToString("dd/MM/yyyy"),
            '            "Licencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ''controleslicencia(True)
        End If
        Return resultado
    End Function
    Public Shared Function leerlicenciaestacion() As Licencia
        Try
            'Dim rutaArchivo As String = Path.Combine(Application.StartupPath, "licencia_cifrada.dat")
            'Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            'ConfigurationManager.RefreshSection("AppSettings")
            parametros = Parametros.Cargar
            Dim rutaArchivo As String = Path.Combine($"\\{parametros.IpServidor}", "Calcula Cotton\licencia_cifrada.dat")
            'Dim rutaArchivo As String = parametros.RutaLc.ToString()
            If Not File.Exists(rutaArchivo) Then Return Nothing

            Dim jsonEnvoltura As String = File.ReadAllText(rutaArchivo)
            Dim objetoCifrado = JsonConvert.DeserializeObject(Of LicenciaCifrada)(jsonEnvoltura)

            If String.IsNullOrWhiteSpace(objetoCifrado?.datos) Then Return Nothing

            Dim jsonDesencriptado As String = Desencriptar(objetoCifrado.datos)
            Return JsonConvert.DeserializeObject(Of Licencia)(jsonDesencriptado)
        Catch ex As Exception
            'MessageBox.Show("Error al leer o desencriptar licencia: " & ex.Message)
            Return Nothing
        End Try
    End Function
    Public Shared Function CpuId() As String
        Dim cpu_ids As String = ""
        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Processor")
        For Each cpu As ManagementObject In searcher.Get()
            cpu_ids = cpu_ids & ", " & cpu("ProcessorId").ToString()
        Next
        If cpu_ids.Length > 0 Then cpu_ids = cpu_ids.Substring(2)
        Return cpu_ids
    End Function
    Public Shared Function LicenciaEsValida(licencia As Licencia) As Boolean
        If licencia Is Nothing Then Return False
        If licencia.idestatusserial <> 1 Then Return False
        If Not licencia.fechavencimientoserial.HasValue OrElse licencia.fechavencimientoserial.Value < DateTime.Now Then Return False
        Return True
    End Function

End Class

