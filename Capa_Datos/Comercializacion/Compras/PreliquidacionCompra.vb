Imports System.Data.SqlClient
Public Class PreliquidacionCompra
    Public Overridable Sub Consultar(ByRef EntidadPreliquidacionCompra As Capa_Entidad.PreliquidacionCompra)
        Dim EntidadPreliquidacionCompra1 As New Capa_Entidad.PreliquidacionCompra
        EntidadPreliquidacionCompra1 = EntidadPreliquidacionCompra
        EntidadPreliquidacionCompra1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadPreliquidacionCompra1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New SqlCommand("Sp_ConsultaProductorContratoCompra", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@Nombre", EntidadPreliquidacionCompra1.NombreProductor))
                    sqldat1.Fill(EntidadPreliquidacionCompra1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("sp_ConsultaDetalladaClientes", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdCliente", EntidadPreliquidacionCompra1.IdCliente))
                    sqldat1.Fill(EntidadPreliquidacionCompra1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadPreliquidacionCompra = EntidadPreliquidacionCompra1
        End Try
    End Sub
End Class
