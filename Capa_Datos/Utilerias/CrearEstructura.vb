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
        Dim cnn As New SqlConnection(conexionMasterExportar(EntidadCrearEstructura.Instancia, EntidadCrearEstructura.Usuario, EntidadCrearEstructura.Password))
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
        Dim cnn As New SqlConnection(conexionMasterExportar(EntidadCrearEstructura.Instancia, EntidadCrearEstructura.BaseDeDatos, EntidadCrearEstructura.Usuario, EntidadCrearEstructura.Password))
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
            'cmdGuardar.Parameters("@NOMBREBDD").Direction = ParameterDirection.InputOutput
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
        Dim cnn As New SqlConnection(conexionMasterExportar(EntidadCrearEstructura.Instancia, EntidadCrearEstructura.BaseDeDatos, EntidadCrearEstructura.Usuario, EntidadCrearEstructura.Password))
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
    Public Function GeneraCreateTable(ByVal CreateTable As String)

        Dim ConsultaSQL As String = "DECLARE @table_name SYSNAME
SELECT @table_name = 'dbo.'+''" & CreateTable & "

DECLARE 
      @object_name SYSNAME
    , @object_id INT

SELECT 
      @object_name = '[' + s.name + '].[' + o.name + ']'
    , @object_id = o.[object_id]
FROM sys.objects o WITH (NOWAIT)
JOIN sys.schemas s WITH (NOWAIT) ON o.[schema_id] = s.[schema_id]
WHERE s.name + '.' + o.name = @table_name
    AND o.[type] = 'U'
    AND o.is_ms_shipped = 0

DECLARE @SQL NVARCHAR(MAX) = ''

