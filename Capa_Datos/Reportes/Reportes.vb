Imports System.Data.SqlClient
Public Class Reportes
    Public Overridable Sub Consultar(ByRef EntidadReportes As Capa_Entidad.Reportes)
        Dim EntidadReportes1 As New Capa_Entidad.Reportes
        EntidadReportes1 = EntidadReportes
        EntidadReportes1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadReportes1.Reporte
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                '    sqldat1 = New SqlDataAdapter("sp_ConsultaPlantas", cnn)
                '    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.Clientes
                    sqlcom1 = New SqlCommand("sp_RepClientes", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdAsociacion", EntidadReportes1.IdAsociacion))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ContratoCompra
                    sqlcom1 = New SqlCommand("sp_ConsultaContratosDetalleEmpresa", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdContratoAlgodon", EntidadReportes1.IdContratoAlgodon))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.DatosEmpresa
                    sqlcom1 = New SqlCommand("Sp_ConsultaDatosEmpresa", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqldat1.Fill(EntidadReportes1.TablaGeneral)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaPaca
                    '    sqlcom1 = New SqlCommand("sp_ConsultaProdPorPorOrden", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadProduccion.IdOrdenTrabajo))
                    '    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadReportes = EntidadReportes1
        End Try
    End Sub
End Class
