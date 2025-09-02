Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class CastigoMicros
    Public Overridable Sub Upsert(ByRef EntidadCastigoMicros As Capa_Entidad.CastigoMicros)
        Dim EntidadCastigoMicros1 As New Capa_Entidad.CastigoMicros
        EntidadCastigoMicros1 = EntidadCastigoMicros
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertaMicrosEncabezado", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadCastigoMicros1.IdMicrosEncabezado))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadCastigoMicros1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@ModoComercializacion", EntidadCastigoMicros1.IdModoComercializacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadCastigoMicros1.IdEstatus))
            cmdGuardar.Parameters("@IdModoEncabezado").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadCastigoMicros1.IdMicrosEncabezado = 0 Then
                EntidadCastigoMicros1.IdMicrosEncabezado = cmdGuardar.Parameters("@IdModoEncabezado").Value
            End If
            For Each MiTableRow As DataRow In EntidadCastigoMicros1.TablaModosDetalle.Rows
                cmdGuardar.CommandText = "sp_InsertaMicrosDetalle"
                cmdGuardar.CommandType = CommandType.StoredProcedure
                cmdGuardar.Parameters.Clear()
                cmdGuardar.Parameters.Add(New SqlParameter("@IdModoDetalle", MiTableRow("IdModoDetalle")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadCastigoMicros1.IdMicrosEncabezado))
                cmdGuardar.Parameters.Add(New SqlParameter("@Rango1", MiTableRow("Rango1")))
                cmdGuardar.Parameters.Add(New SqlParameter("@Rango2", MiTableRow("Rango2")))
                cmdGuardar.Parameters.Add(New SqlParameter("@Castigo", MiTableRow("Castigo")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", MiTableRow("IdEstatus")))
                cmdGuardar.ExecuteNonQuery()
            Next
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCastigoMicros = EntidadCastigoMicros1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadCastigoMicros As Capa_Entidad.CastigoMicros)
        Dim EntidadCastigoMicros1 = New Capa_Entidad.CastigoMicros
        EntidadCastigoMicros1 = EntidadCastigoMicros
        EntidadCastigoMicros1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadCastigoMicros1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEncabezado
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaMicrosEncabezado", cnn)
                    sqldat1.Fill(EntidadCastigoMicros1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("Sp_ConsultaMicrosDetalle", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdMicrosEncabezado", EntidadCastigoMicros1.IdMicrosEncabezado))
                    sqldat1.Fill(EntidadCastigoMicros1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCastigoMicros = EntidadCastigoMicros1
        End Try
    End Sub
End Class
