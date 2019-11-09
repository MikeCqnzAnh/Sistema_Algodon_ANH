﻿Imports System.Data.SqlClient
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
                Case Capa_Operacion.Configuracion.Reporte.ReporteHviDetalle
                    sqlcom1 = New SqlCommand("Sp_ReporteHviDetalle", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPaquete", EntidadReportes1.IdPaquete))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadReportes1.IdPlanta))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteLotesPorModulo
                    sqlcom1 = New SqlCommand("Sp_ReporteModulosPorLote", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadReportes1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReportePacasPorLote
                    sqlcom1 = New SqlCommand("Sp_ReportePacasPorLote", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadReportes1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReportePacasDetalleAgrupadoPorClase
                    sqlcom1 = New SqlCommand("Sp_ReportePacasPorClases", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadReportes1.IdProductor))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdClase", EntidadReportes1.IdClase))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenProduccion", EntidadReportes1.IdOrdenProduccion))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReportePacasFaltantes
                    sqlcom1 = New SqlCommand("Sp_ConsultaPacasFaltantes", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@RangoInicial", EntidadReportes1.PacaInicial))
                    sqlcom1.Parameters.Add(New SqlParameter("@RangoFinal", EntidadReportes1.PacaFinal))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex)
        Finally
            cnn.Close()
            EntidadReportes = EntidadReportes1
        End Try
    End Sub
    Public Overridable Sub ConsultaCombos(ByRef EntidadReportes As Capa_Entidad.Reportes)
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
                Case Capa_Operacion.Configuracion.Reporte.ReportePacasPorLote
                    sqlcom1 = New SqlCommand("Sp_LlenaComboOrdenTrabajo", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadReportes1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex)
        Finally
            cnn.Close()
            EntidadReportes = EntidadReportes1
        End Try
    End Sub
End Class
