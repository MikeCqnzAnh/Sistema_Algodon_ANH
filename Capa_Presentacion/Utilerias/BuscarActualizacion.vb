Imports System.IO.Compression
Imports System.Net
Imports System.IO
Public Class BuscarActualizacion
    Dim proces As New Process()
    Dim CarpetaOrigen As String = "\\192.168.10.29\Scanner\Miguel\update"
    Dim CarpetaDestino As String = My.Computer.FileSystem.CurrentDirectory + "\update\SetupAlgodon.zip"
    Dim Version As String
    Dim NombreArchivo As String = "\Version.txt"
    Private Sub BuscarActualizacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = Application.ProductVersion.ToString
        LeerArchivo()
        validaVersion()
    End Sub
    Private Sub validaVersion()
        If Version > Label1.Text Then
            Label6.Visible = True
            Label4.Visible = True
            BtActualizar.Enabled = True
        Else
            Label4.Visible = True
            BtActualizar.Enabled = False
            Label4.Text = "Tienes la version mas reciente!!"
        End If
    End Sub
    Private Sub ComprobarNuevaActualizacion()
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.CurrentDirectory + "\Update")

        If My.Computer.FileSystem.FileExists(CarpetaOrigen + "\Setup.exe") = True Then
            If Version > Application.ProductVersion = False Then


            ElseIf Version > Application.ProductVersion = True Then
                Dim opc As DialogResult = MsgBox("Actualizacion Disponible ¿Desea aplicarla ahora? " & vbCrLf & vbCrLf & "El sistema se cerrara para continuar con la actualizacion del sistema", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Nueva Actualizacion")
                If opc = DialogResult.Yes Then
                    CopiarArchivo()
                ElseIf opc = DialogResult.No Then

                End If
            End If
        End If
    End Sub
    Private Sub CopiarArchivo()
        If My.Computer.FileSystem.FileExists(CarpetaOrigen + "\SetupAlgodon.zip") = True Then
            My.Computer.FileSystem.CopyFile(CarpetaOrigen + "\SetupAlgodon.zip", CarpetaDestino)
            'descomprimir()
            DescomprimeZip()
            proces.StartInfo.FileName = My.Computer.FileSystem.CurrentDirectory + "\update\Setup.exe"
            proces.Start()
            Application.ExitThread()
        ElseIf My.Computer.FileSystem.FileExists(CarpetaOrigen + "\SetupAlgodon.zip") = False Then

        End If
    End Sub
    Private Sub LeerArchivo()
        Dim leer As New StreamReader(CarpetaOrigen & NombreArchivo)

        Try
            While leer.Peek <> -1
                Dim linea As String = leer.ReadLine()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                Dim ArregloCadena() As String = Split(linea, "|")
                Label4.Text = ArregloCadena(0)
                Version = ArregloCadena(0)
            End While

            leer.Close()

        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    'Private Sub descomprimir()
    '    Dim descomprimir As New Shell32.Shell()
    '    Dim output As Shell32.Folder = descomprimir.NameSpace(My.Computer.FileSystem.CurrentDirectory + "\Update") 'Directorio donde se encuentre el archivo a descomprimir
    '    Dim input As Shell32.Folder = descomprimir.NameSpace(My.Computer.FileSystem.CurrentDirectory + "\Update\SetupAlgodon.zip")
    '    If System.IO.File.Exists(My.Computer.FileSystem.CurrentDirectory + "\Update\SetupAlgodon.msi") = True And System.IO.File.Exists(My.Computer.FileSystem.CurrentDirectory + "\Update\Setup.exe") = True Then
    '        System.IO.File.Delete(My.Computer.FileSystem.CurrentDirectory + "\Update\SetupAlgodon.msi")
    '        System.IO.File.Delete(My.Computer.FileSystem.CurrentDirectory + "\Update\Setup.exe")
    '    End If
    '    output.CopyHere(input.Items, 4)

    '    Dim Borrarzip As String
    '    Borrarzip = (My.Computer.FileSystem.CurrentDirectory + "\Update\SetupAlgodon.zip")

    '    'comprobamos que el archivo existe
    '    If System.IO.File.Exists(Borrarzip) = True Then
    '        System.IO.File.Delete(Borrarzip)
    '    End If
    'End Sub
    Private Sub DescomprimeZip()
        Dim directorioOrigen As String = My.Computer.FileSystem.CurrentDirectory + "\Update"
        Dim directorioZip As String = My.Computer.FileSystem.CurrentDirectory + "\Update\SetupAlgodon.zip"
        If System.IO.File.Exists(My.Computer.FileSystem.CurrentDirectory + "\Update\SetupAlgodon.msi") = True And System.IO.File.Exists(My.Computer.FileSystem.CurrentDirectory + "\Update\Setup.exe") = True Then
            System.IO.File.Delete(My.Computer.FileSystem.CurrentDirectory + "\Update\SetupAlgodon.msi")
            System.IO.File.Delete(My.Computer.FileSystem.CurrentDirectory + "\Update\Setup.exe")
        End If
        Dim Borrarzip As String
        Borrarzip = (My.Computer.FileSystem.CurrentDirectory + "\Update\SetupAlgodon.zip")
        'ZipFile.CreateFromDirectory(directorioOrigen, directorioZip)
        ZipFile.ExtractToDirectory(directorioZip, directorioOrigen)
        'comprobamos que el archivo existe
        If System.IO.File.Exists(Borrarzip) = True Then
            System.IO.File.Delete(Borrarzip)
        End If
    End Sub
    Private Sub BtActualizar_Click(sender As Object, e As EventArgs) Handles BtActualizar.Click
        ComprobarNuevaActualizacion()
    End Sub
End Class