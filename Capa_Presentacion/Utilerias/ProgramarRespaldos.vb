Imports System.Data.SqlClient
Imports System.IO
Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
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
        lblDBName.Text = "..."
        lblDBSize.Text = "..."
        lblUnallocatedSize.Text = "..."
        TbPath.Text = ""
        EC = Estado_Conexion.NoEstablecida
        pbConnStatus.BackgroundImage = My.Resources.light_yellow
        LeerArchivo()
        TbServidor.Text = Instancia
        TbBDD.Text = BaseDeDatos
        TbUsuario.Text = UsuarioDB
        TbPassword.Text = PasswordDB
        CargaCombo()
        ConsultaJobs()
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
    Private Function Fechabdd(ByVal ValorFecha As DateTime) As Integer
        Dim resultado As Integer
        Dim year As String = ValorFecha.ToString("yyyy")
        Dim day As String = ValorFecha.ToString("dd")
        Dim month As String = ValorFecha.ToString("MM")
        resultado = year & month & day
        Return resultado
    End Function
    Private Function Horabdd(ByVal ValorFecha As DateTime) As Integer
        Dim resultado As Integer
        Dim hour As String = ValorFecha.ToString("HH")
        Dim min As String = ValorFecha.ToString("mm")
        Dim sec As String = ValorFecha.ToString("ss")
        resultado = hour & min & sec
        Return resultado
    End Function
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

        Catch ex As Exception

            'Mostramos los errores que se hayan presentado y cambiamos el estado de la conexión
            MessageBox.Show(ex.Message, "Error en la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Opcional
            EC = Estado_Conexion.NoEstablecida
            pbConnStatus.BackgroundImage = My.Resources.light_red
            lblConnStatus.Text = "Error en la conexión"

        Finally

            BtPruebaConexion.Enabled = True
            btBackup.Enabled = True
            Cnx.Close()

        End Try

    End Sub
    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btBackup.Click
        If CbFrecuencia.Text <> "" And TbPath.Text <> "" Then
            'Verificamos que la conexión sea válida
            If EC = Estado_Conexion.Establecida Then
                'Deshabilitando el botón btnBackup durante el respaldo
                btBackup.Text = "Respaldando..."
                btBackup.Enabled = False
                btBackup.Refresh()
                GeneraRespaldo()
            Else
                MessageBox.Show("No se ha establecido ninguna conexión con el servidor de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Else
            MessageBox.Show("Todos los campos son requeridos para continuar, favor de revisar para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub
    Private Sub GeneraRespaldo()
        Dim Query As String = "Declare @dbname NVARCHAR(1024)
    Set	@dbname =  ''" & TbBDD.Text.Trim & "''

-- Set the name of the archive backup directory.
Declare @bakdir VARCHAR(300)
    Set	@bakdir = ''" & TbPath.Text & "''

-- Create the name of the backup file from the database name And the current date.
Declare @bakname VARCHAR(300)
    Set	@bakname = @dbname + ''_backup_'' + REPLACE(CONVERT(VARCHAR(20), GETDATE(), 112) + CONVERT(VARCHAR(20), GETDATE(), 108),'':'','''')

-- Set the name of the backup file.
Declare @filename VARCHAR(300)
    Set	@filename = @bakdir + ''\'' + @bakname+''.bak''

-- Create the directories if necessary.
EXECUTE	master.dbo.xp_create_subdir @bakdir
BACKUP DATABASE @dbname
TO  DISK =@filename
With FORMAT, 
INIT,  
MEDIANAME = @bakname,  
NAME = @bakname, 
SKIP, NOREWIND, NOUNLOAD,  STATS = 10"

        Try
            Dim descripcionJob As String = "Genera respaldo de base de datos " & TbBDD.Text & " que inicia con fecha " & Now.Date & " que sucedera " & CbFrecuencia.Text & " a las " & DtHoraInicio.Value.ToShortTimeString & ""
            Dim NombreJob As String = "JobBK" & TbBDD.Text.Trim & Now.Day & Now.Month & Now.Year
            Dim NombreStep As String = "StepBK" & TbBDD.Text.Trim & Now.Day & Now.Month & Now.Year
            Dim NombreProg As String = "ProgBK" & TbBDD.Text.Trim & Now.Day & Now.Month & Now.Year
            GeneraJob(descripcionJob, NombreJob, Fechabdd(Now.Date), Horabdd(DtHoraInicio.Value), TbBDD.Text.Trim, CbFrecuencia.Text, CbFrecuencia.SelectedValue, TbUsuario.Text, TbPassword.Text, TbServidor.Text, NombreStep, Query, NombreProg)

            MessageBox.Show("Se ha creado la tarea de respaldo programado con exito.", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GeneraRegistroBitacora(Me.Text.Clone.ToString, btBackup.Text, 0, descripcionJob)
            ConsultaJobs()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btBackup.Text = "Respaldar"
            btBackup.Enabled = True
        End Try
    End Sub
    Private Sub ConsultaJobs()
        Dim EntidadProgramarRespaldos As New Capa_Entidad.ProgramarRespaldos
        Dim NegocioProgramarRespaldos As New Capa_Negocio.ProgramarRespaldos
        Dim Tabla As New DataTable
        EntidadProgramarRespaldos.Consulta = Consulta.ConsultaBasica
        NegocioProgramarRespaldos.Consultar(EntidadProgramarRespaldos)
        Tabla = EntidadProgramarRespaldos.TablaConsulta
        DgvJobsActivos.Columns.Clear()
        DgvJobsActivos.DataSource = EntidadProgramarRespaldos.TablaConsulta
        ParametrosDgv()
    End Sub
    Private Sub ParametrosDgv()
        DgvJobsActivos.Columns("name").HeaderText = "Nombre"
        DgvJobsActivos.Columns("date_created").HeaderText = "Fecha Creacion"
        DgvJobsActivos.Columns("date_modified").Visible = False
        DgvJobsActivos.Columns("step_id").Visible = False
        DgvJobsActivos.Columns("step_name").Visible = False
        DgvJobsActivos.Columns("description").HeaderText = "Descripcion"
        DgvJobsActivos.Columns("last_run_date").HeaderText = "Ultima Ejecucion Fecha"
        DgvJobsActivos.Columns("last_run_time").HeaderText = "Ultima Ejecucion Hora"
    End Sub
End Class