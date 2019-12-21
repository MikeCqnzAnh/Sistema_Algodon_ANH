Imports System.Data.SqlClient
Public Class ModalidadesVenta
    Public Overridable Sub Upsert(ByRef EntidadModalidadesVenta As Capa_Entidad.ModalidadesVenta)
        Dim EntidadModalidadesVenta1 As New Capa_Entidad.ModalidadesVenta
        EntidadModalidadesVenta1 = EntidadModalidadesVenta
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertaModoVentaEncabezado", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadModalidadesVenta1.IdModoEncabezado))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadModalidadesVenta1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadModalidadesVenta1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadModalidadesVenta1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadModalidadesVenta1.FechaCreacion))
            cmdGuardar.Parameters("@IdModoEncabezado").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadModalidadesVenta1.IdModoEncabezado = 0 Then
                EntidadModalidadesVenta1.IdModoEncabezado = cmdGuardar.Parameters("@IdModoEncabezado").Value
            End If
            For Each MiTableRow As DataRow In EntidadModalidadesVenta1.TablaClasesClasificacion.Rows
                cmdGuardar.CommandText = "sp_InsertaModoVentaDetalle"
                cmdGuardar.CommandType = CommandType.StoredProcedure
                cmdGuardar.Parameters.Clear()
                cmdGuardar.Parameters.Add(New SqlParameter("@IdModoDetalle", MiTableRow("IdModoDetalle")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadModalidadesVenta1.IdModoEncabezado))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdClasificacion", MiTableRow("IdClasificacion")))
                cmdGuardar.Parameters.Add(New SqlParameter("@Diferencial", MiTableRow("Diferencial")))
                cmdGuardar.ExecuteNonQuery()
            Next
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadModalidadesVenta = EntidadModalidadesVenta1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadModalidadesVenta As Capa_Entidad.ModalidadesVenta)
        Dim EntidadModalidadesVenta1 = New Capa_Entidad.ModalidadesVenta
        EntidadModalidadesVenta1 = EntidadModalidadesVenta
        EntidadModalidadesVenta1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadModalidadesVenta1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaModosVentaEncabezado", cnn)
                    sqldat1.Fill(EntidadModalidadesVenta1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaClases
                    sqldat1 = New SqlDataAdapter("sp_ConsultaClasesClasificacion", cnn)
                    sqldat1.Fill(EntidadModalidadesVenta1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaClasesDetalle
                    sqlcom1 = New SqlCommand("sp_ConsultaDetalleModoVenta", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdModoEncabezado", EntidadModalidadesVenta1.IdModoEncabezado))
                    sqldat1.Fill(EntidadModalidadesVenta1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadModalidadesVenta = EntidadModalidadesVenta1
        End Try
    End Sub
End Class
