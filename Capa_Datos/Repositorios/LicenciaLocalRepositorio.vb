Imports System.IO
Imports Capa_Entidad
Imports Capa_Operacion
Imports Newtonsoft.Json
Imports NLog

Public Class LicenciaLocalRepositorio

    Private ReadOnly _rutaArchivo As String
    Private ReadOnly _claveEncriptacion As String
    Private ReadOnly _logger As Logger =
        LogManager.GetCurrentClassLogger()

    Private Shared ReadOnly RutaLocal As String = ConfiguracionApp.RutaLicencia

    Public Sub New(claveEncriptacion As String)
        _rutaArchivo = RutaLocal
        _claveEncriptacion = claveEncriptacion
    End Sub

    Public Sub New(claveEncriptacion As String, rutaArchivo As String)
        _claveEncriptacion = claveEncriptacion
        _rutaArchivo = rutaArchivo
    End Sub

    Public Function Leer() As LicenciaLocal
        If Not File.Exists(_rutaArchivo) Then Return Nothing

        Try
            Dim contenido As String = File.ReadAllText(_rutaArchivo)
            Dim json As String = SeguridadHelper.DecryptString(contenido, _claveEncriptacion)

            Dim lic As LicenciaLocal = JsonConvert.DeserializeObject(Of LicenciaLocal)(json)
            If lic Is Nothing Then Return Nothing

            Dim checksumEsperado As String = ComputarChecksum(lic)
            If lic.Checksum <> checksumEsperado Then Return Nothing

            Return lic
        Catch
            Return Nothing
        End Try
    End Function

    Public Sub Guardar(licencia As LicenciaLocal)
        Try
            licencia.Checksum = ComputarChecksum(licencia)

            Dim json As String = JsonConvert.SerializeObject(licencia)
            Dim encrypted As String = SeguridadHelper.EncryptString(
                json, _claveEncriptacion)

            Dim directorio As String = Path.GetDirectoryName(_rutaArchivo)
            If Not Directory.Exists(directorio) Then
                Directory.CreateDirectory(directorio)
            End If

            File.WriteAllText(_rutaArchivo, encrypted)
        Catch
            ' Silencioso
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            If File.Exists(_rutaArchivo) Then
                File.Delete(_rutaArchivo)
            End If
        Catch
        End Try
    End Sub

    Public Function ObtenerSerial() As String
        Try
            Dim local As LicenciaLocal = Leer()
            If local Is Nothing OrElse
               String.IsNullOrEmpty(local.SerialEncriptado) Then
                Return Nothing
            End If
            Return SeguridadHelper.DecryptString(local.SerialEncriptado, _claveEncriptacion)
        Catch ex As Exception
            _logger.Warn(ex, "No se pudo obtener serial desde archivo.")
            Return Nothing
        End Try
    End Function

    Private Function ComputarChecksum(lic As LicenciaLocal) As String
        Dim data As String = String.Format("{0}{1}{2}{3}",
            lic.SerialEncriptado,
            lic.UltimaVerificacion.ToString("yyyyMMddHHmmss"),
            CInt(lic.UltimoEstatus),
            lic.DiasGraciaOffline)
        Return SeguridadHelper.ComputeSHA256(data)
    End Function

End Class