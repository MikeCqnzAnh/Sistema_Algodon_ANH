' Capa_Presentacion/Formularios/RegistroLicencia.vb
Imports System.Drawing
Imports System.ServiceModel.Activation.Configuration
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Capa_Entidad
Imports Capa_Negocio
Imports Capa_Operacion
Imports NLog

Public Class RegistroLicencia

    Private ReadOnly _logger As Logger =
        LogManager.GetCurrentClassLogger()
    Private ReadOnly _licenciaServicio As LicenciaServicio
    Private ReadOnly _configServicio As ConfiguracionServicio
    Private ReadOnly _modoConsulta As Boolean
    Private _esEstacion As Boolean = False
    Private _licenciaActual As LicenciaInfo

    Public Property LicenciaValida As Boolean = False

    ' ─── Constructores ────────────────────────────────────────────────────────
    Public Sub New()
        Me.New(False)
    End Sub

    Public Sub New(modoConsulta As Boolean)
        InitializeComponent()
        _modoConsulta = modoConsulta
        _licenciaServicio = ServiceLocator.Obtener(Of LicenciaServicio)()
        _configServicio = ServiceLocator.Obtener(Of ConfiguracionServicio)()
    End Sub

    ' ─── Carga inicial ────────────────────────────────────────────────────────
    Private Async Sub RegistroLicencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPeriodos()
        ' Detectar modo desde config.json
        Dim config As ConfiguracionApp = _configServicio.Leer()
        _esEstacion = config IsNot Nothing AndAlso config.Estacion

        ConfigurarSegunModo(config)

        If _esEstacion Then
            ' MODO ESTACIÓN — verificar directamente sin pedir serial
            Await VerificarEstacionAsync(config)
        Else
            Dim licloc As LicenciaLocal = _licenciaServicio.obtenerlicencialocal()

            ' MODO SERVIDOR — cargar serial guardado si existe
            Dim serialGuardado As String = _licenciaServicio.ObtenerSerialDesdeArchivo()

            If Not String.IsNullOrEmpty(serialGuardado) Then
                tbemail.Text = licloc.EmailCliente
                tbnombre.Text = licloc.NombreCliente
                nucantidad.Value = licloc.Cantidad
                AsignarPeriodo(licloc.IdPeriodo)
                dtfechavencimiento.Value = licloc.FechaVencimiento
                tbnombrecontacto.Text = licloc.NombreContacto
                tbtelefono.Text = licloc.TelefonoContacto
                tblicencia.Text = serialGuardado
                tblicencia.ReadOnly = True
                Await VerificarLicenciaAsync(serialGuardado, tbnombre.Text, tbemail.Text, nucantidad.Value, cbperiodo.SelectedValue, dtfechavencimiento.Value, tbnombrecontacto.Text, tbtelefono.Text)
            Else
                ' Primera vez — permitir ingresar serial
                tblicencia.ReadOnly = False
                tblicencia.Focus()
            End If
        End If
    End Sub
    Private Sub CargarPeriodos()
        cbperiodo.Items.Clear()
        cbperiodo.DisplayMember = "Texto"
        cbperiodo.ValueMember = "Id"

        cbperiodo.Items.Add(New PeriodoItem(0, "Días de Prueba"))
        cbperiodo.Items.Add(New PeriodoItem(1, "Mes"))
        cbperiodo.Items.Add(New PeriodoItem(2, "Año"))

        cbperiodo.SelectedIndex = 0
    End Sub
    Private Sub AsignarPeriodo(idPeriodo As Integer)
        ' ✅ No limpiar — solo buscar y seleccionar
        For i As Integer = 0 To cbperiodo.Items.Count - 1
            Dim item As PeriodoItem =
            DirectCast(cbperiodo.Items(i), PeriodoItem)
            If item.Id = idPeriodo Then
                cbperiodo.SelectedIndex = i
                Return
            End If
        Next
        cbperiodo.SelectedIndex = 0
    End Sub
    ' ─── Configurar controles según modo ─────────────────────────────────────
    Private Sub ConfigurarSegunModo(config As ConfiguracionApp)
        If _esEstacion Then
            ' ── MODO ESTACIÓN ─────────────────────────────────────────────────
            Me.Text = If(_modoConsulta, "Información de Licencia — Estación", "Verificación de Licencia — Estación")

            ' Ocultar campos de ingreso de serial
            tblicencia.Visible = False
            label3.Visible = False
            btpegar.Visible = False
            btlimpiar.Visible = False
            btactivar.Visible = False

            ' Mostrar modo conexión en label4
            label4.AutoSize = True
            label4.ForeColor = Color.DodgerBlue
            label4.Text = String.Format("Estación — Servidor: {0}", If(config IsNot Nothing, config.IpServidor, "No configurado"))

            btcancelar.Text = If(_modoConsulta, "Cerrar", "Cancelar")

        Else
            ' ── MODO SERVIDOR ─────────────────────────────────────────────────
            Me.Text = If(_modoConsulta, "Información de Licencia", "Activación de Licencia")

            tblicencia.ReadOnly = False
            tblicencia.Visible = True
            label3.Visible = True
            btpegar.Visible = True
            btlimpiar.Visible = True
            btactivar.Visible = True

            label4.AutoSize = True
            label4.ForeColor = Color.Gray
            label4.Text = "Servidor"

            btactivar.Text = If(_modoConsulta, "Verificar licencia", "Activar")
            btcancelar.Text = If(_modoConsulta, "Cerrar", "Cancelar")

            ' Deshabilitar campos de info hasta verificar
            LimpiarInfoLicencia()
        End If
    End Sub

    ' ─── Verificación ESTACIÓN ────────────────────────────────────────────────
    Private Async Function VerificarEstacionAsync(
        config As ConfiguracionApp) As Task

        SetCargando(True)
        MostrarInfo("Verificando licencia desde el servidor...")

        Try
            _licenciaActual = Await _licenciaServicio _
                .VerificarLicenciaAsync(String.Empty) _
                .ConfigureAwait(False)

            Invoke(Sub()
                       SetCargando(False)
                       ProcesarResultadoEstacion(_licenciaActual, config)
                   End Sub)

        Catch ex As Exception
            _logger.Error(ex, "Error al verificar licencia de estación.")
            Invoke(Sub()
                       SetCargando(False)
                       MostrarError(
                           "Error al verificar licencia desde el servidor." &
                           Environment.NewLine &
                           "Verifique la conexión de red.")
                   End Sub)
        End Try
    End Function

    ' ─── Procesar resultado ESTACIÓN ─────────────────────────────────────────
    Private Sub ProcesarResultadoEstacion(licencia As LicenciaInfo, config As ConfiguracionApp)
        MostrarInfoLicencia(licencia)

        Select Case licencia.Estatus
            Case EstatusSerial.Activo
                MostrarExito(String.Format(
                    "Licencia activa en servidor {0}.",
                    If(config IsNot Nothing, config.IpServidor, "")))
                LicenciaValida = True

                ' Si no es consulta cerrar automáticamente tras 2 segundos
                If Not _modoConsulta Then
                    Dim tmr As New Timer()
                    tmr.Interval = 2000
                    AddHandler tmr.Tick, Sub(s, ev)
                                             tmr.Stop()
                                             Me.DialogResult = DialogResult.OK
                                             Me.Close()
                                         End Sub
                    tmr.Start()
                End If

            Case EstatusSerial.Vencido
                MostrarAdvertencia(String.Format(
                    "Licencia en período de gracia.{0}{1}",
                    Environment.NewLine, licencia.Mensaje))
                LicenciaValida = True

            Case EstatusSerial.Inhabilitado
                MostrarError(String.Format(
                    "{0}{1}Contacte al administrador del servidor.",
                    licencia.Mensaje, Environment.NewLine))
                LicenciaValida = False

            Case Else
                MostrarError("Estado de licencia desconocido.")
        End Select
    End Sub

    ' ─── Botón Activar ────────────────────────────────────────────────────────
    Private Async Sub btactivar_Click(sender As Object, e As EventArgs) Handles btactivar.Click

        ' ✅ Leer TODOS los valores de controles UI AQUÍ
        ' antes de cualquier Await — todavía estamos en el hilo UI
        Dim serial As String = tblicencia.Text.Trim().ToUpper()
        Dim nombreCliente As String = tbnombre.Text.Trim()
        Dim emailCliente As String = tbemail.Text.Trim()
        Dim nombreContacto As String = tbnombrecontacto.Text.Trim()
        Dim telefonoContacto As String = tbtelefono.Text.Trim()
        Dim cantidad As Integer = CInt(nucantidad.Value)
        Dim fechavencimiento As DateTime? = DateTime.Now

        ' ✅ SelectedValue puede ser Nothing si no hay selección
        Dim idPeriodo As Integer = 0
        If cbperiodo.SelectedItem IsNot Nothing Then
            idPeriodo = DirectCast(cbperiodo.SelectedItem, PeriodoItem).Id
        End If

        ' ── Validaciones (hilo UI) ────────────────────────────────────────────
        If String.IsNullOrWhiteSpace(serial.Replace("-", "").Trim()) Then
            MostrarError("Ingrese el serial de licencia.")
            tblicencia.Focus()
            Return
        End If

        If Not ValidarFormatoSerial(serial) Then
            MostrarError(
            "Formato de serial inválido." &
            Environment.NewLine &
            "Debe ser XXXX-XXXX-XXXX-XXXX.")
            Return
        End If

        SetCargando(True)
        MostrarInfo("Verificando conexión con el servidor...")

        Try
            ' ── A partir de aquí pueden existir Awaits con ConfigureAwait(False)
            ' ── ya NO accedemos a ningún control UI directamente
            Dim hayConexion As Boolean = Await _licenciaServicio.HayConexionConServidorAsync().ConfigureAwait(False)

            If Not hayConexion Then
                Invoke(Sub()
                           SetCargando(False)
                           MostrarError(
                    "Sin conexión con el servidor de licencias." &
                    Environment.NewLine & Environment.NewLine &
                    "Para activar por primera vez" &
                    Environment.NewLine &
                    "se requiere conexión a internet.")
                       End Sub)
                Return
            End If

            Invoke(Sub() MostrarInfo("Conectado. Verificando licencia..."))

            ' ✅ Pasar variables locales — NO controles UI
            Await VerificarLicenciaAsync(
            serial,
            nombreCliente,
            emailCliente,
            cantidad,
            idPeriodo,
            fechavencimiento,
            nombreContacto,
            telefonoContacto)

        Catch ex As Exception
            _logger.Error(ex, "Error al verificar conexión.")
            Invoke(Sub()
                       SetCargando(False)
                       MostrarError("Error inesperado al verificar conexión.")
                   End Sub)
        Finally
            Invoke(Sub() SetCargando(False))
        End Try
    End Sub

    ' ─── Verificación SERVIDOR ────────────────────────────────────────────────
    Private Async Function VerificarLicenciaAsync(
    serial As String,
    Optional nombreCliente As String = "",
    Optional emailCliente As String = "",
    Optional cantidad As Integer = 0,
    Optional idperiodo As Integer = 0,
    Optional fechavencimiento As DateTime? = Nothing,
    Optional nombreContacto As String = "",
    Optional telefonoContacto As String = "") As Task

        Try
            _licenciaActual = Await _licenciaServicio _
            .VerificarLicenciaAsync(
                serial,
                nombreCliente,
                emailCliente,
                cantidad,
                idperiodo,
                fechavencimiento,
                nombreContacto,
                telefonoContacto) _
            .ConfigureAwait(False)

            Invoke(Sub() ProcesarResultadoServidor(serial, _licenciaActual))

        Catch ex As Exception
            _logger.Error(ex, "Error al verificar licencia.")
            Invoke(Sub()
                       MostrarError(
                "Error al conectar con el servidor de licencias." &
                Environment.NewLine &
                "Verifique su conexión a internet.")
                   End Sub)
        End Try
    End Function

    ' ─── Procesar resultado SERVIDOR ─────────────────────────────────────────
    Private Sub ProcesarResultadoServidor(serial As String, licencia As LicenciaInfo)
        Select Case licencia.Estatus
            Case EstatusSerial.Activo
                MostrarExito(String.Format("Licencia activada correctamente.{0}{1}", Environment.NewLine, licencia.Mensaje))
                MostrarInfoLicencia(licencia)
                LicenciaValida = True
                tblicencia.ReadOnly = True

                If Not _modoConsulta Then
                    Dim tmr As New Timer()
                    tmr.Interval = 2000
                    AddHandler tmr.Tick, Sub(s, ev)
                                             tmr.Stop()
                                             Me.DialogResult = DialogResult.OK
                                             Me.Close()
                                         End Sub
                    tmr.Start()
                End If

            Case EstatusSerial.Vencido
                MostrarAdvertencia(String.Format(
                    "Licencia en período de gracia.{0}{1}",
                    Environment.NewLine, licencia.Mensaje))
                MostrarInfoLicencia(licencia)
                LicenciaValida = True

            Case EstatusSerial.Inactivo
                MostrarAdvertencia(
                    "Licencia encontrada pero aún no activada." &
                    Environment.NewLine &
                    "Presione Activar para comenzar.")
                btactivar.Text = "Activar por primera vez"

            Case EstatusSerial.Inhabilitado
                MostrarError(String.Format(
                    "Licencia inhabilitada.{0}{1}",
                    Environment.NewLine, licencia.Mensaje))
                LicenciaValida = False

            Case Else
                MostrarError("Estado de licencia desconocido.")
        End Select
    End Sub

    ' ─── Mostrar info detallada de la licencia ────────────────────────────────
    Private Sub MostrarInfoLicencia(licencia As LicenciaInfo)
        ' ✅ Garantizar hilo UI
        If InvokeRequired Then
            Invoke(Sub() MostrarInfoLicencia(licencia))
            Return
        End If

        cbestatuslicencia.Enabled = False
        cbperiodo.Enabled = False
        nucantidad.Enabled = False
        dtfechavencimiento.Enabled = False

        ' ── Estatus ───────────────────────────────────────────────────────────
        cbestatuslicencia.Items.Clear()
        cbestatuslicencia.Items.Add(licencia.Estatus.ToString())
        cbestatuslicencia.SelectedIndex = 0

        Select Case licencia.Estatus
            Case EstatusSerial.Activo : cbestatuslicencia.ForeColor = Color.Green
            Case EstatusSerial.Vencido : cbestatuslicencia.ForeColor = Color.Orange
            Case EstatusSerial.Inhabilitado : cbestatuslicencia.ForeColor = Color.Red
            Case Else : cbestatuslicencia.ForeColor = Color.Gray
        End Select

        ' ✅ Asignar período — NO llamar CargarPeriodos() aquí
        AsignarPeriodo(MapearPeriodoAId(licencia.Periodo))

        ' ── Días restantes ────────────────────────────────────────────────────
        nucantidad.Value = If(
        licencia.DiasRestantes > 0 AndAlso
        licencia.DiasRestantes < 500,
        CDec(licencia.DiasRestantes), 0D)

        ' ── Fecha vencimiento ─────────────────────────────────────────────────
        If licencia.FechaVencimiento.HasValue Then
            dtfechavencimiento.Value =
            licencia.FechaVencimiento.Value.ToLocalTime()
        End If

        ' ── Datos del cliente ─────────────────────────────────────────────────
        If Not String.IsNullOrEmpty(licencia.NombreCliente) Then
            tbnombre.Text = licencia.NombreCliente
        End If

        If Not String.IsNullOrEmpty(licencia.EmailCliente) Then
            tbemail.Text = licencia.EmailCliente
        End If

        If Not String.IsNullOrEmpty(licencia.NombreContacto) Then
            tbnombrecontacto.Text = licencia.NombreContacto
        End If

        If Not String.IsNullOrEmpty(licencia.TelefonoContacto) Then
            tbtelefono.Text = licencia.TelefonoContacto
        End If
    End Sub
    ' ─── Mapear string periodo → idperiodo ───────────────────────────────────────
    Private Shared Function MapearPeriodoAId(periodo As String) As Integer
        If String.IsNullOrEmpty(periodo) Then Return 0
        Select Case periodo.ToLower().Trim()
            Case "prueba", "días de prueba", "dias de prueba" : Return 0
            Case "mensual", "mes" : Return 1
            Case "anual", "año", "ano" : Return 2
            Case Else : Return 0
        End Select
    End Function

    ' ─── Limpiar campos de info ───────────────────────────────────────────────
    Private Sub LimpiarInfoLicencia()
        cbestatuslicencia.Items.Clear()
        cbperiodo.SelectedIndex = -1
        nucantidad.Value = 0
        dtfechavencimiento.Value = DateTime.Now
        tbnombre.Text = String.Empty
        tbemail.Text = String.Empty
        tbnombrecontacto.Text = String.Empty
        tbtelefono.Text = String.Empty
    End Sub

    ' ─── Botón Pegar — pegar serial desde portapapeles ───────────────────────
    Private Async Sub btpegar_Click(sender As Object, e As EventArgs) Handles btpegar.Click

        Try
            ' ── Pegar desde portapapeles ──────────────────────────────────────
            Dim texto As String = Clipboard.GetText().Trim().ToUpper()

            If String.IsNullOrEmpty(texto) Then
                MostrarError("El portapapeles está vacío.")
                Return
            End If

            tblicencia.Text = texto
            MostrarInfo("Serial pegado. Consultando información...")

            ' ── Validar formato antes de consultar ───────────────────────────
            Dim serial As String = tblicencia.Text.Trim().ToUpper()

            If Not ValidarFormatoSerial(serial) Then
                MostrarAdvertencia("Serial pegado. Verifique el formato XXXX-XXXX-XXXX-XXXX.")
                Return
            End If

            ' ── Consultar al API sin activar ──────────────────────────────────
            SetCargando(True)

            Dim consulta As ConsultaLicenciaResult = Await _licenciaServicio.ConsultarSerialAsync(serial).ConfigureAwait(False)

            Invoke(Sub() CargarCamposDesdeConsulta(consulta))

        Catch ex As Exception
            _logger.Error(ex, "Error en btpegar_Click.")
            Invoke(Sub() MostrarError("Error al consultar el serial."))
        Finally
            Invoke(Sub() SetCargando(False))
        End Try
    End Sub
    ' ─── Cargar controles desde la consulta previa ───────────────────────────────
    Private Sub CargarCamposDesdeConsulta(consulta As ConsultaLicenciaResult)
        ' ✅ Garantizar ejecución en hilo UI
        If InvokeRequired Then
            Invoke(Sub() CargarCamposDesdeConsulta(consulta))
            Return
        End If

        If Not consulta.Encontrado Then
            MostrarError(String.Format(
            "Serial no encontrado: {0}", consulta.Mensaje))
            Return
        End If

        AsignarPeriodo(consulta.IdPeriodo)

        nucantidad.Value = If(
        consulta.Cantidad > 0 AndAlso consulta.Cantidad <= 500,
        CDec(consulta.Cantidad), 0D)

        If consulta.FechaVencimiento.HasValue Then
            dtfechavencimiento.Value =
            consulta.FechaVencimiento.Value.ToLocalTime()
        End If

        If Not String.IsNullOrEmpty(consulta.NombreCliente) Then
            tbnombre.Text = consulta.NombreCliente
        End If

        If Not String.IsNullOrEmpty(consulta.EmailCliente) Then
            tbemail.Text = consulta.EmailCliente
        End If

        If Not String.IsNullOrEmpty(consulta.NombreContacto) Then
            tbnombrecontacto.Text = consulta.NombreContacto
        End If

        If Not String.IsNullOrEmpty(consulta.TelefonoContacto) Then
            tbtelefono.Text = consulta.TelefonoContacto
        End If

        Select Case consulta.EstatusInt
            Case 0
                MostrarAdvertencia(String.Format(
                "Serial válido — Período: {0} ({1} días).{2}" &
                "Fecha estimada de vencimiento: {3}",
                consulta.Periodo,
                consulta.Cantidad,
                Environment.NewLine,
                If(consulta.FechaVencimiento.HasValue,
                   consulta.FechaVencimiento.Value _
                       .ToLocalTime().ToString("dd/MM/yyyy"),
                   "No calculada")))
            Case 1
                MostrarExito(String.Format(
                "Licencia activa — Vence: {0}",
                If(consulta.FechaVencimiento.HasValue,
                   consulta.FechaVencimiento.Value _
                       .ToLocalTime().ToString("dd/MM/yyyy"),
                   "Sin vencimiento")))
            Case 2
                MostrarAdvertencia("Licencia en período de gracia.")
            Case 3
                MostrarError("Serial inhabilitado. Contacte a soporte.")
        End Select
    End Sub

    ' ─── Botón Limpiar ────────────────────────────────────────────────────────
    Private Sub btlimpiar_Click(sender As Object, e As EventArgs) Handles btlimpiar.Click
        tblicencia.Text = String.Empty
        tblicencia.ReadOnly = False
        label4.Text = String.Empty
        LimpiarInfoLicencia()
        tblicencia.Focus()
    End Sub

    ' ─── Botón Cancelar ───────────────────────────────────────────────────────
    Private Sub btcancelar_Click(
        sender As Object, e As EventArgs) _
        Handles btcancelar.Click

        If _modoConsulta OrElse _esEstacion Then
            Me.Close()
            Return
        End If

        Dim resultado As DialogResult = MessageBox.Show(
            "¿Está seguro que desea cancelar?" &
            Environment.NewLine & "El sistema se cerrará.",
            "Cancelar activación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2)

        If resultado = DialogResult.Yes Then
            LicenciaValida = False
            Me.DialogResult = DialogResult.Cancel
            Application.Exit()
        End If
    End Sub

    ' ─── Validar formato XXXX-XXXX-XXXX-XXXX ─────────────────────────────────
    Private Shared Function ValidarFormatoSerial(serial As String) As Boolean
        If String.IsNullOrEmpty(serial) Then Return False
        Dim partes As String() = serial.Split("-"c)
        If partes.Length <> 4 Then Return False
        For Each parte As String In partes
            If parte.Length <> 4 Then Return False
        Next
        Return True
    End Function

    ' ─── Helpers UI ───────────────────────────────────────────────────────────
    Private Sub SetCargando(cargando As Boolean)
        If InvokeRequired Then
            Invoke(Sub() SetCargando(cargando))
            Return
        End If
        btactivar.Enabled = Not cargando
        btpegar.Enabled = Not cargando
        btlimpiar.Enabled = Not cargando
        Cursor = If(cargando, Cursors.WaitCursor, Cursors.Default)
        If cargando Then
            label4.ForeColor = Color.Gray
            label4.Text = "Verificando licencia..."
        End If
    End Sub

    Private Sub MostrarError(msg As String)
        If InvokeRequired Then
            Invoke(Sub() MostrarError(msg))
            Return
        End If
        label4.AutoSize = True
        label4.ForeColor = Color.Red
        label4.Text = msg
    End Sub

    Private Sub MostrarExito(msg As String)
        If InvokeRequired Then
            Invoke(Sub() MostrarExito(msg))
            Return
        End If
        label4.AutoSize = True
        label4.ForeColor = Color.Green
        label4.Text = msg
    End Sub

    Private Sub MostrarAdvertencia(msg As String)
        If InvokeRequired Then
            Invoke(Sub() MostrarAdvertencia(msg))
            Return
        End If
        label4.AutoSize = True
        label4.ForeColor = Color.Orange
        label4.Text = msg
    End Sub

    Private Sub MostrarInfo(msg As String)
        If InvokeRequired Then
            Invoke(Sub() MostrarInfo(msg))
            Return
        End If
        label4.AutoSize = True
        label4.ForeColor = Color.DodgerBlue
        label4.Text = msg
    End Sub

End Class