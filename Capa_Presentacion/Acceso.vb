Imports System.Configuration
Imports System.Deployment.Application
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Runtime.InteropServices
Imports Capa_Entidad
Imports Capa_Negocio
Imports Capa_Operacion
Imports Capa_Operacion.Configuracion
Imports Microsoft.SqlServer
Public Class Acceso
    Private parametros As Parametros
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\cnn\"
    Dim archivo As String = "cnn.ini"
    Private _ckrecuerda, _servidor, _estacion As Boolean
    Private _nombre, _usuario, _passuser, usuariodb, passworddb, instanciabdd, basededatos As String
    Private Sub Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        parametros = Parametros.Cargar()
        compruebaconexioninicial()
        TbUsuario.Text = parametros.Usuario

        If TbUsuario.Text = "" Then
            TbUsuario.Select()
        Else
            TbClave.Select()
        End If
        If parametros.CkRecuerda = True Then
            CkRecordarPassword.Checked = parametros.CkRecuerda
            TbClave.Text = parametros.Password
        End If
        llenaCombos()
        CbBaseDeDatos.SelectedValue = parametros.ultimabdd
        Versionapp()
    End Sub
#Region "Drag Form - Arrastrar/ mover Formulario"

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
    Private Sub compruebaConexionServidor()
        Dim IpServer As String = String.Empty
        Dim UsuarioDB As String = String.Empty
        Dim PasswordDB As String = String.Empty
        Dim Instancia As String = String.Empty
        Dim DataBase As String
        Dim DataBasePerfiles As String
        Dim ccnppl As String
        Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\cnn\"
        Dim archivo As String = "cnn.ini"
        Dim archivo2 As String = "cnnPerfiles.ini"
        Dim leer As New StreamReader(Ruta & archivo)

        Try
            While leer.Peek <> -1
                Dim linea As String = leer.ReadLine()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                Dim ArregloCadena() As String = Split(linea, ",")
                IpServer = ArregloCadena(0)
                Instancia = ArregloCadena(1)
                UsuarioDB = ArregloCadena(2)
                PasswordDB = ArregloCadena(3)
            End While

            leer.Close()
            If VerificarConexionURL(Instancia) = False Then
                MessageBox.Show("Error en la conexion al servidor, verifique la conexion. La IP configurada es " & IpServer, "Error de conexion al servidor", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ConfiguraConexionInicial.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
            End
        End Try
    End Sub
    Private Function VerificarConexionURL(ByVal mURL As String) As Boolean
        Try
            If My.Computer.Network.Ping(mURL) Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Net.WebException
            If ex.Status = Net.WebExceptionStatus.NameResolutionFailure Then
                Return False
            End If
            Return False
        End Try
    End Function
    Public Sub Versionapp()
        Label4.Text = "Version " & My.Application.Info.Version.ToString
    End Sub
    Private Sub llenaCombos()
        Dim tabla As New DataTable
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        EntidadConfiguracionParametros.Consulta = Consulta.ConsultaBaseDatos
        NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        tabla = EntidadConfiguracionParametros.TablaConsulta
        CbBaseDeDatos.DataSource = tabla
        CbBaseDeDatos.ValueMember = "database_id"
        CbBaseDeDatos.DisplayMember = "name"
        CbBaseDeDatos.SelectedIndex = 0
    End Sub
    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAccesar.Click
        Login()
    End Sub
    Private Sub TbClave_keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbClave.KeyDown, CbBaseDeDatos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub
    'Private Sub CompruebaConexionInicial()
    '    Try
    '        If File.Exists(Ruta & archivo) Then
    '            'compruebaConexionServidor()
    '        Else
    '            Dim opc As DialogResult = MsgBox("La Conexion inicial no se ha configurado aun y es requerida para continuar, ¿Configurar conexion inicial?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso")

    '            If opc = DialogResult.Yes Then
    '                ConfiguraConexionInicial.ShowDialog()
    '            ElseIf opc = DialogResult.No Then
    '                End
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
    '    End Try
    'End Sub
    Private Sub compruebaconexioninicial()
        Try
            ' Leer valores directamente desde My.Settings
            Dim rutaArchivo As String = parametros.RutaLc
            Dim rutalicencia As String = Path.Combine($"\\{parametros.IpServidor}", "Calcula Cotton\licencia_cifrada.dat")
            Dim servidor As Boolean = parametros.Servidor
            instanciabdd = parametros.InstanciaBDD
            basededatos = parametros.BaseDeDatos
            usuariodb = parametros.UsuarioBDD
            passworddb = parametros.PasswordBDD
            _usuario = parametros.Usuario
            _passuser = parametros.Password
            _ckrecuerda = parametros.CkRecuerda

            ' Actualizar controles
            'TbUsuario.Text = _usuario
            'TbClave.Text = _passuser
            'CkRecordarPassword.Checked = _ckrecuerda

            ' Verificar si la conexión inicial está configurada
            If String.IsNullOrEmpty(instanciabdd) OrElse String.IsNullOrEmpty(basededatos) _
            OrElse String.IsNullOrEmpty(usuariodb) OrElse String.IsNullOrEmpty(passworddb) Then

                Dim result As DialogResult = MessageBox.Show("La Conexion inicial no se ha configurado aun. ¿Configurar conexion inicial?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If result = DialogResult.Yes Then
                    Dim fconexioninicial As New ConfiguraConexionInicial()
                    fconexioninicial.ShowDialog()
                Else
                    Application.Exit()
                End If
            End If

            ' Verificar si la licencia existe
            If Not File.Exists(rutaArchivo) And servidor Then
                Dim result As DialogResult = MessageBox.Show("El sistema no ha sido activado aun. ¿Desea activarlo ahora?", "Activar Licencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim registrolicencia As New Registrolicencia()
                    registrolicencia.ShowDialog()
                Else
                    Application.Exit()
                End If
            ElseIf Not File.Exists(rutalicencia) And servidor = False Then
                Dim result As DialogResult = MessageBox.Show("La licencia no se ha configurado en el servidor, verificar primero antes de continuar.", "Error al validar Servidor.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
    End Sub

    'Private Sub compruebaconexioninicial()
    '    Try
    '        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    '        ConfigurationManager.RefreshSection("AppSettings")

    '        'Dim rutaArchivo As String = Path.Combine(Application.StartupPath, "licencia_cifrada.dat")
    '        Dim rutaArchivo As String = config.AppSettings.Settings("RutaLc").Value.ToString()
    '        instanciabdd = config.AppSettings.Settings("instanciabdd").Value.ToString()
    '        basededatos = config.AppSettings.Settings("basededatos").Value.ToString()
    '        usuariodb = config.AppSettings.Settings("usuariobdd").Value.ToString()
    '        passworddb = config.AppSettings.Settings("passwordbdd").Value.ToString()
    '        _usuario = config.AppSettings.Settings("usuario").Value.ToString()
    '        _passuser = config.AppSettings.Settings("password").Value.ToString()
    '        _ckrecuerda = config.AppSettings.Settings("ckrecuerda").Value

    '        TbUsuario.Text = _usuario
    '        TbClave.Text = _passuser
    '        CkRecordarPassword.Checked = _ckrecuerda

    '        If instanciabdd = "" OrElse basededatos = "" OrElse usuariodb = "" OrElse passworddb = "" Then
    '            Dim result As DialogResult = MessageBox.Show("La Conexion inicial no se ha configurado aun. ¿Configurar conexion inicial?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
    '            If result = DialogResult.Yes Then
    '                Dim fconexioninicial As New ConfiguraConexionInicial()
    '                fconexioninicial.ShowDialog()
    '            Else
    '                Application.Exit()
    '            End If
    '        End If

    '        If Not File.Exists(rutaArchivo) Then
    '            Dim result As DialogResult = MessageBox.Show("El sistema no ha sido activado aun. ¿Desea activarlo ahora?", "Activar Licencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    '            If result = DialogResult.Yes Then
    '                Dim registrolicencia As New Registrolicencia()
    '                registrolicencia.ShowDialog()
    '            Else
    '                Application.Exit()
    '            End If
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show("Error " & ex.Message)
    '    End Try
    'End Sub

    Private Sub Login()
        Try
            parametros = Parametros.Cargar()
            LicenciaHelper.actualizabdd(CbBaseDeDatos.Text.Trim)
            If UsuarioRegistrado(TbUsuario.Text) = True Then
                parametros.Usuario = TbUsuario.Text
                VarGlob.Usuario = TbUsuario.Text
                GeneraRegistroBitacora(Me.Text.Clone.ToString, BtAccesar.Text)
                parametros.ultimabdd = CbBaseDeDatos.SelectedValue
                If CkRecordarPassword.Checked = True Then
                    parametros.Password = TbClave.Text
                    parametros.CkRecuerda = CkRecordarPassword.Checked
                Else
                    parametros.CkRecuerda = CkRecordarPassword.Checked
                End If
                parametros.Guardar()
                Me.Hide()
                MenuPrincipal.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Application.ExitThread()
    End Sub
    Private Function UsuarioRegistrado(ByVal Usuario As String) As String
        Dim EntidadAcceso As New Capa_Entidad.Acceso
        Dim NegocioAcceso As New Capa_Negocio.Acceso
        Dim Encriptar As New Encriptar
        Dim Tabla As New DataTable
        Dim Resultado As Boolean = False
        EntidadAcceso.Usuario = Usuario
        EntidadAcceso.BaseDeDatos = CbBaseDeDatos.Text
        EntidadAcceso.Consulta = Consulta.ConsultaUsuario
        NegocioAcceso.ConsultarPerfiles(EntidadAcceso)
        Tabla = EntidadAcceso.TablaConsulta
        If Tabla.Rows(0).Item("Validacion") = False Then
            MessageBox.Show("El Usuario " & TbUsuario.Text & " no existe, verifique de nuevo.", "Aviso")
            Resultado = False
        ElseIf Tabla.Rows(0).Item("Clave").Equals(Encriptar.Encriptar(TbClave.Text)) = False Then
            MessageBox.Show("La contraseña ingresada no es correcta, verifique de nuevo.", "Aviso")
            TbClave.Text = ""
            TbClave.Select()
            Resultado = False
        Else
            Resultado = True
        End If
        If Tabla.Rows(0).Item("Validacion") = 1 Then
            _BaseDeDatos = CbBaseDeDatos.Text
            _IdUsuario = Tabla.Rows(0).Item("IdUsuario")
            _usuario = Tabla.Rows(0).Item("Usuario")
            _IdTipoUsuario = Tabla.Rows(0).Item("Tipo")
            _TipoUsuario = Tabla.Rows(0).Item("Descripcion")
        End If
        Return Resultado
    End Function

    Private Sub LkCambiarClave_Click(sender As Object, e As EventArgs) Handles LkCambiarClave.Click
        CambiarClave.ShowDialog()
    End Sub

End Class