Imports System.Data.SqlClient
Imports System.IO
Public Class ProgramarRespaldos
    Private Enum Estado_Conexion
        NoComprobada
        Establecida
        NoEstablecida
    End Enum
    Dim EC As Estado_Conexion
    Dim CSBuilder As New SqlConnectionStringBuilder
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\cnn\"
    Dim archivo As String = "cnn.ini"
    Sub LeerArchivo()
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

        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    Private Sub ProgramarRespaldos_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbpruebahora.Text = TimeValue(DtFechaInicio.Value)
        TbFechaPrueba.Text = Now.Date
        lblDBName.Text = "..."
        lblDBSize.Text = "..."
        lblUnallocatedSize.Text = "..."
        LeerArchivo()
        TbServidor.Text = Instancia
        TbBDD.Text = BaseDeDatos
        TbUsuario.Text = UsuarioDB
        TbPassword.Text = PasswordDB
        CargaCombo()
    End Sub
    Private Sub CargaCombo()
        Dim dt As DataTable = New DataTable("Tabla")
        Dim dr As DataRow
        dt.Columns.Add("ID")
        dt.Columns.Add("Descripcion")

        dr = dt.NewRow()
        dr("ID") = 1
        dr("Descripcion") = "Diario"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("ID") = 2
        dr("Descripcion") = "Semanal"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("ID") = 3
        dr("Descripcion") = "Mensual"
        dt.Rows.Add(dr)

        CbFrecuencia.DataSource = dt
        CbFrecuencia.ValueMember = "ID"
        CbFrecuencia.DisplayMember = "Descripcion"
        CbFrecuencia.MaxDropDownItems = 8
        CbFrecuencia.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub btnSelectDir_Click(sender As Object, e As EventArgs) Handles BtSelectDir.Click
        'Mostramos un cuadro de diálogo para que el usuario seleccione la carpeta donde se guardará el respaldo
        Dim FBD As New FolderBrowserDialog
        If FBD.ShowDialog() = DialogResult.OK Then
            TbPath.Text = FBD.SelectedPath 'Asignamos la dirección de la carpeta a txtPath
        End If
    End Sub
    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles BtPruebaConexion.Click

        'Deshabilitamos btnTestConnection durante la prueba e informamos
        BtPruebaConexion.Enabled = False
        lblConnStatus.Text = "Comprobando la conexión..."
        lblConnStatus.Refresh()

        'Construimos la cadena de conexión
        With CSBuilder
            .DataSource = TbServidor.Text : .InitialCatalog = TbBDD.Text : .IntegratedSecurity = False
            .UserID = TbUsuario.Text : .Password = TbPassword.Text
        End With

        Dim Cnx As New SqlConnection(CSBuilder.ConnectionString)

        Try
            'Intentamos establecer conexión con el servidor de datos.
            'Si no hay errores, cambiamos la información del estado de la conexión.
            'Y habilitamos las opciones de respaldo
            Cnx.Open()
            EC = Estado_Conexion.Establecida
            pbConnStatus.BackgroundImage = My.Resources.light_green
            lblConnStatus.Text = "Conexión establecida exitosamente."

            'Ahora obtenemos la información de la base de datos ejecutando el procedimiento almacenado sp_spaceused
            Dim Cmd As New SqlCommand("sp_spaceused", Cnx)
            Cmd.CommandType = CommandType.StoredProcedure

            Dim Dt As New DataTable
            Dim Da As SqlDataAdapter = New SqlDataAdapter(Cmd)

            Da.Fill(Dt)

            Dim Dr As DataRow = Dt.Rows.Item(0)

            lblDBName.Text = Dr.Item("database_name").ToString.Trim
            lblDBSize.Text = Dr.Item("database_size").ToString.Trim
            lblUnallocatedSize.Text = Dr.Item("unallocated space").ToString.Trim

            BtSelectDir.Enabled = True
            TbBackupName.Enabled = True

        Catch ex As Exception

            'Mostramos los errores que se hayan presentado y cambiamos el estado de la conexión
            MessageBox.Show(ex.Message, "Error en la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Opcional
            EC = Estado_Conexion.NoEstablecida
            pbConnStatus.BackgroundImage = My.Resources.light_red
            lblConnStatus.Text = "Error en la conexión"

        Finally

            BtPruebaConexion.Enabled = True
            Cnx.Close()

        End Try

    End Sub
    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btBackup.Click

        'Verificamos que la conexión sea válida
        If EC = Estado_Conexion.Establecida Then

            'Deshabilitando el botón btnBackup durante el respaldo
            btBackup.Text = "Respaldando..."
            btBackup.Enabled = False
            btBackup.Refresh()

            'Variable de texto que contiene la consulta de respaldo a ejecutarse en el servidor
            Dim Query As String = "BACKUP DATABASE " & TbBDD.Text.Trim & "
                                TO DISK = '" & TbPath.Text & "\" & TbBackupName.Text & ".bak'
                                   WITH FORMAT,
                                      MEDIANAME = '" & TbBackupName.Text & "',
                                      NAME = '" & TbBackupName.Text & "'"
            Try
                Dim descripcionJob As String = "Genera respaldo de base de datos " & TbBDD.Text & " que inicia con fecha " & Now.Date & " que sucedera " & CbFrecuencia.Text & " a las " & Hour(DtFechaInicio.Value) & ""
                Dim NombreJob As String = "JobBK"
                'GeneraJob(descripcionJob, NombreJob,)

                MessageBox.Show("Se ha respaldado la base de datos correctamente.", "Respaldo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally

                btBackup.Text = "Respaldar"
                btBackup.Enabled = True

            End Try
        Else
            MessageBox.Show("No se ha establecido ninguna conexión con el servidor de datos.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

    End Sub
End Class