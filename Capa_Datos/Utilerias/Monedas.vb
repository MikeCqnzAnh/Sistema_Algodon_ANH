Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Monedas
    Public Overridable Sub Consultar(ByRef EntidadMonedas As Capa_Entidad.Monedas)
        Dim EntidadMonedas1 As New Capa_Entidad.Monedas()
        EntidadMonedas1 = EntidadMonedas
        Dim cnn As New SqlConnection(conexionPrincipal)
        EntidadMonedas1.TablaConsulta = New DataTable()
        EntidadMonedas1.TablaGeneral = New DataTable()
        'Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadMonedas1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaMoneda", cnn)
                    sqldat1.Fill(EntidadMonedas1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaBaseDatosReciente
                    '    sqldat1 = New SqlDataAdapter("Sp_ConsultaBDreciente", cnn)
                    '    sqldat1.Fill(EntidadMonedas1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaInstancia
                    '    Dim servidores As SqlDataSourceEnumerator
                    '    servidores = SqlDataSourceEnumerator.Instance
                    '    EntidadMonedas1.TablaConsulta = servidores.GetDataSources()
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaTablas
                    '    sqldat1 = New SqlDataAdapter("sp_ListaTablas", cnn)
                    '    sqldat1.Fill(EntidadMonedas1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaProcedimientos
                    '    sqldat1 = New SqlDataAdapter("sp_listaProcedimientos", cnn)
                    '    sqldat1.Fill(EntidadMonedas1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaCreateTable
                    '    sqlcom1 = New SqlCommand("sp_GeneraCreateTable", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@NombreTabla", EntidadMonedas1.Table))
                    '    sqldat1.Fill(EntidadMonedas1.TablaGeneral)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaCreateProcedure
                    '    sqlcom1 = New SqlCommand("sp_GeneraCreateProcedure", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@NombreProcedimiento", EntidadMonedas1.Procedimiento))
                    '    sqldat1.Fill(EntidadMonedas1.TablaGeneral)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadMonedas = EntidadMonedas1
        End Try
    End Sub
    Public Overridable Sub Eliminar(ByRef EntidadMonedas As Capa_Entidad.Monedas)
        Dim EntidadMonedas1 As New Capa_Entidad.Monedas()
        EntidadMonedas1 = EntidadMonedas
        Dim cnn As New SqlConnection(conexionPrincipal)
        EntidadMonedas1.TablaConsulta = New DataTable()
        EntidadMonedas1.TablaGeneral = New DataTable()
        Dim cmdEliminar As SqlCommand
        'Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadMonedas1.Eliminar
                Case Capa_Operacion.Configuracion.Eliminar.EliminarRegistro
                    cmdEliminar = New SqlCommand("Sp_EliminaMoneda", cnn)
                    cmdEliminar.CommandType = CommandType.StoredProcedure
                    cmdEliminar.Parameters.Clear()
                    cmdEliminar.Parameters.Add(New SqlParameter("@IdMoneda", EntidadMonedas1.IdMoneda))
                    cmdEliminar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadMonedas1.IdEstatus))
                    cmdEliminar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadMonedas1.IdUsuarioActualizacion))
                    cmdEliminar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadMonedas1.FechaActualizacion))
                    cmdEliminar.ExecuteNonQuery()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        Finally
            cnn.Close()
            EntidadMonedas = EntidadMonedas1
        End Try
    End Sub
    Public Overridable Sub Upsert(ByRef EntidadMonedas As Capa_Entidad.Monedas)
        Dim EntidadMonedas1 As New Capa_Entidad.Monedas
        EntidadMonedas1 = EntidadMonedas
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarMonedas", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdMoneda", EntidadMonedas1.IdMoneda))
            cmdGuardar.Parameters.Add(New SqlParameter("@NombreMoneda", EntidadMonedas1.NombreMoneda))
            cmdGuardar.Parameters.Add(New SqlParameter("@Abreviacion", EntidadMonedas1.Abreviacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@TipoDeCambio", EntidadMonedas1.TipoDeCambio))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadMonedas1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadMonedas1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadMonedas1.FechaCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadMonedas1.IdUsuarioActualizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadMonedas1.FechaActualizacion))
            cmdGuardar.Parameters("@IdMoneda").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadMonedas1.IdMoneda = 0 Then
                EntidadMonedas1.IdMoneda = cmdGuardar.Parameters("@IdMoneda").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "Aviso")
        Finally
            cnn.Close()
            EntidadMonedas = EntidadMonedas1
        End Try
    End Sub
End Class
