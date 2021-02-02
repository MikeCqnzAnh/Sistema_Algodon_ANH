Imports System.Data.SqlClient
Public Class IntegraciondeCompras
    Public Overridable Sub Consultar(ByRef EntidadIntegraciondeCompras As Capa_Entidad.IntegraciondeCompras)
        Dim EntidadIntegraciondeCompras1 As New Capa_Entidad.IntegraciondeCompras
        EntidadIntegraciondeCompras1 = EntidadIntegraciondeCompras
        EntidadIntegraciondeCompras1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadIntegraciondeCompras1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New SqlCommand("Sp_ConsultaProductorContratoCompra", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@UUID", EntidadIntegraciondeCompras1.UUID))
                    sqldat1.Fill(EntidadIntegraciondeCompras1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    '    sqlcom1 = New SqlCommand("sp_ConsultaDetalladaClientes", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@IdCliente", EntidadIntegraciondeCompras1.IdCliente))
                    '    sqldat1.Fill(EntidadIntegraciondeCompras1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadIntegraciondeCompras = EntidadIntegraciondeCompras1
        End Try
    End Sub
End Class
