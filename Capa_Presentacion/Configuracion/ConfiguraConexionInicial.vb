Imports System.IO
Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConfiguraConexionInicial
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\cnn\"
    Dim archivo As String = "cnn.ini"
    Dim archivo2 As String = "cnnPerfiles.ini"
    Private Sub ConfiguraConexionInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nuevo()
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
    Private Sub BtnCrearTxt_Click(sender As Object, e As EventArgs) Handles BtCreaConexion.Click
        CreaConexion()
        CreaConexionPerfiles()
        TbDireccionIP1.Clear()
        TbDireccionIP2.Clear()
        TbDireccionIP3.Clear()
        TbDireccionIP4.Clear()
        TbOrigenPassword.Clear()
        TbOrigenUsuario.Clear()
        CbOrigenInstancia.SelectedIndex = -1
    End Sub
    Private Sub CreaConexion()
        Dim fs As FileStream
        If TbDireccionIP1.Text <> "" And TbDireccionIP2.Text <> "" And TbDireccionIP3.Text <> "" And TbDireccionIP4.Text <> "" And CbOrigenInstancia.Text <> "" And TbOrigenPassword.Text <> "" And TbOrigenUsuario.Text <> "" Then
            ':::Validamos si la carpeta de ruta existe, si no existe la creamos
            Try
                If File.Exists(Ruta & archivo) Then

                    ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                    fs = File.Create(Ruta & archivo)
                    fs.Close()
                    BtnSobreescribir_Click()
                    'MsgBox("Conexion creada correctamente.", MsgBoxStyle.Information, "")
                    Close()
                Else

                    ':::Si la carpeta no existe la creamos
                    Directory.CreateDirectory(Ruta)

                    ':::Una vez creada la carpeta creamos o sobreescribios el archivo txt
                    fs = File.Create(Ruta & archivo)
                    fs.Close()
                    BtnSobreescribir_Click()
                    'MsgBox("Conexion creada correctamente.", MsgBoxStyle.Information, "")
                    Close()
                End If

            Catch ex As Exception
                MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
            End Try
        Else
            MsgBox("Todos los campos son requeridos, no es permitido continuar", MsgBoxStyle.Critical, "Aviso")
        End If
    End Sub
    Private Sub CreaConexionPerfiles()
        Dim fs As FileStream
        If TbDireccionIP1.Text <> "" And TbDireccionIP2.Text <> "" And TbDireccionIP3.Text <> "" And TbDireccionIP4.Text <> "" And CbOrigenInstancia.Text <> "" And TbOrigenPassword.Text <> "" And TbOrigenUsuario.Text <> "" Then
            ':::Validamos si la carpeta de ruta existe, si no existe la creamos
            Try
                If File.Exists(Ruta & archivo2) Then

                    ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                    fs = File.Create(Ruta & archivo2)
                    fs.Close()
                    BtnSobreescribirPerfil()
                    MsgBox("Conexion creada correctamente.", MsgBoxStyle.Information, "")
                    Close()
                Else

                    ':::Si la carpeta no existe la creamos
                    Directory.CreateDirectory(Ruta)

                    ':::Una vez creada la carpeta creamos o sobreescribios el archivo txt
                    fs = File.Create(Ruta & archivo2)
                    fs.Close()
                    BtnSobreescribirPerfil()
                    MsgBox("Conexion creada correctamente.", MsgBoxStyle.Information, "")
                    Close()
                End If

            Catch ex As Exception
                MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
            End Try

        Else
            MsgBox("Todos los campos son requeridos, no es permitido continuar", MsgBoxStyle.Critical, "Aviso")
        End If
    End Sub
    Private Sub nuevo()
        TbDireccionIP1.Text = ""
        TbDireccionIP2.Text = ""
        TbDireccionIP3.Text = ""
        TbDireccionIP4.Text = ""
        TbDireccionIP1.Select()
        CbOrigenInstancia.SelectedIndex = -1
        TbOrigenUsuario.Text = ""
        TbOrigenPassword.Text = ""
    End Sub
    Private Sub BtnSobreescribir_Click()
        ':::Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT
        Dim escribir As New StreamWriter(Ruta & archivo)
        Dim DireccionIP As String = ""
        Try
            DireccionIP = TbDireccionIP1.Text + "." + TbDireccionIP2.Text + "." + TbDireccionIP3.Text + "." + TbDireccionIP4.Text
            ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
            escribir.WriteLine(DireccionIP + "," + CbOrigenInstancia.Text + "," + TbOrigenUsuario.Text + "," + TbOrigenPassword.Text)
            escribir.Close()
            ':::Limpiamos los TextBox

            ':::Llamamos nuestro procedimiento para leer el archivo TXT
            'LeerArchivo()
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    Private Sub BtnSobreescribirPerfil()
        ':::Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT
        Dim escribir As New StreamWriter(Ruta & archivo2)
        Dim DireccionIP As String = ""
        Try
            DireccionIP = TbDireccionIP1.Text + "." + TbDireccionIP2.Text + "." + TbDireccionIP3.Text + "." + TbDireccionIP4.Text
            ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
            escribir.WriteLine(DireccionIP + "," + CbOrigenInstancia.Text + "," + "Perfiles" + "," + TbOrigenUsuario.Text + "," + TbOrigenPassword.Text)
            escribir.Close()
            ':::Limpiamos los TextBox
            ':::Llamamos nuestro procedimiento para leer el archivo TXT
            'LeerArchivo()
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    Private Sub CbOrigenInstancia_Click(sender As Object, e As EventArgs) Handles CbOrigenInstancia.Click
        If CbOrigenInstancia.Items.Count = 0 Then
            LLenaComboInstancias(CbOrigenInstancia)
        End If

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
        If File.Exists(Ruta & archivo) Then
            e.Cancel = False
        Else
            Dim opc As DialogResult = MsgBox("Aun no se configura la conexion inicial, sin ella el sistema no continuara. Dar click en SI para configurar, No para cerrar el sistema.", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Salir")
            If opc = DialogResult.Yes Then
                e.Cancel = True
            ElseIf opc = DialogResult.No Then
                End
            End If
        End If
    End Sub
    Private Sub MaskedTextBox1_GotFocus(sender As Object, e As EventArgs) Handles TbDireccionIP3.GotFocus
        TbDireccionIP3.SelectAll()
    End Sub
    Private Sub MaskedTextBox2_GotFocus(sender As Object, e As EventArgs) Handles TbDireccionIP2.GotFocus
        TbDireccionIP2.SelectAll()
    End Sub
    Private Sub MaskedTextBox3_GotFocus(sender As Object, e As EventArgs) Handles TbDireccionIP1.GotFocus
        TbDireccionIP1.SelectAll()
    End Sub
    Private Sub MaskedTextBox4_GotFocus(sender As Object, e As EventArgs) Handles TbDireccionIP4.GotFocus
        TbDireccionIP4.SelectAll()
    End Sub
End Class