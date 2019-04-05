Imports System.IO
Imports Capa_Operacion.Configuracion
Public Class ConfiguraConexionInicial
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\cnn\"
    Dim archivo As String = "cnn.ini"
    Private Sub ConfiguraConexionInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub LLenaComboInstancias(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        Dim tabla As New DataTable
        Dim EntidadCrearEstructura As New Capa_Entidad.CrearEstructura
        Dim NegocioCrearEstructura As New Capa_Negocio.CrearEstructura
        EntidadCrearEstructura.Consulta = Consulta.ConsultaInstancia
        NegocioCrearEstructura.Consultar(EntidadCrearEstructura)
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

        Dim fs As FileStream

        ':::Validamos si la carpeta de ruta existe, si no existe la creamos
        Try
            If File.Exists(Ruta) Then

                ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                fs = File.Create(Ruta & archivo)
                fs.Close()
                BtnSobreescribir_Click()
                MsgBox("Conexion creada correctamente.", MsgBoxStyle.Information, "")
            Else

                ':::Si la carpeta no existe la creamos
                Directory.CreateDirectory(Ruta)

                ':::Una vez creada la carpeta creamos o sobreescribios el archivo txt
                fs = File.Create(Ruta & archivo)
                fs.Close()
                BtnSobreescribir_Click()
                MsgBox("Conexion creada correctamente.", MsgBoxStyle.Information, "")
            End If

        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub
    Private Sub BtnSobreescribir_Click()
        ':::Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT
        Dim escribir As New StreamWriter(Ruta & archivo)
        Try
            ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
            escribir.WriteLine(CbOrigenInstancia.Text + "," + TbOrigenUsuario.Text + "," + TbOrigenPassword.Text)
            escribir.Close()
            ':::Limpiamos los TextBox
            TbOrigenPassword.Clear()
            TbOrigenUsuario.Clear()
            CbOrigenInstancia.SelectedIndex = -1
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
        ':::Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
        Dim leer As New StreamReader(Ruta & archivo)
        Dim ArregloCadena() As String
        ':::Limpiamos nuestro ListBox
        'ListBoxClientes.Items.Clear()

        Try
            ':::Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
            While leer.Peek <> -1
                ':::Leemos cada linea del archivo TXT
                Dim linea As String = leer.ReadLine()
                ':::Validamos que la linea no este vacia
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                ArregloCadena() = linea.Split(",")
                ':::Agregramos los registros encontrados

            End While

            leer.Close()

        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    'Private Sub BtnGuardarTodo_Click(sender As Object, e As EventArgs) Handles BtnGuardarTodo.Click
    '    ':::Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT
    '    ':::El unico cambio es que agregamos el valor TRUE con el fin de indicar que queremos
    '    ':::Seguir agregando los registros y no sobreescribirlos
    '    Dim escribir As New StreamWriter(Ruta & archivo, True)
    '    Try
    '        ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
    '        escribir.WriteLine(TxtNombres.Text + "," + TxtApellidos.Text)
    '        escribir.Close()
    '        MsgBox("Registro guardado correctamente", MsgBoxStyle.Information, " ")
    '        TbOrigenPassword.Clear()
    '        TbOrigenUsuario.Clear()
    '        CbOrigenInstancia.Items.Clear()
    '        ':::Llamamos nuestro procedimiento para leer el archivo TXT
    '        LeerArchivo()
    '    Catch ex As Exception
    '        MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
    '    End Try
    'End Sub
    'Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
    '    Try
    '        If File.Exists(Ruta & archivo) Then
    '            ':::Eliminamos el archivo TXT
    '            File.Delete(Ruta & archivo)
    '            MsgBox("Archivo eliminado correctamente", MsgBoxStyle.Information, " ")

    '        Else
    '            MsgBox("No se encuentra el archivo especificado", MsgBoxStyle.Information, " ")
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Se presento un problema al eliminar el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
    '    End Try
    'End Sub
End Class