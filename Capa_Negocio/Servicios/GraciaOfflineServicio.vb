' Capa_Negocio/Servicios/GraciaOfflineServicio.vb
Imports Algodon_ANH.Capa_Datos
Imports Algodon_ANH.Capa_Entidad
Imports Algodon_ANH.Capa_Operacion
Imports Capa_Datos
Imports Capa_Entidad
Imports NLog

Public Class GraciaOfflineServicio

    Private ReadOnly _logger As Logger =
        LogManager.GetCurrentClassLogger()

    Private ReadOnly _repoLocal As LicenciaLocalRepositorio
    Private Const DIAS_GRACIA_MAXIMO As Integer = 3

    ' ─── Constructor modo SERVIDOR — ruta local ──────────────────────────────
    Public Sub New(hardwareId As String)
        _repoLocal = New LicenciaLocalRepositorio(hardwareId)
    End Sub

    ' ─── Constructor modo ESTACIÓN — ruta de red ─────────────────────────────
    Public Sub New(hardwareIdServidor As String, rutaRed As String)
        _repoLocal = New LicenciaLocalRepositorio(hardwareIdServidor, rutaRed)
    End Sub

    ' ─── Método principal — evaluar gracia offline ───────────────────────────
    Public Function Evaluar() As ResultadoGraciaOffline

        Dim local As LicenciaLocal = _repoLocal.Leer()

        If local Is Nothing Then
            Return ResultadoGraciaOffline.SinDatos()
        End If

        Dim ahora As DateTime = DateTime.UtcNow

        ' Incrementar contador de apertura siempre
        local.ContadorApertura += 1

        ' Detectar manipulación de fecha
        Dim fechaManipulada As Boolean = DetectarManipulacion(local, ahora)

        If fechaManipulada Then
            _logger.Warn("Manipulación de fecha detectada. " & "Consumiendo día de gracia.")
            local.DiasOfflineConsumidos += 1
        Else
            Dim horasTranscurridas As Double = (ahora - local.UltimaFechaRegistrada).TotalHours

            If horasTranscurridas >= 20 Then
                local.DiasOfflineConsumidos += 1
                _logger.Info("Día offline consumido. Total: {0}", local.DiasOfflineConsumidos)
            End If
        End If

        ' Actualizar última fecha registrada solo si avanzó
        If ahora > local.UltimaFechaRegistrada Then
            local.UltimaFechaRegistrada = ahora
        End If

        ' Guardar estado actualizado
        _repoLocal.Guardar(local)

        ' Calcular días restantes basado en contador
        Dim diasRestantes As Integer = DIAS_GRACIA_MAXIMO - local.DiasOfflineConsumidos

        If diasRestantes <= 0 Then
            Return ResultadoGraciaOffline.Agotada()
        End If

        Return ResultadoGraciaOffline.EnGracia(diasRestantes)
    End Function

    ' ─── Detectar si la fecha fue manipulada ─────────────────────────────────
    Private Function DetectarManipulacion(local As LicenciaLocal,
                                          ahora As DateTime) As Boolean
        ' Fecha actual ANTERIOR a la última registrada
        ' el usuario retrocedió el reloj
        If ahora < local.UltimaFechaRegistrada Then
            Dim horasRetroceso As Double =
                (local.UltimaFechaRegistrada - ahora).TotalHours
            _logger.Warn("Fecha retrocedida {0:F1} horas detectada.",
                horasRetroceso)
            Return True
        End If

        ' Fecha avanzó más de 48 horas de golpe
        ' posible manipulación hacia adelante
        Dim horasAvance As Double =
            (ahora - local.UltimaFechaRegistrada).TotalHours

        If horasAvance > 48 Then
            _logger.Warn("Salto de fecha de {0:F1} horas detectado.",
                horasAvance)
            Dim diasSaltados As Integer = CInt(Math.Floor(horasAvance / 24))
            local.DiasOfflineConsumidos += diasSaltados
            Return False ' Ya penalizamos con los días saltados
        End If

        Return False
    End Function

    ' ─── Registrar verificación exitosa online ────────────────────────────────
    Public Sub RegistrarVerificacionExitosa(local As LicenciaLocal,
                                            ahora As DateTime)
        local.DiasOfflineConsumidos = 0
        local.UltimaFechaRegistrada = ahora
        local.UltimaVerificacion = ahora
        _repoLocal.Guardar(local)
    End Sub

End Class