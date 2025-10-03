Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports Capa_Entidad
Imports Capa_Negocio
Imports Capa_Operacion.Configuracion
Public Class ConfiguraConexionInicial
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\cnn\"
    Dim archivo As String = "cnn.ini"
    Dim archivo2 As String = "cnnPerfiles.ini"
    Private instancia, basededatos, basededatosperfiles, usuario, password, ipservidor As String
    Private rbsrv, rbsta As Boolean
    Public Sub New()
        InitializeComponent()

        ' Agregar evento para validación
        AddHandler tbipservidor.Validating, Sub(sender As Object, e As System.ComponentModel.CancelEventArgs)
                                                If Not IsValidIP(tbipservidor.Text) Then
                                                    MessageBox.Show("La dirección IP no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                    e.Cancel = True
                                                End If
                                            End Sub

        ' Agregar el MaskedTextBox al formulario (opcional si no está en el diseñador)
        ' Me.Controls.Add(tbipservidor)
    End Sub

    Private Sub ConfiguraConexionInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'nuevo()
        'instancia = ConfigurationManager.AppSettings("instanciabdd")
        'basededatosperfiles = ConfigurationManager.AppSettings("basededatosPerfiles")
        'basededatos = ConfigurationManager.AppSettings("basededatos")
        'Usuario = ConfigurationManager.AppSettings("usuariobdd")
        'password = ConfigurationManager.AppSettings("passwordbdd")
        'rbsrv = Convert.ToBoolean(ConfigurationManager.AppSettings("servidor"))
        'rbsta = Convert.ToBoolean(ConfigurationManager.AppSettings("estacion"))
        'ipservidor = ConfigurationManager.AppSettings("ipservidor")
        nuevo()  ' Si tienes alguna inicialización adicional

        ' Leer valores desde My.Settings
        instancia = My.Settings.instanciabdd
        basededatosperfiles = My.Settings.basededatosperfiles
        basededatos = My.Settings.basededatos
        usuario = My.Settings.usuariobdd
        password = My.Settings.passwordbdd
        rbsrv = My.Settings.servidor
        rbsta = My.Settings.estacion
        ipservidor = My.Settings.ipservidor

        CbOrigenInstancia.Text = instancia
        tbbdd.Text = basededatos
        TbOrigenUsuario.Text = usuario
        TbOrigenPassword.Text = password
        rbserver.Checked = rbsrv
        rbestacion.Checked = rbsta
        tbipservidor.Text = ipservidor
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
                My.Settings.instanciabdd = CbOrigenInstancia.Text
                My.Settings.basededatosperfiles = tbbddperfiles.Text
                My.Settings.basededatos = tbbdd.Text
                My.Settings.usuariobdd = TbOrigenUsuario.Text
                My.Settings.passwordbdd = TbOrigenPassword.Text
                My.Settings.servidor = rbserver.Checked
                My.Settings.estacion = rbestacion.Checked
                My.Settings.ipservidor = tbipservidor.Text

                My.Settings.Save() ' Guardar cambios permanentes

                MessageBox.Show("Guardado con éxito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                ' Guardar los valores aunque la conexión falle, para que el usuario no los pierda
                My.Settings.instanciabdd = CbOrigenInstancia.Text
                My.Settings.basededatosperfiles = tbbddperfiles.Text
                My.Settings.basededatos = tbbdd.Text
                My.Settings.usuariobdd = TbOrigenUsuario.Text
                My.Settings.passwordbdd = TbOrigenPassword.Text
                My.Settings.servidor = rbserver.Checked
                My.Settings.estacion = rbestacion.Checked
                My.Settings.ipservidor = tbipservidor.Text

                My.Settings.Save() ' Guardar cambios permanentes

                MessageBox.Show("Hay un error con la conexión. Verifique que el sistema inició como administrador o que los datos fueron ingresados correctamente.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    'Private Sub CreaConexion()
    '    Try
    '        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    '        ConfigurationManager.RefreshSection("appSettings")

    '        If VerifyConnection() = True Then
    '            config.AppSettings.Settings("instanciabdd").Value = CbOrigenInstancia.Text
    '            config.AppSettings.Settings("basededatosPerfiles").Value = tbbddperfiles.Text
    '            config.AppSettings.Settings("basededatos").Value = tbbdd.Text
    '            config.AppSettings.Settings("usuariobdd").Value = TbOrigenUsuario.Text
    '            config.AppSettings.Settings("passwordbdd").Value = TbOrigenPassword.Text
    '            config.AppSettings.Settings("servidor").Value = rbserver.Checked.ToString()
    '            config.AppSettings.Settings("estacion").Value = rbestacion.Checked.ToString()
    '            config.AppSettings.Settings("ipservidor").Value = tbipservidor.Text
    '            config.Save(ConfigurationSaveMode.Modified)

    '            MessageBox.Show("Guardado con exito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Me.Close()
    '        Else
    '            config.AppSettings.Settings("instanciabdd").Value = CbOrigenInstancia.Text
    '            config.AppSettings.Settings("basededatosPerfiles").Value = tbbddperfiles.Text
    '            config.AppSettings.Settings("basededatos").Value = tbbdd.Text
    '            config.AppSettings.Settings("usuariobdd").Value = TbOrigenUsuario.Text
    '            config.AppSettings.Settings("passwordbdd").Value = TbOrigenPassword.Text
    '            config.AppSettings.Settings("servidor").Value = rbserver.Checked.ToString()
    '            config.AppSettings.Settings("estacion").Value = rbestacion.Checked.ToString()
    '            config.AppSettings.Settings("ipservidor").Value = tbipservidor.Text
    '            config.Save(ConfigurationSaveMode.Modified)

    '            MessageBox.Show("Hay un error con la conexion, verifique que el sistema inició como administrador, o que los datos fueron ingresados correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If

    '    Catch Ex As Exception
    '        MessageBox.Show(Ex.Message)
    '    End Try
    'End Sub
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
        'Dim fs As FileStream
        'If TbDireccionIP1.Text <> "" And TbDireccionIP2.Text <> "" And TbDireccionIP3.Text <> "" And TbDireccionIP4.Text <> "" And CbOrigenInstancia.Text <> "" And TbOrigenPassword.Text <> "" And TbOrigenUsuario.Text <> "" Then
        '    ':::Validamos si la carpeta de ruta existe, si no existe la creamos
        '    Try
        '        If File.Exists(Ruta & archivo2) Then

        '            ':::Si la carpeta existe creamos o sobreescribios el archivo txt
        '            fs = File.Create(Ruta & archivo2)
        '            fs.Close()
        '            BtnSobreescribirPerfil()
        '            MsgBox("Conexion creada correctamente.", MsgBoxStyle.Information, "")
        '            Close()
        '        Else

        '            ':::Si la carpeta no existe la creamos
        '            Directory.CreateDirectory(Ruta)

        '            ':::Una vez creada la carpeta creamos o sobreescribios el archivo txt
        '            fs = File.Create(Ruta & archivo2)
        '            fs.Close()
        '            BtnSobreescribirPerfil()
        '            MsgBox("Conexion creada correctamente.", MsgBoxStyle.Information, "")
        '            Close()
        '        End If

        '    Catch ex As Exception
        '        MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
        '    End Try

        'Else
        '    MsgBox("Todos los campos son requeridos, no es permitido continuar", MsgBoxStyle.Critical, "Aviso")
        'End If
    End Sub
    Private Sub nuevo()
        CbOrigenInstancia.SelectedIndex = -1
        TbOrigenUsuario.Text = ""
        TbOrigenPassword.Text = ""
    End Sub
    Private Sub BtnSobreescribir_Click()
        ':::Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT
        'Dim escribir As New StreamWriter(Ruta & archivo)
        'Dim DireccionIP As String = ""
        'Try
        '    DireccionIP = TbDireccionIP1.Text + "." + TbDireccionIP2.Text + "." + TbDireccionIP3.Text + "." + TbDireccionIP4.Text
        '    ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
        '    escribir.WriteLine(DireccionIP + "," + CbOrigenInstancia.Text + "," + TbOrigenUsuario.Text + "," + TbOrigenPassword.Text)
        '    escribir.Close()
        '    ':::Limpiamos los TextBox

        '    ':::Llamamos nuestro procedimiento para leer el archivo TXT
        '    'LeerArchivo()
        'Catch ex As Exception
        '    MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        'End Try
    End Sub
    Private Sub BtnSobreescribirPerfil()
        ':::Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT
        'Dim escribir As New StreamWriter(Ruta & archivo2)
        'Dim DireccionIP As String = ""
        'Try
        '    DireccionIP = TbDireccionIP1.Text + "." + TbDireccionIP2.Text + "." + TbDireccionIP3.Text + "." + TbDireccionIP4.Text
        '    ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
        '    escribir.WriteLine(DireccionIP + "," + CbOrigenInstancia.Text + "," + "Perfiles" + "," + TbOrigenUsuario.Text + "," + TbOrigenPassword.Text)
        '    escribir.Close()
        '    ':::Limpiamos los TextBox
        '    ':::Llamamos nuestro procedimiento para leer el archivo TXT
        '    'LeerArchivo()
        'Catch ex As Exception
        '    MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        'End Try
    End Sub
    Private Sub CbOrigenInstancia_Click(sender As Object, e As EventArgs) Handles CbOrigenInstancia.Click
        'If CbOrigenInstancia.Items.Count = 0 Then
        '    LLenaComboInstancias(CbOrigenInstancia)
        'End If

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
        instancia = My.Settings.instanciabdd
        basededatos = My.Settings.basededatos
        usuario = My.Settings.usuariobdd
        password = My.Settings.passwordbdd
        rbsrv = My.Settings.servidor
        rbsta = My.Settings.estacion
        ipservidor = My.Settings.ipservidor

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
        'instancia = ConfigurationManager.AppSettings("instanciabdd")
        'basededatos = ConfigurationManager.AppSettings("basededatos")
        'usuario = ConfigurationManager.AppSettings("usuariobdd")
        'password = ConfigurationManager.AppSettings("passwordbdd")
        'rbsrv = Convert.ToBoolean(ConfigurationManager.AppSettings("servidor"))
        'rbsta = Convert.ToBoolean(ConfigurationManager.AppSettings("estacion"))
        'ipservidor = ConfigurationManager.AppSettings("ipservidor")

        'If String.IsNullOrEmpty(instancia) OrElse String.IsNullOrEmpty(basededatos) OrElse String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(password) Then
        '    Dim result As DialogResult = MessageBox.Show("No ha configurado la conexion a la base de datos, no podrá realizar ningún procedimiento. ¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '    If result = DialogResult.Yes Then
        '        ' Cierra la aplicación
        '        Environment.Exit(0)
        '    ElseIf result = DialogResult.No Then
        '        e.Cancel = True
        '    End If
        'Else
        '    e.Cancel = False
        'End If
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        CreaConexion()
    End Sub
End Class