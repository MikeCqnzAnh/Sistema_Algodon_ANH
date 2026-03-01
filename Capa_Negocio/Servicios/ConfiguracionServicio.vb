Imports System.IO
Imports System.Xml
Imports Capa_Entidad
Imports Capa_Operacion
Imports Capa_Operacion.Configuracion
Imports Newtonsoft.Json
Imports NLog
Imports Formatting = Newtonsoft.Json.Formatting

Public Class ConfiguracionServicio

    Private ReadOnly _logger As Logger =
        LogManager.GetCurrentClassLogger()

    Public Function Leer() As ConfiguracionApp
        Try
            If Not File.Exists(ConfiguracionApp.RutaConfig) Then
                Return Nothing
            End If

            Dim json As String = File.ReadAllText(ConfiguracionApp.RutaConfig, System.Text.Encoding.UTF8)

            Dim config As ConfiguracionApp = JsonConvert.DeserializeObject(Of ConfiguracionApp)(json)

            If config Is Nothing Then Return Nothing

            ' Desencriptar contraseña
            If Not String.IsNullOrEmpty(config.PasswordBDD) Then
                Try
                    config.PasswordBDD = SeguridadHelper.DecryptString(config.PasswordBDD, ObtenerClaveSistema())
                Catch
                    ' Contraseña en texto plano — usar tal cual
                End Try
            End If

            Return config
        Catch ex As Exception
            _logger.Error(ex, "Error al leer configuración.")
            Return Nothing
        End Try
    End Function

    Public Function Guardar(config As ConfiguracionApp) As Boolean
        Try
            Dim directorio As String = Path.GetDirectoryName(ConfiguracionApp.RutaConfig)
            If Not Directory.Exists(directorio) Then
                Directory.CreateDirectory(directorio)
            End If

            Dim configAGuardar As New ConfiguracionApp With {
                .InstanciaBDD = config.InstanciaBDD,
                .BaseDeDatosPerfiles = config.BaseDeDatosPerfiles,
                .BaseDeDatos = config.BaseDeDatos,
                .UsuarioBDD = config.UsuarioBDD,
                .PasswordBDD = SeguridadHelper.EncryptString(config.PasswordBDD, ObtenerClaveSistema()),
                .Servidor = config.Servidor,
                .Estacion = config.Estacion,
                .IpServidor = config.IpServidor
            }

            Dim json As String = JsonConvert.SerializeObject(configAGuardar, Formatting.Indented)
            File.WriteAllText(ConfiguracionApp.RutaConfig, json, System.Text.Encoding.UTF8)

            ' Limpiar cache de conexión
            Capa_Datos.DatabaseConfig.LimpiarCache()

            Return True
        Catch ex As Exception
            _logger.Error(ex, "Error al guardar configuración.")
            Return False
        End Try
    End Function

    Public Function ExisteConfiguracion() As Boolean
        Return File.Exists(ConfiguracionApp.RutaConfig)
    End Function

    Public Function ProbarConexion(config As ConfiguracionApp) As Boolean
        Try
            'Dim password As String = SeguridadHelper.DecryptString(config.PasswordBDD, ObtenerClaveSistema())
            Dim password As String = config.PasswordBDD
            Dim servidor As String = If(
                    config.Estacion AndAlso
                    Not String.IsNullOrEmpty(config.IpServidor),
                    If(String.IsNullOrEmpty(config.InstanciaBDD),
                        config.IpServidor,
                        String.Format("{0}\{1}",
                            config.IpServidor, config.InstanciaBDD)),
                    config.InstanciaBDD)

            Dim cadena As String = String.Format(
                "Server={0};Database={1};User Id={2};Password={3};" &
                "Connection Timeout=5;",
                servidor, config.BaseDeDatos,
                config.UsuarioBDD, password)

            Using conn = New Data.SqlClient.SqlConnection(cadena)
                conn.Open()
                Return True
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Function ProbarAccesoRed(ipServidor As String) As Boolean
        Try
            Dim ruta As String = String.Format(
                "\\{0}\{1}", ipServidor, Constantes.CARPETA_DATOS)
            If Not Directory.Exists(ruta) Then Return False

            Dim rutaLic As String = Path.Combine(
                ruta, "licencia_cifrada.dat")
            Dim rutaServerId As String = Path.Combine(ruta, "server.id")

            Return File.Exists(rutaLic) AndAlso
                   File.Exists(rutaServerId)
        Catch
            Return False
        End Try
    End Function

    Public Shared Function ObtenerClaveSistema() As String
        Return SeguridadHelper.ComputeSHA256("CCotton2026$ConfiguracionSegura")
    End Function

End Class