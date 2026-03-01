' Capa_Datos/Conexion/DatabaseConfig.vb
Imports System.IO
Imports Capa_Entidad
Imports Capa_Operacion
Imports Newtonsoft.Json
Imports NLog

Public Module DatabaseConfig

    Private ReadOnly _logger As Logger = LogManager.GetCurrentClassLogger()

    Private _cadenaCache As String
    Private _cadenaCachePerfiles As String
    Private ReadOnly _lock As New Object()
    Public Function CrearConexion() As Data.SqlClient.SqlConnection
        Return New Data.SqlClient.SqlConnection(GetConnectionString())
    End Function
    Public Function CrearConexionPerfiles() As Data.SqlClient.SqlConnection
        Return New Data.SqlClient.SqlConnection(GetConnectionStringPerfiles())
    End Function
    Public Function GetConnectionString() As String
        If Not String.IsNullOrEmpty(_cadenaCache) Then
            Return _cadenaCache
        End If

        SyncLock _lock
            If Not String.IsNullOrEmpty(_cadenaCache) Then
                Return _cadenaCache
            End If

            Dim config As ConfiguracionApp = LeerConfig()

            If config Is Nothing Then
                Throw New InvalidOperationException("No se encontró configuración de base de datos.")
            End If

            Dim passwordReal As String = SeguridadHelper.DecryptString(config.PasswordBDD, ObtenerClaveSistema())

            Dim servidor As String
            If config.Estacion AndAlso
               Not String.IsNullOrEmpty(config.IpServidor) Then
                servidor = If(String.IsNullOrEmpty(config.InstanciaBDD),
                    config.IpServidor,
                    String.Format("{0}\{1}",
                        config.IpServidor, config.InstanciaBDD))
            Else
                servidor = config.InstanciaBDD
            End If

            _cadenaCache = String.Format(
                "Server={0};Database={1};User Id={2};Password={3};" &
                "Connection Timeout=10;",
                servidor,
                config.BaseDeDatos,
                config.UsuarioBDD,
                passwordReal)

            Return _cadenaCache
        End SyncLock
    End Function
    Public Function GetConnectionStringPerfiles() As String
        If Not String.IsNullOrEmpty(_cadenaCachePerfiles) Then
            Return _cadenaCachePerfiles
        End If

        SyncLock _lock
            If Not String.IsNullOrEmpty(_cadenaCachePerfiles) Then
                Return _cadenaCachePerfiles
            End If

            Dim config As ConfiguracionApp = LeerConfig()

            If config Is Nothing Then
                Throw New InvalidOperationException("No se encontró configuración de base de datos.")
            End If

            Dim passwordReal As String = SeguridadHelper.DecryptString(config.PasswordBDD, ObtenerClaveSistema())

            Dim servidor As String
            If config.Estacion AndAlso
               Not String.IsNullOrEmpty(config.IpServidor) Then
                servidor = If(String.IsNullOrEmpty(config.InstanciaBDD),
                    config.IpServidor,
                    String.Format("{0}\{1}",
                        config.IpServidor, config.InstanciaBDD))
            Else
                servidor = config.InstanciaBDD
            End If

            _cadenaCachePerfiles = String.Format(
                "Server={0};Database={1};User Id={2};Password={3};" &
                "Connection Timeout=10;",
                servidor,
                config.BaseDeDatosPerfiles,
                config.UsuarioBDD,
                passwordReal)

            Return _cadenaCachePerfiles
        End SyncLock
    End Function
    Public Sub LimpiarCache()
        SyncLock _lock
            _cadenaCache = Nothing
        End SyncLock
    End Sub

    Private Function LeerConfig() As ConfiguracionApp
        If Not File.Exists(ConfiguracionApp.RutaConfig) Then
            Return Nothing
        End If
        Dim json As String = File.ReadAllText(ConfiguracionApp.RutaConfig, System.Text.Encoding.UTF8)
        Return JsonConvert.DeserializeObject(Of ConfiguracionApp)(json)
    End Function

    Private Function ObtenerClaveSistema() As String
        Return SeguridadHelper.ComputeSHA256("CCotton2026$ConfiguracionSegura")
    End Function

End Module