;WITH index_column AS 
(
    SELECT 
          ic.[object_id]
        , ic.index_id
        , ic.is_descending_key
        , ic.is_included_column
        , c.name
    FROM sys.index_columns ic WITH (NOWAIT)
    JOIN sys.columns c WITH (NOWAIT) ON ic.[object_id] = c.[object_id] AND ic.column_id = c.column_id
    WHERE ic.[object_id] = @object_id
),
fk_columns AS 
(
     SELECT 
          k.constraint_object_id
        , cname = c.name
        , rcname = rc.name
    FROM sys.foreign_key_columns k WITH (NOWAIT)
    JOIN sys.columns rc WITH (NOWAIT) ON rc.[object_id] = k.referenced_object_id AND rc.column_id = k.referenced_column_id 
    JOIN sys.columns c WITH (NOWAIT) ON c.[object_id] = k.parent_object_id AND c.column_id = k.parent_column_id
    WHERE k.parent_object_id = @object_id
)
SELECT @SQL = 'CREATE TABLE ' + @object_name + CHAR(13) + '(' + CHAR(13) + STUFF((
    SELECT CHAR(9) + ', [' + c.name + '] ' + 
        CASE WHEN c.is_computed = 1
            THEN 'AS ' + cc.[definition] 
            ELSE UPPER(tp.name) + 
                CASE WHEN tp.name IN ('varchar', 'char', 'varbinary', 'binary', 'text')
                       THEN '(' + CASE WHEN c.max_length = -1 THEN 'MAX' ELSE CAST(c.max_length AS VARCHAR(5)) END + ')'
                     WHEN tp.name IN ('nvarchar', 'nchar', 'ntext')
                       THEN '(' + CASE WHEN c.max_length = -1 THEN 'MAX' ELSE CAST(c.max_length / 2 AS VARCHAR(5)) END + ')'
                     WHEN tp.name IN ('datetime2', 'time2', 'datetimeoffset') 
                       THEN '(' + CAST(c.scale AS VARCHAR(5)) + ')'
                     WHEN tp.name = 'decimal' 
                       THEN '(' + CAST(c.[precision] AS VARCHAR(5)) + ',' + CAST(c.scale AS VARCHAR(5)) + ')'
                    ELSE ''
                END +
                CASE WHEN c.collation_name IS NOT NULL THEN ' COLLATE ' + c.collation_name ELSE '' END +
                CASE WHEN c.is_nullable = 1 THEN ' NULL' ELSE ' NOT NULL' END +
                CASE WHEN dc.[definition] IS NOT NULL THEN ' DEFAULT' + dc.[definition] ELSE '' END + 
                CASE WHEN ic.is_identity = 1 THEN ' IDENTITY(' + CAST(ISNULL(ic.seed_value, '0') AS CHAR(1)) + ',' + CAST(ISNULL(ic.increment_value, '1') AS CHAR(1)) + ')' ELSE '' END 
        END + CHAR(13)
    FROM sys.columns c WITH (NOWAIT)
    JOIN sys.types tp WITH (NOWAIT) ON c.user_type_id = tp.user_type_id
    LEFT JOIN sys.computed_columns cc WITH (NOWAIT) ON c.[object_id] = cc.[object_id] AND c.column_id = cc.column_id
    LEFT JOIN sys.default_constraints dc WITH (NOWAIT) ON c.default_object_id != 0 AND c.[object_id] = dc.parent_object_id AND c.column_id = dc.parent_column_id
    LEFT JOIN sys.identity_columns ic WITH (NOWAIT) ON c.is_identity = 1 AND c.[object_id] = ic.[object_id] AND c.column_id = ic.column_id
    WHERE c.[object_id] = @object_id
    ORDER BY c.column_id
    FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, CHAR(9) + ' ')
    + ISNULL((SELECT CHAR(9) + ', CONSTRAINT [' + k.name + '] PRIMARY KEY (' + 
                    (SELECT STUFF((
                         SELECT ', [' + c.name + '] ' + CASE WHEN ic.is_descending_key = 1 THEN 'DESC' ELSE 'ASC' END
                         FROM sys.index_columns ic WITH (NOWAIT)
                         JOIN sys.columns c WITH (NOWAIT) ON c.[object_id] = ic.[object_id] AND c.column_id = ic.column_id
                         WHERE ic.is_included_column = 0
                             AND ic.[object_id] = k.parent_object_id 
                             AND ic.index_id = k.unique_index_id     
                         FOR XML PATH(N''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ''))
            + ')' + CHAR(13)
            FROM sys.key_constraints k WITH (NOWAIT)
            WHERE k.parent_object_id = @object_id 
                AND k.[type] = 'PK'), '') + ')'  + CHAR(13)
    + ISNULL((SELECT (
        SELECT CHAR(13) +
             'ALTER TABLE ' + @object_name + ' WITH' 
            + CASE WHEN fk.is_not_trusted = 1 
                THEN ' NOCHECK' 
                ELSE ' CHECK' 
              END + 
              ' ADD CONSTRAINT [' + fk.name  + '] FOREIGN KEY(' 
              + STUFF((
                SELECT ', [' + k.cname + ']'
                FROM fk_columns k
                WHERE k.constraint_object_id = fk.[object_id]
                FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '')
               + ')' +
              ' REFERENCES [' + SCHEMA_NAME(ro.[schema_id]) + '].[' + ro.name + '] ('
              + STUFF((
                SELECT ', [' + k.rcname + ']'
                FROM fk_columns k
                WHERE k.constraint_object_id = fk.[object_id]
                FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '')
               + ')'
            + CASE 
                WHEN fk.delete_referential_action = 1 THEN ' ON DELETE CASCADE' 
                WHEN fk.delete_referential_action = 2 THEN ' ON DELETE SET NULL'
                WHEN fk.delete_referential_action = 3 THEN ' ON DELETE SET DEFAULT' 
                ELSE '' 
              END
            + CASE 
                WHEN fk.update_referential_action = 1 THEN ' ON UPDATE CASCADE'
                WHEN fk.update_referential_action = 2 THEN ' ON UPDATE SET NULL'
                WHEN fk.update_referential_action = 3 THEN ' ON UPDATE SET DEFAULT'  
                ELSE '' 
              END 
            + CHAR(13) + 'ALTER TABLE ' + @object_name + ' CHECK CONSTRAINT [' + fk.name  + ']' + CHAR(13)
        FROM sys.foreign_keys fk WITH (NOWAIT)
        JOIN sys.objects ro WITH (NOWAIT) ON ro.[object_id] = fk.referenced_object_id
        WHERE fk.parent_object_id = @object_id
        FOR XML PATH(N''), TYPE).value('.', 'NVARCHAR(MAX)')), '')
    + ISNULL(((SELECT
         CHAR(13) + 'CREATE' + CASE WHEN i.is_unique = 1 THEN ' UNIQUE' ELSE '' END 
                + ' NONCLUSTERED INDEX [' + i.name + '] ON ' + @object_name + ' (' +
                STUFF((
                SELECT ', [' + c.name + ']' + CASE WHEN c.is_descending_key = 1 THEN ' DESC' ELSE ' ASC' END
                FROM index_column c
                WHERE c.is_included_column = 0
                    AND c.index_id = i.index_id
                FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '') + ')'  
                + ISNULL(CHAR(13) + 'INCLUDE (' + 
                    STUFF((
                    SELECT ', [' + c.name + ']'
                    FROM index_column c
                    WHERE c.is_included_column = 1
                        AND c.index_id = i.index_id
                    FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '') + ')', '')  + CHAR(13)
        FROM sys.indexes i WITH (NOWAIT)
        WHERE i.[object_id] = @object_id
            AND i.is_primary_key = 0
            AND i.[type] = 2
        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)')
    ), '')

select @SQL as Rutina"
        Return CreateTable
    End Function
End Class
