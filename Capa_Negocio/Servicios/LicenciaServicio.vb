' Capa_Negocio/Servicios/LicenciaServicio.vb
Imports System.IO
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Capa_Datos
Imports Capa_Entidad
Imports Capa_Operacion
Imports Capa_Operacion.Configuracion
Imports NLog
Public Class LicenciaServicio

    Private ReadOnly _logger As Logger = LogManager.GetCurrentClassLogger()
    Private ReadOnly _repoLocal As LicenciaLocalRepositorio
    Private ReadOnly _apiClient As LicenciaApiCliente
    Private ReadOnly _configServicio As ConfiguracionServicio

    Dim DIAS_GRACIA_OFFLINE As Integer = 3
    Private Shared _cacheActual As LicenciaInfo

    Public Sub New()
        Dim hardwareId As String = HardwareHelper.ObtenerHardwareId()
        _repoLocal = New LicenciaLocalRepositorio(hardwareId)
        _apiClient = New LicenciaApiCliente()
        _configServicio = New ConfiguracionServicio()
    End Sub

    ' ─── Método principal ──────────────────────────────────────────────────
    Public Async Function VerificarLicenciaAsync(
    serial As String,
    Optional nombreCliente As String = "",
    Optional emailCliente As String = "",
    Optional cantidad As Integer = 0,
    Optional idperiodo As Integer = 0,
    Optional fechavencimiento As DateTime? = Nothing,
    Optional nombreContacto As String = "",
    Optional telefonoContacto As String = "") As Task(Of LicenciaInfo)

        Dim config As ConfiguracionApp = _configServicio.Leer()
        Dim resultado As LicenciaInfo

        If config IsNot Nothing AndAlso config.Estacion Then
            resultado = Await VerificarComoEstacionAsync(config).ConfigureAwait(False)
        Else
            resultado = Await VerificarComoServidorAsync(serial, nombreCliente, emailCliente, cantidad, idperiodo, fechavencimiento, nombreContacto, telefonoContacto).ConfigureAwait(False)
        End If

        _cacheActual = resultado
        Return resultado
    End Function

    ' ─── MODO ESTACIÓN ────────────────────────────────────────────────────
    Private Async Function VerificarComoEstacionAsync(config As ConfiguracionApp) As Task(Of LicenciaInfo)

        Return Await Task.Run(Function()
                                  Try
                                      Dim rutaLicencia As String =
                                          config.ObtenerRutaLicenciaRed()

                                      If Not File.Exists(rutaLicencia) Then
                                          Return New LicenciaInfo With {
                                              .Estatus = EstatusSerial.Inhabilitado,
                                              .Mensaje = String.Format(
                                                  "Archivo de licencia no encontrado en:{0}{1}",
                                                  Environment.NewLine, rutaLicencia)
                                          }
                                      End If

                                      Dim hardwareIdServidor As String =
                                          LeerServerIdDesdeRed(config.IpServidor)

                                      If String.IsNullOrEmpty(hardwareIdServidor) Then
                                          Return New LicenciaInfo With {
                                              .Estatus = EstatusSerial.Inhabilitado,
                                              .Mensaje = "No se pudo leer la identidad del servidor."
                                          }
                                      End If

                                      Dim repoRed = New LicenciaLocalRepositorio(
                                          hardwareIdServidor, rutaLicencia)

                                      Dim licServidor As LicenciaLocal = repoRed.Leer()

                                      If licServidor Is Nothing Then
                                          Return New LicenciaInfo With {
                                              .Estatus = EstatusSerial.Inhabilitado,
                                              .Mensaje = "Archivo de licencia dañado o manipulado."
                                          }
                                      End If

                                      Return EvaluarLicenciaDesdeArchivo(licServidor)

                                  Catch ex As UnauthorizedAccessException
                                      Return New LicenciaInfo With {
                                          .Estatus = EstatusSerial.Inhabilitado,
                                          .Mensaje = "Sin permisos para acceder a la carpeta compartida."
                                      }
                                  Catch ex As IOException
                                      Return New LicenciaInfo With {
                                          .Estatus = EstatusSerial.Inhabilitado,
                                          .Mensaje = "Error de red al leer la licencia."
                                      }
                                  Catch ex As Exception
                                      Return New LicenciaInfo With {
                                          .Estatus = EstatusSerial.Inhabilitado,
                                          .Mensaje = "Error inesperado al verificar licencia."
                                      }
                                  End Try
                              End Function).ConfigureAwait(False)
    End Function

    ' ─── Evaluar lic.dat ──────────────────────────────────────────────────
    Private Function EvaluarLicenciaDesdeArchivo(lic As LicenciaLocal) As LicenciaInfo

        If lic.UltimoEstatus = EstatusSerial.Inhabilitado Then
            Return New LicenciaInfo With {
                .Estatus = EstatusSerial.Inhabilitado,
                .Mensaje = "Licencia inhabilitada. Contacte al administrador."
            }
        End If

        Dim ahora As DateTime = DateTime.UtcNow
        Dim horasSinVerificar As Double =
            (ahora - lic.UltimaVerificacion).TotalHours

        If horasSinVerificar <= 24 Then
            Return New LicenciaInfo With {
                .Estatus = lic.UltimoEstatus,
                .DiasRestantes = lic.DiasGraciaOffline,
                .EnPeriodoGracia = lic.UltimoEstatus = EstatusSerial.Vencido,
                .Mensaje = String.Format(
                    "Licencia verificada hace {0:F0} horas.",
                    horasSinVerificar)
            }
        End If

        Dim diasSinVerificar As Integer = CInt(horasSinVerificar \ 24)
        Dim diasGraciaRestantes As Integer =
            Constantes.DIAS_GRACIA - diasSinVerificar

        If diasGraciaRestantes > 0 Then
            Return New LicenciaInfo With {
                .Estatus = lic.UltimoEstatus,
                .EnPeriodoGracia = True,
                .DiasRestantes = diasGraciaRestantes,
                .Mensaje = String.Format(
                    "Servidor lleva {0} día(s) sin verificar." &
                    " Quedan {1} día(s) de gracia.",
                    diasSinVerificar, diasGraciaRestantes)
            }
        End If

        Return New LicenciaInfo With {
            .Estatus = EstatusSerial.Inhabilitado,
            .Mensaje = String.Format(
                "Servidor lleva {0} día(s) sin verificar." &
                " Gracia agotada.", diasSinVerificar)
        }
    End Function

    ' ─── MODO SERVIDOR ────────────────────────────────────────────────────
    Private Async Function VerificarComoServidorAsync(serial As String, nombreCliente As String, emailCliente As String, cantidad As Integer, idperiodo As Integer, fechavencimiento As DateTime, nombreContacto As String, telefonoContacto As String) As Task(Of LicenciaInfo)

        Dim hardwareId As String = HardwareHelper.ObtenerHardwareId()
        Try
            ' ✅ Pasar todos los campos al ApiCliente
            Dim resultado As LicenciaInfo = Await _apiClient.VerificarAsync(serial, hardwareId, nombreCliente, emailCliente, cantidad, idperiodo, fechavencimiento, nombreContacto, telefonoContacto).ConfigureAwait(False)

            If resultado Is Nothing Then
                Return VerificarOfflineServidor()
            End If

            GuardarEstadoLocal(serial, nombreCliente, emailCliente, cantidad, idperiodo, fechavencimiento, nombreContacto, telefonoContacto, hardwareId, resultado)
            Return resultado

        Catch ex As HttpRequestException
            Return VerificarOfflineServidor()
        Catch ex As TaskCanceledException
            Return VerificarOfflineServidor()
        Catch ex As Exception
            _logger.Error(ex, "Error verificando servidor.")
            Return VerificarOfflineServidor()
        End Try
    End Function

    Private Function VerificarOfflineServidor() As LicenciaInfo
        Try
            Dim graciaServicio = New GraciaOfflineServicio(HardwareHelper.ObtenerHardwareId())
            Dim resultado As ResultadoGraciaOffline = graciaServicio.Evaluar()

            If resultado.SinDatosLocales OrElse
               Not resultado.Permitido Then
                Return New LicenciaInfo With {
                    .Estatus = EstatusSerial.Inhabilitado,
                    .Mensaje = resultado.Mensaje
                }
            End If

            Dim local As LicenciaLocal = _repoLocal.Leer()
            Return New LicenciaInfo With {
                .Estatus = If(
                    local IsNot Nothing AndAlso
                    local.UltimoEstatus = EstatusSerial.Activo,
                    EstatusSerial.Activo,
                    EstatusSerial.Vencido),
                .EnPeriodoGracia = True,
                .DiasRestantes = resultado.DiasRestantes,
                .Mensaje = resultado.Mensaje
            }
        Catch ex As Exception
            Return New LicenciaInfo With {
                .Estatus = EstatusSerial.Inhabilitado,
                .Mensaje = "Error al verificar licencia offline."
            }
        End Try
    End Function
    Public Async Function ConsultarSerialAsync(serial As String) As Task(Of ConsultaLicenciaResult)

        Try
            Return Await _apiClient.ConsultarAsync(serial).ConfigureAwait(False)

        Catch ex As Exception
            _logger.Warn(ex, "Error al consultar serial.")
            Return New ConsultaLicenciaResult With {
            .Encontrado = False,
            .Mensaje = "Error al consultar el serial."
        }
        End Try
    End Function
    Private Sub GuardarEstadoLocal(serial As String, nombrecliente As String, emailclienta As String, cantidad As Integer, idperiodo As Integer, fechavencimiento As DateTime, nombrecontacto As String, telefonocontacto As String, hardwareId As String, info As LicenciaInfo)
        Try
            Dim ahora As DateTime = DateTime.UtcNow
            _repoLocal.Guardar(New LicenciaLocal With {
                    .SerialEncriptado = SeguridadHelper.EncryptString(serial, hardwareId),
                    .NombreCliente = nombrecliente,
                    .EmailCliente = emailclienta,
                    .Cantidad = cantidad,
                    .IdPeriodo = idperiodo,
                    .FechaVencimiento = fechavencimiento,
                    .NombreContacto = nombrecontacto,
                    .TelefonoContacto = telefonocontacto,
                    .UltimaVerificacion = ahora,
                    .UltimoEstatus = info.Estatus,
                    .DiasGraciaOffline = Constantes.DIAS_GRACIA,
                    .DiasOfflineConsumidos = 0,
                    .UltimaFechaRegistrada = ahora
                })
            GuardarHardwareIdServidor(hardwareId)
        Catch ex As Exception
            _logger.Warn(ex, "No se pudo guardar estado local.")
        End Try
    End Sub

    Private Sub GuardarHardwareIdServidor(hardwareId As String)
        Try
            Dim directorio As String = Path.GetDirectoryName(ConfiguracionApp.RutaLicencia)
            If Not Directory.Exists(directorio) Then
                Directory.CreateDirectory(directorio)
            End If
            File.WriteAllText(Path.Combine(directorio, "server.id"), hardwareId)
        Catch
        End Try
    End Sub

    Private Function LeerServerIdDesdeRed(ipServidor As String) As String
        Try
            Dim ruta As String = String.Format("\\{0}\{1}\server.id", ipServidor, Constantes.CARPETA_DATOS)
            If Not File.Exists(ruta) Then Return Nothing
            Return File.ReadAllText(ruta).Trim()
        Catch
            Return Nothing
        End Try
    End Function

    ' ─── Métodos públicos auxiliares ──────────────────────────────────────
    Public Function ExisteArchivoLicencia() As Boolean
        Return File.Exists(ConfiguracionApp.RutaLicencia)
    End Function
    Public Function obtenerlicencialocal(Optional rutared As String = "") As LicenciaLocal
        Return _repoLocal.Leer(rutared, LeerServerIdDesdeRed("192.168.100.15"))
    End Function
    Public Function ObtenerSerialDesdeArchivo() As String
        Return _repoLocal.ObtenerSerial()
    End Function

    Public Async Function HayConexionConServidorAsync() As Task(Of Boolean)
        Try
            Return Await _apiClient.VerificarConectividadAsync().ConfigureAwait(False)
        Catch
            Return False
        End Try
    End Function

    Public Shared Function EstaActiva() As Boolean
        If _cacheActual Is Nothing Then Return False
        Return _cacheActual.Estatus = EstatusSerial.Activo OrElse
              (_cacheActual.Estatus = EstatusSerial.Vencido AndAlso
               _cacheActual.EnPeriodoGracia)
    End Function

End Class