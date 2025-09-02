Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Public Class RestaurarRespaldo
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\cnn\"
    Dim archivo As String = "cnn.ini"
    Sub LeerArchivo()
        Dim leer As New StreamReader(Ruta & archivo)

        Try
            If File.Exists(Ruta & archivo) Then
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
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    Private Sub RestaurarRespaldo_Load(sender As Object, e As EventArgs) Handles Me.Load
        LeerArchivo()
        TbServidor.Text = Instancia
        TbBDD.Text = BaseDeDatos
        TbUsuario.Text = UsuarioDB
        TbPassword.Text = PasswordDB
    End Sub
    Private Sub btnRestore_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtRestaurar.Click
        Me.BtRestaurar.Enabled = False
        Me.BtRestaurar.Text = "Restaurando..."
        Me.BtRestaurar.Refresh()

        Dim sBackup As String = "RESTORE DATABASE " & Me.TbBDD.Text & vbCrLf &
                                "FROM DISK = '" & Me.TbPath.Text & "'" & vbCrLf &
                                "WITH REPLACE"

        Dim csb As New SqlConnectionStringBuilder
        csb.DataSource = Me.TbServidor.Text
        ' Es mejor abrir la conexión con la base Master'


        csb.InitialCatalog = "master"
        csb.IntegratedSecurity = True

        Using con As New SqlConnection(csb.ConnectionString)
            Try
                con.Open()

                Dim cmdBackUp As New SqlCommand(sBackup, con)
                cmdBackUp.ExecuteNonQuery()
                MessageBox.Show("Se ha restaurado la copia de la base de datos.",
                                "Restaurar base de datos",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                con.Close()
                GeneraRegistroBitacora(Me.Text.Clone.ToString, BtRestaurar.Text, 0, "")
            Catch ex As Exception
                MessageBox.Show(ex.Message,
                                "Error al restaurar la base de datos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Me.BtRestaurar.Text = "Restaurar copia"
        Me.BtRestaurar.Enabled = True
        Me.BtRestaurar.Refresh()

    End Sub
    Private Sub btnSelectDir_Click(sender As Object, e As EventArgs) Handles BtSelectDir.Click
        'Mostramos un cuadro de diálogo para que el usuario seleccione la carpeta donde se guardará el respaldo
        Dim FBD As New OpenFileDialog
        With FBD
            .Filter = "*.bak|*.*"
        End With
        If FBD.ShowDialog() = DialogResult.OK Then
            TbPath.Text = FBD.FileName 'Asignamos la dirección de la carpeta a txtPath
        End If
    End Sub
End Class