Imports System.Drawing
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Capa_Entidad
Imports Capa_Negocio
Imports Capa_Operacion
Imports NLog

Public Class ConfiguraConexionInicial

    Private ReadOnly _logger As Logger = LogManager.GetCurrentClassLogger()
    Private ReadOnly _configServicio As ConfiguracionServicio
    Private ReadOnly _modoConfiguracion As Boolean
    Public Property ConfiguracionGuardada As Boolean = False

    ' ─── Constructor por defecto — primera vez ────────────────────────────────
    Public Sub New()
        Me.New(False)
    End Sub

    ' ─── Constructor con modo ─────────────────────────────────────────────────
    Public Sub New(modoConfiguracion As Boolean)
        InitializeComponent()
        _modoConfiguracion = modoConfiguracion
        _configServicio = ServiceLocator.Obtener(Of ConfiguracionServicio)()
    End Sub

    ' ─── Carga inicial ────────────────────────────────────────────────────────
    Private Async Sub ConfiguraConexionInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _modoConfiguracion Then
            Me.Text = "Configuración — Base de datos"
            btnCancelar.Text = "Cancelar"
        Else
            Me.Text = "Configuración inicial — Base de datos"
            btnCancelar.Text = "Cancelar"
        End If

        Dim config As ConfiguracionApp = _configServicio.Leer()
        CargarEnFormulario(If(config, ConfiguracionApp.PorDefecto()))
        ActualizarVisibilidadIp()

        ' Solo buscar servidor si no hay config previa o sin IP asignada
        If config Is Nothing OrElse String.IsNullOrEmpty(config.IpServidor) Then
            Await BuscarServidorEnRedAsync()
        End If
    End Sub

    ' ─── Buscar servidor en red ───────────────────────────────────────────────
    Private Async Function BuscarServidorEnRedAsync() As Task
        Try
            MostrarInfo("🔍 Buscando servidor en la red...")
            SetBotonesHabilitados(False)

            Dim discoveryServicio As New NetworkDiscoveryServicio()
            Dim resultado As ResultadoDiscovery = Await discoveryServicio.BuscarServidorAsync().ConfigureAwait(False)

            Invoke(Sub()
                       SetBotonesHabilitados(True)

                       If resultado.Encontrado Then
                           ' Verificar si el servidor encontrado es este mismo equipo
                           Dim ipLocal As String = NetworkDiscoveryServicio.ObtenerIpLocal()
                           Dim esMismoEquipo As Boolean = resultado.IpServidor = ipLocal

                           If esMismoEquipo Then
                               rbServidor.Checked = True
                               MostrarInfo("✔ Este equipo ya está configurado como servidor.")
                               Return
                           End If

                           ' Servidor encontrado en otro equipo — sugerir estación
                           Dim respuesta As DialogResult = MessageBox.Show(
                               String.Format(
                                   "✔ Se encontró un servidor en la red.{0}{0}" &
                                   "IP del servidor: {1}{0}{0}" &
                                   "¿Desea configurar este equipo como estación?",
                                   Environment.NewLine, resultado.IpServidor),
                               "Servidor encontrado",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1)

                           If respuesta = DialogResult.Yes Then
                               RbEstacion.Checked = True
                               txtIpServidor.Text = resultado.IpServidor
                               ActualizarVisibilidadIp()
                               MostrarExito(String.Format(
                                   "✔ Servidor detectado: {0}",
                                   resultado.IpServidor))
                           Else
                               LimpiarMensaje()
                           End If
                       Else
                           MostrarInfo(
                               "ℹ No se encontró servidor en la red." &
                               Environment.NewLine &
                               "Configure este equipo como servidor.")
                           rbServidor.Checked = True
                       End If
                   End Sub)

        Catch ex As Exception
            _logger.Warn(ex, "Error en búsqueda de servidor.")
            Invoke(Sub()
                       SetBotonesHabilitados(True)
                       LimpiarMensaje()
                   End Sub)
        End Try
    End Function

    ' ─── Habilitar/deshabilitar botones ──────────────────────────────────────
    Private Sub SetBotonesHabilitados(habilitados As Boolean)
        btnGuardar.Enabled = habilitados
        btnProbar.Enabled = habilitados
        btnCancelar.Enabled = habilitados
        rbServidor.Enabled = habilitados
        RbEstacion.Enabled = habilitados
    End Sub

    ' ─── Radio buttons ────────────────────────────────────────────────────────
    Private Sub rbServidor_CheckedChanged(
        sender As Object, e As EventArgs) _
        Handles rbServidor.CheckedChanged, rbServidor.Click
        ActualizarVisibilidadIp()
    End Sub

    Private Sub rbEstacion_CheckedChanged(sender As Object, e As EventArgs) Handles RbEstacion.CheckedChanged, RbEstacion.Click
        ActualizarVisibilidadIp()
    End Sub

    Private Sub ActualizarVisibilidadIp()
        Dim esEstacion As Boolean = RbEstacion.Checked
        txtIpServidor.Visible = esEstacion
        txtIpServidor.Enabled = esEstacion
        If Not esEstacion Then
            txtIpServidor.Text = String.Empty
        End If
    End Sub

    ' ─── Probar conexión ──────────────────────────────────────────────────────
    Private Async Sub btnProbar_Click(sender As Object, e As EventArgs) Handles btnProbar.Click

        If Not ValidarCampos() Then Return

        SetCargando(True)
        MostrarInfo("Probando conexión...")

        Dim config As ConfiguracionApp = ObtenerDesdeFormulario()

        Try
            Dim conectado As Boolean = Await Task.Run(Function() _configServicio.ProbarConexion(config)).ConfigureAwait(False)

            Invoke(Sub()
                       SetCargando(False)
                       If conectado Then
                           MostrarExito("✔ Conexión exitosa.")
                       Else
                           MostrarError("✖ No se pudo conectar. Verifique los datos.")
                       End If
                   End Sub)

        Catch ex As Exception
            _logger.Error(ex, "Error al probar conexión.")
            Invoke(Sub()
                       SetCargando(False)
                       MostrarError("✖ Error al probar la conexión.")
                   End Sub)
        End Try
    End Sub

    ' ─── Guardar configuración ────────────────────────────────────────────────
    Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Not ValidarCampos() Then Return

        SetCargando(True)
        Dim config As ConfiguracionApp = ObtenerDesdeFormulario()

        Try
            ' ════════════════════════════════════════════════════════
            '  MODO ESTACIÓN
            ' ════════════════════════════════════════════════════════
            If config.Estacion Then

                ' 1. Verificar acceso a carpeta compartida del servidor
                MostrarInfo("Verificando acceso al servidor...")

                Dim accesoRed As Boolean = Await Task.Run(Function() _configServicio.ProbarAccesoRed(config.IpServidor)).ConfigureAwait(False)

                If Not accesoRed Then
                    Invoke(Sub()
                               SetCargando(False)
                               MostrarError(String.Format(
                                   "✖ No se puede acceder a \\{0}\Algodon ANH\{1}{1}" &
                                   "Verifique:{1}" &
                                   "  • Que el servidor esté encendido{1}" &
                                   "  • Que la carpeta esté compartida{1}" &
                                   "  • Que la IP sea correcta{1}" &
                                   "  • Que el servidor tenga lic.dat y server.id",
                                   config.IpServidor, Environment.NewLine))
                           End Sub)
                    Return
                End If

                ' 2. Verificar conexión a base de datos
                Invoke(Sub() MostrarInfo(
                    "Probando conexión a base de datos..."))

                Dim conectadoBD As Boolean = Await Task.Run(Function() _configServicio.ProbarConexion(config)).ConfigureAwait(False)

                If Not conectadoBD Then
                    Invoke(Sub()
                               SetCargando(False)
                               MostrarError(
                                   "✖ No se pudo conectar a la base de datos." &
                                   Environment.NewLine &
                                   "Verifique los parámetros de conexión.")
                           End Sub)
                    Return
                End If

                ' 3. Guardar config.json — sin instalar servicio
                Dim guardado As Boolean = Await Task.Run(Function() _configServicio.Guardar(config)).ConfigureAwait(False)

                Invoke(Sub()
                           SetCargando(False)
                           If guardado Then
                               ConfiguracionGuardada = True
                               MessageBox.Show(
                                   String.Format(
                                       "✔ Configuración de estación guardada.{0}{0}" &
                                       "Servidor: {1}{0}" &
                                       "Base de datos: {2}",
                                       Environment.NewLine,
                                       config.IpServidor,
                                       config.BaseDeDatos),
                                   "Configuración exitosa",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information)
                               Me.DialogResult = DialogResult.OK
                               Me.Close()
                           Else
                               MostrarError("✖ Error al guardar la configuración.")
                           End If
                       End Sub)

                ' ════════════════════════════════════════════════════════
                '  MODO SERVIDOR
                ' ════════════════════════════════════════════════════════
            Else
                ' 1. Buscar otros servidores en la red
                MostrarInfo("Buscando otros servidores en la red...")

                Dim discoveryServicio As New NetworkDiscoveryServicio()
                Dim otro As ResultadoDiscovery = Await discoveryServicio.BuscarServidorAsync().ConfigureAwait(False)

                ' Solo advertir si el servidor encontrado es un equipo DIFERENTE
                Dim ipLocalActual As String = NetworkDiscoveryServicio.ObtenerIpLocal()
                Dim esOtroServidor As Boolean = otro.Encontrado AndAlso otro.IpServidor <> ipLocalActual

                If esOtroServidor Then
                    Dim continuarComoServidor As Boolean = False

                    Invoke(Sub()
                               Dim respuesta As DialogResult = MessageBox.Show(
                                   String.Format(
                                       "⚠ Ya existe un servidor activo en la red.{0}{0}" &
                                       "IP del servidor encontrado: {1}{0}{0}" &
                                       "Solo debe existir UN servidor por red.{0}" &
                                       "¿Desea configurar este equipo como estación{0}" &
                                       "apuntando a ese servidor?",
                                       Environment.NewLine, otro.IpServidor),
                                   "Servidor ya existe",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning,
                                   MessageBoxDefaultButton.Button1)

                               If respuesta = DialogResult.Yes Then
                                   RbEstacion.Checked = True
                                   txtIpServidor.Text = otro.IpServidor
                                   ActualizarVisibilidadIp()
                                   SetCargando(False)
                                   MostrarInfo(String.Format(
                                       "✔ Configurado como estación del servidor {0}.{1}" &
                                       "Complete los datos de BD y presione Guardar.",
                                       otro.IpServidor, Environment.NewLine))
                               Else
                                   continuarComoServidor = True
                               End If
                           End Sub)

                    If Not continuarComoServidor Then Return
                End If

                ' 2. Probar conexión a base de datos
                Invoke(Sub() MostrarInfo("Probando conexión a base de datos..."))

                Dim conectado As Boolean = Await Task.Run(Function() _configServicio.ProbarConexion(config)).ConfigureAwait(False)

                If Not conectado Then
                    Invoke(Sub()
                               SetCargando(False)
                               MostrarError(
                                   "✖ No se pudo conectar con los datos ingresados." &
                                   Environment.NewLine &
                                   "Verifique los parámetros antes de guardar.")
                           End Sub)
                    Return
                End If

                ' 3. Guardar config.json
                Invoke(Sub() MostrarInfo("Guardando configuración..."))

                Dim guardadoSrv As Boolean = Await Task.Run(Function() _configServicio.Guardar(config)).ConfigureAwait(False)

                If Not guardadoSrv Then
                    Invoke(Sub()
                               SetCargando(False)
                               MostrarError("✖ Error al guardar la configuración.")
                           End Sub)
                    Return
                End If

                ' 4. Mostrar resultado final — sin servicio Windows
                Invoke(Sub()
                           SetCargando(False)
                           ConfiguracionGuardada = True
                           MessageBox.Show(
                               "✔ Configuración guardada correctamente." &
                               Environment.NewLine & Environment.NewLine &
                               "El sistema está listo para usarse.",
                               "Configuración exitosa",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information)
                           Me.DialogResult = DialogResult.OK
                           Me.Close()
                       End Sub)
            End If

        Catch ex As Exception
            _logger.Error(ex, "Error al guardar configuración.")
            Invoke(Sub()
                       SetCargando(False)
                       MostrarError("✖ Error inesperado al guardar.")
                   End Sub)
        End Try
    End Sub

    ' ─── Cancelar ─────────────────────────────────────────────────────────────
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        If _modoConfiguracion Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
            Return
        End If

        Dim respuesta As DialogResult = MessageBox.Show(
            "¿Está seguro que desea cancelar?" &
            Environment.NewLine & "El sistema se cerrará.",
            "Cancelar configuración",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2)

        If respuesta = DialogResult.Yes Then
            ConfiguracionGuardada = False
            Me.DialogResult = DialogResult.Cancel
            Application.Exit()
        End If
    End Sub

    ' ─── Cargar datos en el formulario ────────────────────────────────────────
    Private Sub CargarEnFormulario(config As ConfiguracionApp)
        cbInstancia.Text = If(config.InstanciaBDD, String.Empty)
        tbbddperfiles.Text = If(config.BaseDeDatosPerfiles, String.Empty)
        txtBaseDatos.Text = If(config.BaseDeDatos, String.Empty)
        txtUsuario.Text = If(config.UsuarioBDD, String.Empty)
        txtPassword.Text = If(config.PasswordBDD, String.Empty)
        txtIpServidor.Text = If(config.IpServidor, String.Empty)
        rbServidor.Checked = config.Servidor
        RbEstacion.Checked = config.Estacion
    End Sub

    ' ─── Obtener datos del formulario ─────────────────────────────────────────
    Private Function ObtenerDesdeFormulario() As ConfiguracionApp
        Return New ConfiguracionApp With {
            .InstanciaBDD = cbInstancia.Text.Trim(),
            .BaseDeDatosPerfiles = tbbddperfiles.Text.Trim(),
            .BaseDeDatos = txtBaseDatos.Text.Trim(),
            .UsuarioBDD = txtUsuario.Text.Trim(),
            .PasswordBDD = txtPassword.Text,
            .Servidor = rbServidor.Checked,
            .Estacion = RbEstacion.Checked,
            .IpServidor = If(RbEstacion.Checked,
                               txtIpServidor.Text.Trim(),
                               String.Empty)
        }
    End Function

    ' ─── Validaciones ─────────────────────────────────────────────────────────
    Private Function ValidarCampos() As Boolean
        LimpiarMensaje()

        If String.IsNullOrWhiteSpace(cbInstancia.Text) Then
            MostrarError("Ingrese la instancia del servidor SQL.")
            cbInstancia.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtBaseDatos.Text) Then
            MostrarError("Ingrese el nombre de la base de datos.")
            txtBaseDatos.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtUsuario.Text) Then
            MostrarError("Ingrese el usuario de la base de datos.")
            txtUsuario.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MostrarError("Ingrese la contraseña de la base de datos.")
            txtPassword.Focus()
            Return False
        End If

        If RbEstacion.Checked AndAlso
           String.IsNullOrWhiteSpace(txtIpServidor.Text) Then
            MostrarError("Ingrese la IP del servidor.")
            txtIpServidor.Focus()
            Return False
        End If

        Return True
    End Function

    ' ─── Helpers UI ───────────────────────────────────────────────────────────
    Private Sub SetCargando(cargando As Boolean)
        If InvokeRequired Then
            Invoke(Sub() SetCargando(cargando))
            Return
        End If
        btnGuardar.Enabled = Not cargando
        btnProbar.Enabled = Not cargando
        btnCancelar.Enabled = Not cargando
        pbProgreso.Visible = cargando
        Cursor = If(cargando, Cursors.WaitCursor, Cursors.Default)
    End Sub

    Private Sub MostrarError(msg As String)
        If InvokeRequired Then
            Invoke(Sub() MostrarError(msg))
            Return
        End If
        lblMensaje.ForeColor = Color.Red
        lblMensaje.Text = msg
    End Sub

    Private Sub MostrarExito(msg As String)
        If InvokeRequired Then
            Invoke(Sub() MostrarExito(msg))
            Return
        End If
        lblMensaje.ForeColor = Color.Green
        lblMensaje.Text = msg
    End Sub

    Private Sub MostrarInfo(msg As String)
        If InvokeRequired Then
            Invoke(Sub() MostrarInfo(msg))
            Return
        End If
        lblMensaje.ForeColor = Color.DodgerBlue
        lblMensaje.Text = msg
    End Sub

    Private Sub LimpiarMensaje()
        lblMensaje.Text = String.Empty
    End Sub

End Class