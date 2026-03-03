Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports Capa_Entidad
Imports Capa_Operacion.Configuracion
Imports Newtonsoft.Json
Imports NLog

Public Class LicenciaApiCliente
    Implements IDisposable

    Private ReadOnly _logger As Logger =
        LogManager.GetCurrentClassLogger()

    Private ReadOnly _httpClient As HttpClient
    Private ReadOnly _apiKey As String
    Private ReadOnly _apiSecret As String
    Private _disposed As Boolean = False

    ' HttpClient estático compartido — evita socket exhaustion
    Private Shared ReadOnly _clienteCompartido As HttpClient = CrearHttpClient()

    Public Sub New()
        _apiKey = AppConfig.LicenciaApiKey
        _apiSecret = AppConfig.LicenciaApiSecret
        _httpClient = _clienteCompartido
    End Sub

    ' ─── Verificar conectividad con la API ───────────────────────────────────
    Public Async Function VerificarConectividadAsync() As Task(Of Boolean)
        Try
            Dim response As HttpResponseMessage = Await _httpClient.GetAsync("ping").ConfigureAwait(False)
            Return response.IsSuccessStatusCode
        Catch
            Return False
        End Try
    End Function

    ' ─── Verificar licencia contra Flask API ─────────────────────────────────
    Public Async Function VerificarAsync(serial As String, hardwareId As String, nombreCliente As String, emailCliente As String, cantidad As Integer, idperiodo As Integer, fechavencimiento As DateTime, nombreContacto As String, telefonoContacto As String) As Task(Of LicenciaInfo)
        Try
            Dim body = New With {
            .serial_orig = serial,
            .cpu_id = hardwareId,
            .app_version = AppConfig.Version,
            .fecha_cliente = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss"),
            .nombre_cliente = nombreCliente,
            .email_cliente = emailCliente,
            .cantidad = cantidad,
            .idperiodo = idperiodo,
            .nombre_contacto = nombreContacto,
            .telefono_contacto = telefonoContacto,
            .fechavencimiento = fechavencimiento
        }

            Dim json As String = JsonConvert.SerializeObject(body)
            Dim timestamp As String = ObtenerTimestamp()
            Dim firma As String = GenerarFirma(timestamp)

            System.Diagnostics.Debug.WriteLine("=== REQUEST A FLASK ===")
            System.Diagnostics.Debug.WriteLine("Body: " & json)
            System.Diagnostics.Debug.WriteLine("=======================")

            Dim request As New HttpRequestMessage(HttpMethod.Post, "licencia/verificar")
            request.Content = New StringContent(json, Encoding.UTF8, "application/json")
            request.Headers.Add("X-API-Key", _apiKey)
            request.Headers.Add("X-Timestamp", timestamp)
            request.Headers.Add("X-Signature", firma)

            Dim response As HttpResponseMessage = Await _httpClient.SendAsync(request).ConfigureAwait(False)

            Dim respuestaJson As String = Await response.Content.ReadAsStringAsync().ConfigureAwait(False)

            System.Diagnostics.Debug.WriteLine("=== RESPUESTA FLASK ===")
            System.Diagnostics.Debug.WriteLine("Status: " & CInt(response.StatusCode).ToString())
            System.Diagnostics.Debug.WriteLine("Body: " & respuestaJson)
            System.Diagnostics.Debug.WriteLine("=======================")

            If Not response.IsSuccessStatusCode Then
                _logger.Warn("API respondió {0}: {1}", CInt(response.StatusCode), respuestaJson)
                Return RespuestaError(String.Format("Error del servidor: {0}", respuestaJson))
            End If

            Return ProcesarRespuesta(respuestaJson)

        Catch ex As TaskCanceledException
            _logger.Warn("Timeout al conectar con servidor de licencias.")
            Throw New HttpRequestException("Timeout de conexión.")
        Catch ex As HttpRequestException
            _logger.Warn("Sin conexión: {0}", ex.Message)
            Throw
        Catch ex As Exception
            _logger.Error(ex, "Error en LicenciaApiCliente.VerificarAsync")
            Return RespuestaError("Error inesperado.")
        End Try
    End Function
    Public Async Function ConsultarAsync(serial As String) As Task(Of ConsultaLicenciaResult)
        Try
            Dim body = New With {
            .serial_orig = serial.Trim().ToUpper()
        }

            Dim json As String = JsonConvert.SerializeObject(body)
            Dim timestamp As String = ObtenerTimestamp()
            Dim firma As String = GenerarFirma(timestamp)

            Dim request As New HttpRequestMessage(HttpMethod.Post, "licencia/consultar")

            request.Content = New StringContent(json, Encoding.UTF8, "application/json")
            request.Headers.Add("X-API-Key", _apiKey)
            request.Headers.Add("X-Timestamp", timestamp)
            request.Headers.Add("X-Signature", firma)

            Dim response As HttpResponseMessage = Await _httpClient.SendAsync(request).ConfigureAwait(False)

            Dim respuestaJson As String = Await response.Content.ReadAsStringAsync().ConfigureAwait(False)

            System.Diagnostics.Debug.WriteLine("=== CONSULTA SERIAL ===")
            System.Diagnostics.Debug.WriteLine("Status: " & CInt(response.StatusCode).ToString())
            System.Diagnostics.Debug.WriteLine("Body: " & respuestaJson)
            System.Diagnostics.Debug.WriteLine("=======================")

            If Not response.IsSuccessStatusCode Then
                Return New ConsultaLicenciaResult With {
                .Encontrado = False,
                .Mensaje = "Error al consultar serial."
            }
            End If

            Return ProcesarConsulta(respuestaJson)

        Catch ex As Exception
            _logger.Warn(ex, "Error en ConsultarAsync.")
            Return New ConsultaLicenciaResult With {
            .Encontrado = False,
            .Mensaje = "Sin conexión con el servidor."
        }
        End Try
    End Function
    Private Function ProcesarConsulta(json As String) As ConsultaLicenciaResult
        Try
            Dim d = Newtonsoft.Json.Linq.JObject.Parse(json)

            Dim encontrado As Boolean = If(
            d("encontrado") IsNot Nothing,
            CBool(d("encontrado")), False)

            If Not encontrado Then
                Return New ConsultaLicenciaResult With {
                .encontrado = False,
                .Mensaje = ObtenerValorToken(d, "mensaje")
            }
            End If

            ' ── Fecha vencimiento — real si activo, proyectada si inactivo ────────
            Dim fechaVenc As DateTime? = Nothing

            Dim clavesFecha As String() = {
            "fecha_vencimiento",
            "fecha_vencimiento_proyectada"
        }

            For Each clave As String In clavesFecha
                If d(clave) IsNot Nothing AndAlso
               d(clave).Type <> Newtonsoft.Json.Linq.JTokenType.Null Then
                    Dim fechaStr As String = d(clave).ToString()
                    Dim fechaParsed As DateTime
                    If DateTime.TryParse(fechaStr, fechaParsed) Then
                        fechaVenc = fechaParsed.ToLocalTime()
                        Exit For
                    End If
                End If
            Next

            Return New ConsultaLicenciaResult With {
            .Encontrado = True,
            .Mensaje = ObtenerValorToken(d, "mensaje"),
            .EstatusInt = If(d("idestatusserial") IsNot Nothing, CInt(d("idestatusserial")), 0),
            .Estatus = ObtenerValorToken(d, "estatus"),
            .IdPeriodo = If(d("idperiodo") IsNot Nothing, CInt(d("idperiodo")), 0),
            .Periodo = ObtenerValorToken(d, "periodo"),
            .Cantidad = If(d("cantidad") IsNot Nothing, CInt(d("cantidad")), 0),
            .FechaVencimiento = fechaVenc,
            .NombreCliente = ObtenerValorToken(d, "nombre_cliente"),
            .EmailCliente = ObtenerValorToken(d, "email_cliente"),
            .NombreContacto = ObtenerValorToken(d, "nombre_contacto"),
            .TelefonoContacto = ObtenerValorToken(d, "telefono_contacto")
        }

        Catch ex As Exception
            _logger.Error(ex, "Error al parsear respuesta de consulta.")
            Return New ConsultaLicenciaResult With {
            .Encontrado = False,
            .Mensaje = "Error al procesar respuesta."
        }
        End Try
    End Function

    Private Function ProcesarRespuesta(json As String) As LicenciaInfo
        Try
            Dim data As Object = JsonConvert.DeserializeObject(json)
            If data Is Nothing Then
                Return RespuestaError("Respuesta inválida del servidor.")
            End If

            Dim d = DirectCast(data, Newtonsoft.Json.Linq.JObject)

            Dim fechaVenc As DateTime? = Nothing
            If d("fecha_vencimiento") IsNot Nothing AndAlso d("fecha_vencimiento").Type <> Newtonsoft.Json.Linq.JTokenType.Null Then
                Dim fechaStr As String = d("fecha_vencimiento").ToString()
                Dim fechaParsed As DateTime
                If DateTime.TryParse(fechaStr, fechaParsed) Then
                    fechaVenc = fechaParsed.ToLocalTime()
                End If
            End If

            Return New LicenciaInfo With {
            .Estatus = ParsearEstatus(ObtenerValorToken(d, "estatus")),
            .Mensaje = ObtenerValorToken(d, "mensaje"),
            .DiasRestantes = If(
                d("dias_restantes") IsNot Nothing AndAlso
                d("dias_restantes").Type <>
                Newtonsoft.Json.Linq.JTokenType.Null,
                CInt(d("dias_restantes")), 0),
            .EnPeriodoGracia = If(
                d("en_periodo_gracia") IsNot Nothing AndAlso
                d("en_periodo_gracia").Type <>
                Newtonsoft.Json.Linq.JTokenType.Null,
                CBool(d("en_periodo_gracia")), False),
            .FechaVencimiento = fechaVenc,
            .Periodo = ObtenerValorToken(d, "periodo"),
            .NombreCliente = ObtenerValorToken(d, "nombre_cliente"),
            .EmailCliente = ObtenerValorToken(d, "email_cliente"),     ' ✅ nuevo
            .NombreContacto = ObtenerValorToken(d, "nombre_contacto"),   ' ✅ nuevo
            .TelefonoContacto = ObtenerValorToken(d, "telefono_contacto")  ' ✅ nuevo
        }

        Catch ex As Exception
            _logger.Error(ex, "Error al deserializar respuesta de licencia.")
            Return RespuestaError("Respuesta del servidor no reconocida.")
        End Try
    End Function

    ' ─── Helper — obtener valor de token sin ?. ni ?? ────────────────────────────
    Private Shared Function ObtenerValorToken(d As Newtonsoft.Json.Linq.JObject, clave As String) As String
        If d(clave) Is Nothing OrElse d(clave).Type = Newtonsoft.Json.Linq.JTokenType.Null Then
            Return String.Empty
        End If
        Return d(clave).ToString()
    End Function

    ' ─── Generar firma HMAC-SHA256 — anti replay attack ──────────────────────
    Private Function GenerarFirma(timestamp As String) As String
        Dim mensaje As String = String.Format("{0}{1}", _apiKey, timestamp)
        Using hmac = New HMACSHA256(Encoding.UTF8.GetBytes(_apiSecret))
            Dim hashBytes As Byte() = hmac.ComputeHash(Encoding.UTF8.GetBytes(mensaje))
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using
    End Function

    ' ─── Timestamp Unix en segundos ───────────────────────────────────────────
    Private Shared Function ObtenerTimestamp() As String
        Dim epoch As New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
        Return CLng((DateTime.UtcNow - epoch).TotalSeconds).ToString()
    End Function

    ' ─── Crear HttpClient con configuración optimizada ────────────────────────
    Private Shared Function CrearHttpClient() As HttpClient
        Dim baseUrl As String = AppConfig.ApiBaseUrl
        Dim cliente As New HttpClient()
        cliente.BaseAddress = New Uri(baseUrl)
        cliente.Timeout = TimeSpan.FromSeconds(Constantes.TIMEOUT_API_SEG)
        cliente.DefaultRequestHeaders.Accept.Add(
            New MediaTypeWithQualityHeaderValue("application/json"))
        Return cliente
    End Function

    ' ─── Parsear estatus ──────────────────────────────────────────────────────
    Private Shared Function ParsearEstatus(estatus As String) As EstatusSerial
        Select Case If(estatus, String.Empty).ToLower()
            Case "activo" : Return EstatusSerial.Activo
            Case "vencido" : Return EstatusSerial.Vencido
            Case "inhabilitado" : Return EstatusSerial.Inhabilitado
            Case "inactivo" : Return EstatusSerial.Inactivo
            Case Else : Return EstatusSerial.Inhabilitado
        End Select
    End Function

    ' ─── Respuesta de error ───────────────────────────────────────────────────
    Private Shared Function RespuestaError(mensaje As String) As LicenciaInfo
        Return New LicenciaInfo With {
            .Estatus = EstatusSerial.Inhabilitado,
            .Mensaje = mensaje,
            .DiasRestantes = 0,
            .EnPeriodoGracia = False
        }
    End Function

    ' ─── IDisposable ─────────────────────────────────────────────────────────
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No disponer _clienteCompartido — es intencional que sea reutilizable
        _disposed = True
    End Sub

End Class