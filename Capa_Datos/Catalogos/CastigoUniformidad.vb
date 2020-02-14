Imports System.Data.SqlClient
Public Class CastigoUniformidad
    Public Overridable Sub Upsert(ByRef EntidadCastigoUniformidad As Capa_Entidad.CastigoUniformidad)
        Dim EntidadCastigoUniformidad1 As New Capa_Entidad.CastigoUniformidad
        EntidadCastigoUniformidad1 = EntidadCastigoUniformidad
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertaUniformidadEncabezado", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadCastigoUniformidad1.IdUnidormidadEncabezado))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadCastigoUniformidad1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@ModoComercializacion", EntidadCastigoUniformidad1.IdModoComercializacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadCastigoUniformidad1.IdEstatus))
            cmdGuardar.Parameters("@IdModoEncabezado").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadCastigoUniformidad1.IdUnidormidadEncabezado = 0 Then
                EntidadCastigoUniformidad1.IdUnidormidadEncabezado = cmdGuardar.Parameters("@IdModoEncabezado").Value
            End If
            For Each MiTableRow As DataRow In EntidadCastigoUniformidad1.TablaModosDetalle.Rows
                cmdGuardar.CommandText = "sp_InsertaUniformidadDetalle"
                cmdGuardar.CommandType = CommandType.StoredProcedure
                cmdGuardar.Parameters.Clear()
                cmdGuardar.Parameters.Add(New SqlParameter("@IdModoDetalle", MiTableRow("IdModoDetalle")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadCastigoUniformidad1.IdUnidormidadEncabezado))
                cmdGuardar.Parameters.Add(New SqlParameter("@Rango1", MiTableRow("Rango1")))
                cmdGuardar.Parameters.Add(New SqlParameter("@Rango2", MiTableRow("Rango2")))
                cmdGuardar.Parameters.Add(New SqlParameter("@Castigo", MiTableRow("Castigo")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", MiTableRow("IdEstatus")))
                cmdGuardar.ExecuteNonQuery()
            Next
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCastigoUniformidad = EntidadCastigoUniformidad1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadCastigoUniformidad As Capa_Entidad.CastigoUniformidad)
        Dim EntidadCastigoUniformidad1 = New Capa_Entidad.CastigoUniformidad
        EntidadCastigoUniformidad1 = EntidadCastigoUniformidad
        EntidadCastigoUniformidad1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadCastigoUniformidad1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEncabezado
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaUniformidadEncabezado", cnn)
                    sqldat1.Fill(EntidadCastigoUniformidad1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("Sp_ConsultaUniformidadDetalle", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdUniformidadEncabezado", EntidadCastigoUniformidad1.IdUnidormidadEncabezado))
                    sqldat1.Fill(EntidadCastigoUniformidad1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCastigoUniformidad = EntidadCastigoUniformidad1
        End Try
    End Sub
End Class
