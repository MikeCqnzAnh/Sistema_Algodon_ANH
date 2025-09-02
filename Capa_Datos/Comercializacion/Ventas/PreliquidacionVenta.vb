Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class PreliquidacionVenta
    Public Overridable Sub Consultar(ByRef EntidadPreliquidacionVenta As Capa_Entidad.PreliquidacionVenta)
        Dim EntidadPreliquidacionVenta1 As New Capa_Entidad.PreliquidacionVenta
        EntidadPreliquidacionVenta1 = EntidadPreliquidacionVenta
        EntidadPreliquidacionVenta1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadPreliquidacionVenta1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New SqlCommand("Sp_ConsultaProductorContratoCompra", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreComprador", EntidadPreliquidacionVenta1.NombreComprador))
                    sqldat1.Fill(EntidadPreliquidacionVenta1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("sp_ConsultaDetalladaClientes", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdComprador", EntidadPreliquidacionVenta1.IdComprador))
                    sqldat1.Fill(EntidadPreliquidacionVenta1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadPreliquidacionVenta = EntidadPreliquidacionVenta1
        End Try
    End Sub
End Class
