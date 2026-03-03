' Capa_Presentacion/Program.vb
Imports System.Windows.Forms
Imports Capa_Entidad
Imports Capa_Negocio
Imports Capa_Operacion
Module Program
    Private _discoveryService As NetworkDiscoveryServicio
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        ServiceLocator.Configurar()

        If Not VerificarConfiguracion() Then Return
        If Not VerificarLicencia() Then Return
        IniciarDiscoveryServidor()
        AddHandler Application.ApplicationExit, Sub(s, e)
                                                    If _discoveryService IsNot Nothing Then
                                                        _discoveryService.Detener()
                                                        _discoveryService.Dispose()
                                                    End If
                                                End Sub
        Application.Run(New Acceso())
    End Sub

    ' ─── Verificar configuración ──────────────────────────────────────────
    Private Function VerificarConfiguracion() As Boolean
        Dim srv = ServiceLocator.Obtener(Of ConfiguracionServicio)()

        If srv.ExisteConfiguracion() Then Return True

        Dim resp = MessageBox.Show(
            "El sistema aún no está configurado." &
            Environment.NewLine & Environment.NewLine &
            "¿Desea configurarlo ahora?",
            "Configuración inicial",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1)

        If resp = DialogResult.No Then
            MessageBox.Show("El sistema se cerrará.", "Cerrando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Using frm = New ConfiguraConexionInicial()
            If frm.ShowDialog() = DialogResult.OK AndAlso
                   frm.ConfiguracionGuardada Then
                Return True
            End If
        End Using

        MessageBox.Show("La configuración no fue completada." & Environment.NewLine & "El sistema se cerrará.", "Sin configuración", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return False
    End Function
    Private Sub IniciarDiscoveryServidor()
        Try
            Dim configServicio As ConfiguracionServicio = ServiceLocator.Obtener(Of ConfiguracionServicio)()

            Dim config As ConfiguracionApp = configServicio.Leer()

            ' Solo iniciar en modo servidor
            If config Is Nothing OrElse config.Estacion Then Return

            _discoveryService = New NetworkDiscoveryServicio()
            _discoveryService.IniciarServidor()

        Catch ex As Exception
            ' No crítico — el sistema funciona sin discovery
            System.Diagnostics.Debug.WriteLine(
            "Discovery no disponible: " & ex.Message)
        End Try
    End Sub
    ' ─── Verificar licencia ───────────────────────────────────────────────
    Private Function VerificarLicencia() As Boolean
        Dim srv = ServiceLocator.Obtener(Of ConfiguracionServicio)
        Dim config As ConfiguracionApp = srv.Leer()

        If config IsNot Nothing AndAlso config.Estacion Then
            Return VerificarLicenciaEstacion(config)
        End If

        Return VerificarLicenciaServidor()
    End Function

    ' ─── Licencia ESTACIÓN ────────────────────────────────────────────────
    Private Function VerificarLicenciaEstacion(config As ConfiguracionApp) As Boolean

        Dim rutaRed As String = config.ObtenerRutaLicenciaRed()

        If Not IO.File.Exists(rutaRed) Then
            MessageBox.Show(
                    String.Format(
                        "No se encontró el archivo de licencia en:{0}{1}{0}{0}" &
                        "Verifique:{0}" &
                        "  • Que el servidor esté encendido{0}" &
                        "  • Que la carpeta esté compartida{0}" &
                        "  • Que el servidor tenga la licencia activada{0}" &
                        "  • Que la red no este teniendo problemas.",
                        Environment.NewLine, rutaRed),
                    "Licencia no encontrada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Dim licServicio = ServiceLocator.Obtener(Of LicenciaServicio)()
        Dim licser = licServicio.obtenerlicencialocal(rutaRed)
        Dim licencia As LicenciaInfo = licServicio.VerificarLicenciaAsync(String.Empty).GetAwaiter().GetResult()
        Return EvaluarResultadoLicencia(licencia)
    End Function

    ' ─── Licencia SERVIDOR ────────────────────────────────────────────────
    Private Function VerificarLicenciaServidor() As Boolean
        Dim licServicio = ServiceLocator.Obtener(Of LicenciaServicio)()
        Dim licenciaServicio = ServiceLocator.Obtener(Of LicenciaServicio)()
        Dim serial As String = Nothing

        If licServicio.ExisteArchivoLicencia() Then
            serial = licServicio.ObtenerSerialDesdeArchivo()
        End If

        If String.IsNullOrEmpty(serial) Then
            Dim resp = MessageBox.Show(
                "El sistema aún no está activado." &
                Environment.NewLine & Environment.NewLine &
                "¿Desea activarlo ahora?",
                "Sistema no activado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1)

            If resp = DialogResult.No Then
                MessageBox.Show("El sistema se cerrará.", "Cerrando",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            Using frm = New RegistroLicencia()
                If frm.ShowDialog() = DialogResult.OK AndAlso
                   frm.LicenciaValida Then
                    Return True
                End If
            End Using

            MessageBox.Show(
                "La licencia no fue activada." &
                Environment.NewLine & "El sistema se cerrará.",
                "Sin licencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Dim licloc As LicenciaLocal = licenciaServicio.obtenerlicencialocal()
        Dim licencia As LicenciaInfo = licServicio.VerificarLicenciaAsync(serial, licloc.NombreCliente, licloc.EmailCliente, licloc.Cantidad, licloc.IdPeriodo, licloc.FechaVencimiento, licloc.NombreContacto, licloc.TelefonoContacto).GetAwaiter().GetResult()
        Return EvaluarResultadoLicencia(licencia)
    End Function

    ' ─── Evaluar resultado ────────────────────────────────────────────────
    Private Function EvaluarResultadoLicencia(licencia As LicenciaInfo) As Boolean

        Select Case licencia.Estatus
            Case EstatusSerial.Activo
                Return True

            Case EstatusSerial.Vencido
                If licencia.EnPeriodoGracia Then
                    MessageBox.Show(
                        String.Format(
                            "⚠ Licencia en período de gracia.{0}{0}{1}",
                            Environment.NewLine, licencia.Mensaje),
                        "Aviso de licencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return True
                End If
                MessageBox.Show(
                    "✖ La licencia ha vencido." &
                    Environment.NewLine &
                    "Contacte al administrador.",
                    "Licencia vencida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False

            Case EstatusSerial.Inhabilitado
                MessageBox.Show(
                    String.Format(
                        "✖ La licencia está inhabilitada.{0}{0}{1}",
                        Environment.NewLine, licencia.Mensaje),
                    "Licencia inhabilitada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False

            Case Else
                MessageBox.Show(
                    String.Format(
                        "✖ No se pudo verificar la licencia.{0}{0}{1}",
                        Environment.NewLine, licencia.Mensaje),
                    "Error de licencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
        End Select
    End Function

End Module