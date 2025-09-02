Imports System.Data.SqlClient
Imports System.IO
Module RespaldosAutomaticos
    Dim CSBuilder As New SqlConnectionStringBuilder
    Sub GeneraJob(ByVal DescripcionJob As String, ByVal NombreJob As String, ByVal FechaInicio As Integer, ByVal HoraInicio As Integer, ByVal BDD As String, ByVal sucededescripcion As String, ByVal IdSucede As Integer, ByVal UsuarioBK As String, ByVal passwordBK As String, ByVal NombreServer As String, ByVal NombreStep As String, ByVal Comando As String, ByVal nombreProgramacion As String)

        With CSBuilder
            .DataSource = NombreServer : .InitialCatalog = BDD : .IntegratedSecurity = False
            .UserID = UsuarioBK : .Password = passwordBK
        End With

        Dim Query As String = "DECLARE @jobId BINARY(16)
        EXEC  msdb.dbo.sp_add_job @job_name=N'" & NombreJob & "', 
		@enabled=1, 
		@notify_level_eventlog=0, 
		@notify_level_email=2, 
		@notify_level_netsend=2, 
		@notify_level_page=2, 
		@delete_level=0, 
		@description=N'Genera respaldo de base de datos " & BDD & " que inicia con fecha " & FechaInicio & " que sucedera " & sucededescripcion & " a las " & HoraInicio & "', 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'" & UsuarioBK & "', @job_id = @jobId OUTPUT"
        Try
            'Creamos la conexión y el comando que ejecutará la consulta 
            Dim Cnx As New SqlConnection(CSBuilder.ConnectionString)
            Dim Cmd As New SqlCommand(Query, Cnx)

            Cnx.Open()
            Cmd.ExecuteNonQuery()

            AddJobServer(NombreJob, NombreServer)
            GeneraStep(NombreJob, NombreStep, Comando, BDD)
            ActualizaJob(NombreJob, DescripcionJob, UsuarioBK)
            Select Case IdSucede
                Case = 1
                    RespaldoDiario(NombreJob, nombreProgramacion, FechaInicio, HoraInicio)
                Case = 2
                    RespaldoSemanal(NombreJob, nombreProgramacion, FechaInicio, HoraInicio)
                Case = 3
                    RespaldoMensual(NombreJob, nombreProgramacion, FechaInicio, HoraInicio)
            End Select

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
    End Sub
    Sub ActualizaJob(ByVal NombreJob As String, ByVal DescripcionJob As String, ByVal UsuarioBK As String)
        Dim Query As String = "EXEC msdb.dbo.sp_update_job @job_name=N'" & NombreJob & "', 
		@enabled=1, 
		@start_step_id=1, 
		@notify_level_eventlog=0, 
		@notify_level_email=2, 
		@notify_level_netsend=2, 
		@notify_level_page=2, 
		@delete_level=0, 
		@description=N'" & DescripcionJob & "', 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'" & UsuarioBK & "', 
		@notify_email_operator_name=N'', 
		@notify_netsend_operator_name=N'', 
		@notify_page_operator_name=N''"

        Try
            'Creamos la conexión y el comando que ejecutará la consulta 
            Dim Cnx As New SqlConnection(CSBuilder.ConnectionString)
            Dim Cmd As New SqlCommand(Query, Cnx)

            Cnx.Open()
            Cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
    End Sub
    Sub AddJobServer(ByVal NombreJob As String, ByVal NombreServer As String)
        Dim Query As String = "EXEC msdb.dbo.sp_add_jobserver @job_name=N'" & NombreJob & "', @server_name = N'" & NombreServer & "'"
        Try
            'Creamos la conexión y el comando que ejecutará la consulta 
            Dim Cnx As New SqlConnection(CSBuilder.ConnectionString)
            Dim Cmd As New SqlCommand(Query, Cnx)

            Cnx.Open()
            Cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
    End Sub
    Sub GeneraStep(ByVal NombreJob As String, ByVal NombreStep As String, ByVal Comando As String, ByVal BDD As String)
        Dim Query As String = "EXEC msdb.dbo.sp_add_jobstep @job_name=N'" & NombreJob & "', @step_name=N'" & NombreStep & "', 
		@step_id=1, 
		@cmdexec_success_code=0, 
		@on_success_action=1, 
		@on_fail_action=2, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'TSQL', 
		@command=N'" & Comando & "', 
		@database_name=N'" & BDD & "', 
		@flags=0"
        Try
            'Creamos la conexión y el comando que ejecutará la consulta 
            Dim Cnx As New SqlConnection(CSBuilder.ConnectionString)
            Dim Cmd As New SqlCommand(Query, Cnx)

            Cnx.Open()
            Cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
    End Sub
    Sub RespaldoDiario(ByVal nombreJob As String, ByVal nombreProgramacion As String, ByVal FechaInicio As Integer, ByVal HoraInicio As Integer)
        Dim Query As String = "DECLARE @schedule_id int
        EXEC msdb.dbo.sp_add_jobschedule @job_name=N'" & nombreJob & "', @name=N'" & nombreProgramacion & "', 
		@enabled=1, 
		@freq_type=4, 
		@freq_interval=1, 
		@freq_subday_type=1, 
		@freq_subday_interval=0, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=1, 
		@active_start_date=" & FechaInicio & ", 
		@active_end_date=99991231, 
		@active_start_time=" & HoraInicio & ", 
		@active_end_time=235959, @schedule_id = @schedule_id OUTPUT"
        Try
            'Creamos la conexión y el comando que ejecutará la consulta 
            Dim Cnx As New SqlConnection(CSBuilder.ConnectionString)
            Dim Cmd As New SqlCommand(Query, Cnx)

            Cnx.Open()
            Cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
    End Sub
    Sub RespaldoSemanal(ByVal nombreJob As String, ByVal nombreProgramacion As String, ByVal FechaInicio As Integer, ByVal HoraInicio As Integer)
        Dim Query As String = "DECLARE @schedule_id int
        EXEC msdb.dbo.sp_add_jobschedule @job_name=N'" & nombreJob & "', @name=N'" & nombreProgramacion & "', 
		@enabled=1, 
		@freq_type=8, 
		@freq_interval=127, 
		@freq_subday_type=1, 
		@freq_subday_interval=0, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=1, 
		@active_start_date=" & FechaInicio & ", 
		@active_end_date=99991231, 
		@active_start_time=" & HoraInicio & ", 
		@active_end_time=235959, @schedule_id = @schedule_id OUTPUT"
        Try
            'Creamos la conexión y el comando que ejecutará la consulta 
            Dim Cnx As New SqlConnection(CSBuilder.ConnectionString)
            Dim Cmd As New SqlCommand(Query, Cnx)

            Cnx.Open()
            Cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
    End Sub
    Sub RespaldoMensual(ByVal nombreJob As String, ByVal nombreProgramacion As String, ByVal FechaInicio As Integer, ByVal HoraInicio As Integer)
        Dim Query As String = "DECLARE @schedule_id int
        EXEC msdb.dbo.sp_add_jobschedule @job_name=N'" & nombreJob & "', @name=N'" & nombreProgramacion & "', 
		@enabled=1, 
		@freq_type=8, 
		@freq_interval=127, 
		@freq_subday_type=1, 
		@freq_subday_interval=0, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=1, 
		@active_start_date=" & FechaInicio & ", 
		@active_end_date=99991231, 
		@active_start_time=" & HoraInicio & ", 
		@active_end_time=235959, @schedule_id = @schedule_id OUTPUT"
        Try
            'Creamos la conexión y el comando que ejecutará la consulta 
            Dim Cnx As New SqlConnection(CSBuilder.ConnectionString)
            Dim Cmd As New SqlCommand(Query, Cnx)

            Cnx.Open()
            Cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
    End Sub
End Module
