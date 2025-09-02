Imports System.IO
Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ParametrosCorreo
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\conf\"
    Dim archivo As String = "confemail.ini"
    Private Sub ParametrosCorreo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TbEmail.Text = ""
        TbHostsmtp.Text = ""
        TbPassword.Text = ""
        TbPuertosmtp.Text = ""
        TbRuta.Text = ""
        CkConexionCifrada.Checked = False
        LeerArchivoconfiguracion()
    End Sub
    Private Sub CreaConexion()
        Dim fs As FileStream
        If TbPuertosmtp.Text <> "" And TbPassword.Text <> "" And TbHostsmtp.Text <> "" And TbEmail.Text <> "" Then
            ':::Validamos si la carpeta de ruta existe, si no existe la creamos
            Try
                If File.Exists(Ruta & archivo) Then

                    ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                    fs = File.Create(Ruta & archivo)
                    fs.Close()
                    SobreEscribirConfiguracion()
                    'MsgBox("Conexion creada correctamente.", MsgBoxStyle.Information, "")
                Else

                    ':::Si la carpeta no existe la creamos
                    Directory.CreateDirectory(Ruta)

                    ':::Una vez creada la carpeta creamos o sobreescribios el archivo txt
                    fs = File.Create(Ruta & archivo)
                    fs.Close()
                    SobreEscribirConfiguracion()
                    'MsgBox("Conexion creada correctamente.", MsgBoxStyle.Information, "")
                End If
            Catch ex As Exception
                MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
            End Try
        Else
            MsgBox("Todos los campos son requeridos, no es permitido continuar", MsgBoxStyle.Critical, "Aviso")
        End If
    End Sub
    Private Sub SobreEscribirConfiguracion()
        ':::Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT
        Dim escribir As New StreamWriter(Ruta & archivo)
        Dim DireccionIP As String = ""
        Try
            escribir.WriteLine("Email=" & TbEmail.Text & vbCrLf & "Contraseña=" & TbPassword.Text & vbCrLf & "Host SMTP=" & TbHostsmtp.Text & vbCrLf & "Puerto SMTP=" & TbPuertosmtp.Text & vbCrLf & "SSL=" & CkConexionCifrada.CheckState)
            ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
            escribir.Close()
            MsgBox("Se guardo la informacion correctamente.", MsgBoxStyle.Information, " ")
            ':::Limpiamos los TextBox

            ':::Llamamos nuestro procedimiento para leer el archivo TXT
            'LeerArchivo()
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    Private Sub ObtenerArchivoConfiguracion()
        Dim leer As New StreamReader(Ruta & archivo)
        Try
            While leer.Peek <> -1
                Dim linea As String = leer.ReadToEnd()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                Dim arreglocadena() As String = Split(linea, vbCrLf)
                TbEmail.Text = ObtenerValor(arreglocadena(0))
                TbPassword.Text = ObtenerValor(arreglocadena(1))
                TbHostsmtp.Text = ObtenerValor(arreglocadena(2))
                TbPuertosmtp.Text = ObtenerValor(arreglocadena(3))
                CkConexionCifrada.Checked = ObtenerValor(arreglocadena(4))
            End While
            leer.Close()
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function ObtenerValor(ByVal cadena As String)
        Dim Resultado As String
        Dim ArregloCadena() As String = Split(cadena, "=")
        Resultado = ArregloCadena(1)
        Return Resultado
    End Function
    Private Sub LeerArchivoconfiguracion()
        If File.Exists(Ruta & archivo) Then
            ObtenerArchivoConfiguracion()
            'Else
            '    CreaConexion()
        End If
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        CreaConexion()
    End Sub

    Private Sub btenvia_Click(sender As Object, e As EventArgs) Handles btenvia.Click
        enviarCorreo(TbEmail.Text, TbPassword.Text, tbmensaje.Text, tbasunto.Text, tbdestinatario.Text, TbPuertosmtp.Text, TbHostsmtp.Text, CkConexionCifrada.CheckState, TbRuta.Text)
    End Sub

    Private Sub btadjuntar_Click(sender As Object, e As EventArgs) Handles btadjuntar.Click
        OpenFileDialog1.ShowDialog()
        TbRuta.Text = OpenFileDialog1.FileName
    End Sub
End Class