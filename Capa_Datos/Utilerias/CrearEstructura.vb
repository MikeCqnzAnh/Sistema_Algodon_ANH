Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class CrearEstructura
    Dim InicioSentencia As String = "IF EXISTS (SELECT * FROM  sys.objects WHERE object_id = OBJECT_ID(N'"
    Dim FinSentenciaTabla As String = "') AND type IN ( N'U') ) "
    Dim FinSentenciaProc As String = "') AND type IN ( N'P') ) "
    Dim DropTable As String = "DROP TABLE "
    Dim DropProcedure As String = "DROP PROCEDURE "

    Public Overridable Sub Consultar(ByRef EntidadCrearEstructura As Capa_Entidad.CrearEstructura)
        Dim EntidadCrearEstructura1 As New Capa_Entidad.CrearEstructura()
        EntidadCrearEstructura1 = EntidadCrearEstructura
        Dim cnn As New SqlConnection(conexionPrincipal)
        EntidadCrearEstructura1.TablaConsulta = New DataTable()
        EntidadCrearEstructura1.TablaGeneral = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadCrearEstructura1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBaseDatos
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaBdd", cnn)
                    sqldat1.Fill(EntidadCrearEstructura1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBaseDatosReciente
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaBDreciente", cnn)
                    sqldat1.Fill(EntidadCrearEstructura1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaInstancia
                    Dim servidores As SqlDataSourceEnumerator
                    servidores = SqlDataSourceEnumerator.Instance
                    EntidadCrearEstructura1.TablaConsulta = servidores.GetDataSources()
                Case Capa_Operacion.Configuracion.Consulta.ConsultaTablas
                    sqldat1 = New SqlDataAdapter("sp_ListaTablas", cnn)
                    sqldat1.Fill(EntidadCrearEstructura1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaProcedimientos
                    sqldat1 = New SqlDataAdapter("sp_listaProcedimientos", cnn)
                    sqldat1.Fill(EntidadCrearEstructura1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCreateTable
                    sqlcom1 = New SqlCommand("sp_GeneraCreateTable", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreTabla", EntidadCrearEstructura1.Table))
                    sqldat1.Fill(EntidadCrearEstructura1.TablaGeneral)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCreateProcedure
                    sqlcom1 = New SqlCommand("sp_GeneraCreateProcedure", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreProcedimiento", EntidadCrearEstructura1.Procedimiento))
                    sqldat1.Fill(EntidadCrearEstructura1.TablaGeneral)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCrearEstructura = EntidadCrearEstructura1
        End Try
    End Sub
    Public Overridable Sub ConsultarDB(ByRef EntidadCrearEstructura As Capa_Entidad.CrearEstructura)
        Dim EntidadCrearEstructura1 As New Capa_Entidad.CrearEstructura()
        EntidadCrearEstructura1 = EntidadCrearEstructura
        Dim cnn As New SqlConnection(conexionMasterExportarEstructura(EntidadCrearEstructura.Instancia, EntidadCrearEstructura.Usuario, EntidadCrearEstructura.Password))
        EntidadCrearEstructura1.TablaConsulta = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadCrearEstructura1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaInstancia
                    Dim selectSQL As String = “select name from sys.databases where name like '%Algodon%';”
                    sqldat1 = New SqlDataAdapter(selectSQL, cnn)
                    sqldat1.Fill(EntidadCrearEstructura1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCrearEstructura = EntidadCrearEstructura1
        End Try
    End Sub
    Public Overridable Sub Importa(ByRef EntidadCrearEstructura As Capa_Entidad.CrearEstructura)
        Dim EntidadCrearEstructura1 As New Capa_Entidad.CrearEstructura()
        EntidadCrearEstructura1 = EntidadCrearEstructura
        Dim cnn As New SqlConnection(conexionMasterExportarRegistros(EntidadCrearEstructura.Instancia, EntidadCrearEstructura.BaseDeDatos, EntidadCrearEstructura.Usuario, EntidadCrearEstructura.Password))
        EntidadCrearEstructura1.TablaConsulta = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadCrearEstructura1.Importa
                Case Capa_Operacion.Configuracion.Importa.ImportaTabla
                    Dim Sentencia As String = InicioSentencia & EntidadCrearEstructura1.Table & FinSentenciaTabla & DropTable & EntidadCrearEstructura1.Table
                    sqlcom1 = New SqlCommand(Sentencia, cnn)
                    sqlcom1.ExecuteNonQuery()
                    Sentencia = EntidadCrearEstructura1.Rutina
                    sqlcom1 = New SqlCommand(Sentencia, cnn)
                    sqlcom1.ExecuteNonQuery()
                Case Capa_Operacion.Configuracion.Importa.ImportaProcedimiento
                    Dim Sentencia As String = InicioSentencia & EntidadCrearEstructura1.Procedimiento & FinSentenciaProc & DropProcedure & EntidadCrearEstructura1.Procedimiento
                    sqlcom1 = New SqlCommand(Sentencia, cnn)
                    sqlcom1.ExecuteNonQuery()
                    Sentencia = EntidadCrearEstructura1.Rutina
                    sqlcom1 = New SqlCommand(Sentencia, cnn)
                    sqlcom1.ExecuteNonQuery()
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCrearEstructura = EntidadCrearEstructura1
        End Try
    End Sub
    Public Overridable Sub Upsert(ByRef EntidadCrearEstructura As Capa_Entidad.CrearEstructura)
        Dim EntidadCrearEstructura1 As New Capa_Entidad.CrearEstructura
        EntidadCrearEstructura1 = EntidadCrearEstructura
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_CreaBdd", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@NOMBREBDD", EntidadCrearEstructura1.BaseDeDatos))
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCrearEstructura = EntidadCrearEstructura1
        End Try
    End Sub
    Public Overridable Sub UpsertEstructura(ByRef EntidadCrearEstructura As Capa_Entidad.CrearEstructura)
        Dim EntidadCrearEstructura1 As New Capa_Entidad.CrearEstructura
        EntidadCrearEstructura1 = EntidadCrearEstructura
        Dim cnn As New SqlConnection(conexionMasterExportarRegistros(EntidadCrearEstructura.Instancia, EntidadCrearEstructura.BaseDeDatos, EntidadCrearEstructura.Usuario, EntidadCrearEstructura.Password))
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_CreaBdd", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@NOMBREBDD", EntidadCrearEstructura1.BaseDeDatos))
            'cmdGuardar.Parameters("@NOMBREBDD").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCrearEstructura = EntidadCrearEstructura1
        End Try
    End Sub
End Class
