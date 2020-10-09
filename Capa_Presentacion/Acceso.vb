Imports System.Deployment.Application
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.IO
Imports Capa_Operacion.Configuracion
Public Class Acceso
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\cnn\"
    Dim archivo As String = "cnn.ini"
    Private Sub Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CompruebaConexionInicial()
        TbUsuario.Text = My.Settings.user
        If TbUsuario.Text = "" Then
            TbUsuario.Select()
        Else
            TbClave.Select()
        End If
        If My.Settings.CkRecordar = True Then
            CkRecuerda.Checked = My.Settings.CkRecordar
            TbClave.Text = My.Settings.password
        End If
        llenaCombos()
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
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
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
    Private Sub CompruebaConexionInicial()
        Try
            If File.Exists(Ruta & archivo) Then
                'compruebaConexionServidor()
            Else
                Dim opc As DialogResult = MsgBox("La Conexion inicial no se ha configurado aun y es requerida para continuar, ¿Configurar conexion inicial?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso")

                If opc = DialogResult.Yes Then
                    ConfiguraConexionInicial.ShowDialog()
                ElseIf opc = DialogResult.No Then
                    End
                End If
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try
    End Sub
    Private Sub Login()
        Try
            If UsuarioRegistrado(TbUsuario.Text) = True Then
                GeneraRegistroBitacora(Me.Text.Clone.ToString, BtAccesar.Text)
                My.Settings.user = TbUsuario.Text
                If CkRecuerda.Checked = True Then
                    My.Settings.password = TbClave.Text
                    My.Settings.CkRecordar = CkRecuerda.Checked
                Else
                    My.Settings.CkRecordar = CkRecuerda.Checked
                End If
                My.Settings.Save()
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
            Resultado = False
        Else
            Resultado = True
        End If
        If Tabla.Rows(0).Item("Validacion") = 1 Then
            _BaseDeDatos = CbBaseDeDatos.Text
            _IdUsuario = Tabla.Rows(0).Item("IdUsuario")
            _Usuario = Tabla.Rows(0).Item("Usuario")
            _IdTipoUsuario = Tabla.Rows(0).Item("Tipo")
            _TipoUsuario = Tabla.Rows(0).Item("Descripcion")
        End If
        Return Resultado
    End Function

    Private Sub LkCambiarClave_Click(sender As Object, e As EventArgs) Handles LkCambiarClave.Click
        CambiarClave.ShowDialog()
    End Sub
End Class