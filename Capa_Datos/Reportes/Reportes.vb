Imports System.Data.SqlClient
Public Class Reportes
    Public Overridable Sub Consultar(ByRef EntidadReportes As Capa_Entidad.Reportes)
        Dim EntidadReportes1 As New Capa_Entidad.Reportes
        EntidadReportes1 = EntidadReportes
        EntidadReportes1.TablaConsulta = New DataTable
        EntidadReportes1.TablaGeneral = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadReportes1.Reporte
                'Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                '    sqldat1 = New SqlDataAdapter("sp_ConsultaPlantas", cnn)
                '    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteClientes
                    sqlcom1 = New SqlCommand("sp_RepClientes", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdAsociacion", EntidadReportes1.IdAsociacion))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteContratoCompra
                    sqlcom1 = New SqlCommand("sp_ConsultaContratosDetalleEmpresa", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdContratoAlgodon", EntidadReportes1.IdContratoAlgodon))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteDatosEmpresa
                    sqlcom1 = New SqlCommand("Sp_ConsultaDatosEmpresa", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqldat1.Fill(EntidadReportes1.TablaGeneral)
                Case Capa_Operacion.Configuracion.Reporte.ReporteLiquidacionRomaneaje
                    sqlcom1 = New SqlCommand("Sp_ReporteRomaneajeEnc", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadReportes1.IdOrdenTrabajo))
                    sqlcom1.Parameters.Add(New SqlParameter("@CheckStatus", EntidadReportes1.CheckStatus))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteLiquidacionRomaneajeDet
                    sqlcom1 = New SqlCommand("Sp_ReporteRomaneajeDet", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadReportes1.IdOrdenTrabajo))
                    sqlcom1.Parameters.Add(New SqlParameter("@CheckStatus", EntidadReportes1.CheckStatus))
                    sqldat1.Fill(EntidadReportes1.TablaGeneral)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadReportes = EntidadReportes1
        End Try
    End Sub
End Class
