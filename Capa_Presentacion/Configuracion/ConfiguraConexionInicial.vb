Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports Capa_Entidad
Imports Capa_Negocio
Imports Capa_Operacion
Imports Capa_Operacion.Configuracion
Public Class ConfiguraConexionInicial
    Dim parametros As Parametros
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\cnn\"
    Dim archivo As String = "cnn.ini"
    Dim archivo2 As String = "cnnPerfiles.ini"
    Private instancia, basededatos, basededatosperfiles, usuario, password, ipservidor As String
    Private rbsrv, rbsta As Boolean
    Public Sub New()
        InitializeComponent()

        ' Agregar evento para validación
        'AddHandler tbipservidor.Validating, Sub(sender As Object, e As System.ComponentModel.CancelEventArgs)
        '                                        If Not IsValidIP(tbipservidor.Text) Then
        '                                            MessageBox.Show("La dirección IP no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                                            e.Cancel = True
        '                                        End If
        '                                    End Sub

        ' Agregar el MaskedTextBox al formulario (opcional si no está en el diseñador)
        ' Me.Controls.Add(tbipservidor)
    End Sub

    Private Sub ConfiguraConexionInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nuevo()  ' Si tienes alguna inicialización adicional
        parametros = Parametros.Cargar()
        CbOrigenInstancia.Text = parametros.InstanciaBDD
        tbbdd.Text = parametros.BaseDeDatos
        TbOrigenUsuario.Text = parametros.UsuarioBDD
        TbOrigenPassword.Text = parametros.PasswordBDD
        rbserver.Checked = parametros.Servidor
        rbestacion.Checked = parametros.Estacion
        tbhostserver.Text = parametros.IpServidor
    End Sub
    Private Sub LLenaComboInstancias(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        Dim tabla As New DataTable
        Dim EntidadCrearEstructura As New Capa_Entidad.CrearEstructura
        Dim NegocioCrearEstructura As New Capa_Negocio.CrearEstructura
        EntidadCrearEstructura.Consulta = Consulta.ConsultaInstancia
        NegocioCrearEstructura.ConsultarInstancia(EntidadCrearEstructura)
        tabla = EntidadCrearEstructura.TablaConsulta
        For Each rowServidor In tabla.Rows
            If String.IsNullOrEmpty(rowServidor(“InstanceName”).ToString()) Then
                cmb.Items.Add(rowServidor(“ServerName”).ToString())
            Else
                cmb.Items.Add(rowServidor(“ServerName”) & “\” & rowServidor(“InstanceName”))
            End If
        Next
    End Sub
    Private Sub BtnCrearTxt_Click(sender As Object, e As EventArgs)
        CreaConexion()
        'CreaConexionPerfiles()
        TbOrigenPassword.Clear()
        TbOrigenUsuario.Clear()
        CbOrigenInstancia.SelectedIndex = -1
    End Sub
    Private Function IsValidIP(ip As String) As Boolean
        If String.IsNullOrWhiteSpace(ip) Then Return False

        Dim parts() As String = ip.Split("."c)
        If parts.Length <> 4 Then Return False

        For Each part As String In parts
            ' Aquí estaba comentado el código de validación
            ' Si quieres validarlo correctamente, descomenta y usa:
            ' Dim num As Integer
            ' If Not Integer.TryParse(part, num) OrElse num < 0 OrElse num > 255 Then
            '     Return False
            ' End If

            ' Por ahora siempre devuelve False según el código original
            Return False
        Next

        Return True
    End Function
    Private Sub CreaConexion()
        Try
            ' Intentar la conexión primero
            If VerifyConnection() = True Then
                ' Guardar los valores en My.Settings
                parametros.InstanciaBDD = CbOrigenInstancia.Text
                parametros.BaseDeDatosPerfiles = tbbddperfiles.Text
                parametros.BaseDeDatos = tbbdd.Text
                parametros.UsuarioBDD = TbOrigenUsuario.Text
                parametros.PasswordBDD = TbOrigenPassword.Text
                parametros.Servidor = rbserver.Checked
                parametros.Estacion = rbestacion.Checked
                parametros.IpServidor = tbhostserver.Text
                parametros.Guardar()
                MessageBox.Show("Guardado con éxito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                ' Guardar los valores aunque la conexión falle, para que el usuario no los pierda

                parametros.InstanciaBDD = CbOrigenInstancia.Text
                parametros.BaseDeDatosPerfiles = tbbddperfiles.Text
                parametros.BaseDeDatos = tbbdd.Text
                parametros.UsuarioBDD = TbOrigenUsuario.Text
                parametros.PasswordBDD = TbOrigenPassword.Text
                parametros.Servidor = rbserver.Checked
                parametros.Estacion = rbestacion.Checked
                parametros.IpServidor = tbhostserver.Text
                parametros.Guardar()
                MessageBox.Show("Hay un error con la conexión. Verifique que el sistema inició como administrador o que los datos fueron ingresados correctamente.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Public Function VerifyConnection() As Boolean
        Dim connectionString As String = "Data Source=" & CbOrigenInstancia.Text & ";Initial Catalog=" & tbbdd.Text & ";Persist Security Info=True;User ID=" & TbOrigenUsuario.Text & ";Password=" & TbOrigenPassword.Text
        Dim cnn As SqlConnection = New SqlConnection(connectionString)

        Try
            cnn.Open()
            cnn.Close()
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Sub CreaConexionPerfiles()

    End Sub
    Private Sub nuevo()
        CbOrigenInstancia.SelectedIndex = -1
        TbOrigenUsuario.Text = ""
        TbOrigenPassword.Text = ""
    End Sub

    Private Sub rbserver_CheckedChanged(sender As Object, e As EventArgs) Handles rbserver.CheckedChanged
        If rbserver.Checked Then
            tbipservidor.Enabled = False
            tbhostserver.Enabled = False
        End If
    End Sub

    Private Sub rbestacion_CheckedChanged(sender As Object, e As EventArgs) Handles rbestacion.CheckedChanged
        If rbestacion.Checked Then
            tbipservidor.Enabled = True
            tbhostserver.Enabled = True
        End If
    End Sub

    Private Sub BtnSobreescribir_Click()

    End Sub
    Private Sub BtnSobreescribirPerfil()

    End Sub
    Private Sub CbOrigenInstancia_Click(sender As Object, e As EventArgs) Handles CbOrigenInstancia.Click

    End Sub
    Sub LeerArchivo()
        Dim leer As New StreamReader(Ruta & archivo)

        Try
            While leer.Peek <> -1
                Dim linea As String = leer.ReadLine()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                Dim ArregloCadena() As String = Split(linea, ",")

            End While

            leer.Close()

        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    Private Sub Salir(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Leer valores desde My.Settings

        instancia = parametros.InstanciaBDD
        basededatos = parametros.BaseDeDatos
        usuario = parametros.UsuarioBDD
        password = parametros.PasswordBDD
        rbsrv = parametros.Servidor
        rbsta = parametros.Estacion
        ipservidor = parametros.IpServidor

        ' Verificar si la configuración está completa
        If String.IsNullOrEmpty(instancia) OrElse String.IsNullOrEmpty(basededatos) _
           OrElse String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(password) Then

            Dim result As DialogResult = MessageBox.Show("No ha configurado la conexión a la base de datos, no podrá realizar ningún procedimiento. ¿Desea salir?",
                                                         "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Cierra la aplicación
                Environment.Exit(0)
            ElseIf result = DialogResult.No Then
                e.Cancel = True
            End If
        Else
            e.Cancel = False
        End If
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If rbserver.Checked Then
            tbhostserver.Text = ""
        End If
        If (rbestacion.Checked And tbhostserver.Text <> "") Or (rbserver.Checked And tbhostserver.Text = "") Then
            CreaConexion()
        ElseIf rbestacion.Checked And tbhostserver.Text = "" Then
            MessageBox.Show("Si esta configurando este equipo como estacion, agregue el host o ip del Servidor para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class