Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class ImportarCatalogos
    Public Overridable Sub Consultar(ByRef EntidadImportarCatalogos As Capa_Entidad.ImportarCatalogos)
        Dim EntidadImportarCatalogos1 As New Capa_Entidad.ImportarCatalogos()
        EntidadImportarCatalogos1 = EntidadImportarCatalogos
        Dim cnn As New SqlConnection(conexionPrincipal)
        EntidadImportarCatalogos1.TablaConsulta = New DataTable()
        EntidadImportarCatalogos1.TablaGeneral = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadImportarCatalogos1.Consulta
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaTablas
                '    sqldat1 = New SqlDataAdapter("Sp_ConsultaRegistrosTabla", cnn)
                '    sqldat1.Fill(EntidadImportarCatalogos1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaBaseDatosReciente
                    '    sqldat1 = New SqlDataAdapter("Sp_ConsultaBDreciente", cnn)
                    '    sqldat1.Fill(EntidadImportarCatalogos1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaInstancia
                    '    Dim servidores As SqlDataSourceEnumerator
                    '    servidores = SqlDataSourceEnumerator.Instance
                    '    EntidadImportarCatalogos1.TablaConsulta = servidores.GetDataSources()
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaTablas
                    '    sqldat1 = New SqlDataAdapter("sp_ListaTablas", cnn)
                    '    sqldat1.Fill(EntidadImportarCatalogos1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaProcedimientos
                    '    sqldat1 = New SqlDataAdapter("sp_listaProcedimientos", cnn)
                    '    sqldat1.Fill(EntidadImportarCatalogos1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaCreateTable
                    '    sqlcom1 = New SqlCommand("sp_GeneraCreateTable", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@NombreTabla", EntidadImportarCatalogos1.Table))
                    '    sqldat1.Fill(EntidadImportarCatalogos1.TablaGeneral)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaTablas
                    sqlcom1 = New SqlCommand("Sp_ConsultaCampos", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreTabla", EntidadImportarCatalogos1.Table))
                    sqldat1.Fill(EntidadImportarCatalogos1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadImportarCatalogos = EntidadImportarCatalogos1
        End Try
    End Sub
    Public Overridable Sub ConsultarBaseExterna(ByRef EntidadImportarCatalogos As Capa_Entidad.ImportarCatalogos)
        Dim EntidadImportarCatalogos1 As New Capa_Entidad.ImportarCatalogos()
        EntidadImportarCatalogos1 = EntidadImportarCatalogos
        Dim cnn As New SqlConnection(conexionMasterExportarRegistros(EntidadImportarCatalogos1.InstanciaDestino, EntidadImportarCatalogos1.BaseDeDatosDestino, EntidadImportarCatalogos1.UsuarioDestino, EntidadImportarCatalogos1.PasswordDestino))
        EntidadImportarCatalogos1.TablaConsulta = New DataTable()
        EntidadImportarCatalogos1.TablaGeneral = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadImportarCatalogos1.Consulta
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaTablas
                '    sqldat1 = New SqlDataAdapter("Sp_ConsultaRegistrosTabla", cnn)
                '    sqldat1.Fill(EntidadImportarCatalogos1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaBaseDatosReciente
                    '    sqldat1 = New SqlDataAdapter("Sp_ConsultaBDreciente", cnn)
                    '    sqldat1.Fill(EntidadImportarCatalogos1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaInstancia
                    '    Dim servidores As SqlDataSourceEnumerator
                    '    servidores = SqlDataSourceEnumerator.Instance
                    '    EntidadImportarCatalogos1.TablaConsulta = servidores.GetDataSources()
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaTablas
                    '    sqldat1 = New SqlDataAdapter("sp_ListaTablas", cnn)
                    '    sqldat1.Fill(EntidadImportarCatalogos1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaProcedimientos
                    '    sqldat1 = New SqlDataAdapter("sp_listaProcedimientos", cnn)
                    '    sqldat1.Fill(EntidadImportarCatalogos1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaCreateTable
                    '    sqlcom1 = New SqlCommand("sp_GeneraCreateTable", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@NombreTabla", EntidadImportarCatalogos1.Table))
                    '    sqldat1.Fill(EntidadImportarCatalogos1.TablaGeneral)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaTablas
                    sqlcom1 = New SqlCommand("Sp_ConsultaRegistrosTabla", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreTabla", EntidadImportarCatalogos1.Table))
                    sqldat1.Fill(EntidadImportarCatalogos1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadImportarCatalogos = EntidadImportarCatalogos1
        End Try
    End Sub
    Public Overridable Sub Importar(ByRef EntidadImportarCatalogos As Capa_Entidad.ImportarCatalogos)
        Dim EntidadImportarCatalogos1 As New Capa_Entidad.ImportarCatalogos()
        EntidadImportarCatalogos1 = EntidadImportarCatalogos
        Dim cnn As New SqlConnection(conexionMasterExportarRegistros(EntidadImportarCatalogos1.InstanciaDestino, EntidadImportarCatalogos1.BaseDeDatosDestino, EntidadImportarCatalogos1.UsuarioDestino, EntidadImportarCatalogos1.PasswordDestino))
        EntidadImportarCatalogos1.TablaConsulta = New DataTable()
        EntidadImportarCatalogos1.TablaGeneral = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadImportarCatalogos1.Importa
                Case Capa_Operacion.Configuracion.Importa.ImportaRegistros
                    sqlcom1 = New SqlCommand("Sp_ExportaRegistros", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@BaseDeDatosOrigen", EntidadImportarCatalogos1.BaseDeDatosOrigen))
                    sqlcom1.Parameters.Add(New SqlParameter("@BaseDeDatosDestino", EntidadImportarCatalogos1.BaseDeDatosDestino))
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreTabla", EntidadImportarCatalogos1.Table))
                    sqlcom1.Parameters.Add(New SqlParameter("@CadenaCampos", EntidadImportarCatalogos1.Campos))
                    sqldat1.Fill(EntidadImportarCatalogos1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadImportarCatalogos = EntidadImportarCatalogos1
        End Try
    End Sub
End Class
