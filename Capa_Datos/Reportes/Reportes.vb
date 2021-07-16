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
                    sqlcom1.CommandTimeout = 0
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@RangoInicial", EntidadReportes1.PacaInicial))
                    sqlcom1.Parameters.Add(New SqlParameter("@RangoFinal", EntidadReportes1.PacaFinal))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReportePacasDetallado
                    sqlcom1 = New SqlCommand("Sp_ReporteDetalladoPacas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadReportes1.IdProductor))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdClase", EntidadReportes1.IdClase))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenProduccion", EntidadReportes1.IdOrdenProduccion))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteCompraPacasResumen
                    sqlcom1 = New SqlCommand("Sp_ReporteCompraPacaResumen", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdCompra", EntidadReportes1.IdCompra))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteVentaPacasResumen
                    sqlcom1 = New SqlCommand("Sp_ReporteVentaResumen", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdVenta", EntidadReportes1.IdVenta))
                    sqlcom1.Parameters.Add(New SqlParameter("@Estatus", EntidadReportes1.CheckStatus))
                    sqlcom1.Parameters.Add(New SqlParameter("@Tara", EntidadReportes1.Tara))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteCompraPacasDetallado
                    sqlcom1 = New SqlCommand("Sp_ReporteCompraPacaDetalle", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdCompra", EntidadReportes1.IdCompra))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteVentaPacasDetallado
                    sqlcom1 = New SqlCommand("Sp_ReporteVentaPacaDetalle", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdVenta", EntidadReportes1.IdVenta))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReportePaquetesVenta
                    sqlcom1 = New SqlCommand("Sp_ReportePaquetesVenta", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPaquete", EntidadReportes1.IdPaquete))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@CantidadPacas", EntidadReportes1.CantidadPacas))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdComprador", EntidadReportes1.IdComprador))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdClase", EntidadReportes1.IdClase))
                    sqlcom1.Parameters.Add(New SqlParameter("@Mayor", EntidadReportes1.Mayor))
                    sqlcom1.Parameters.Add(New SqlParameter("@Menor", EntidadReportes1.Menor))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteClasesVenta
                    sqlcom1 = New SqlCommand("Sp_ConsultaClasesVenta", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPaquete", EntidadReportes1.IdPaquete))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteVentaHVI
                    sqlcom1 = New SqlCommand("Sp_ReporteVentaHVI", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdVenta", EntidadReportes1.IdVenta))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteVentaPacasExcel
                    sqlcom1 = New SqlCommand("sp_ReporteVentapaqueteExcel", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdVenta", EntidadReportes1.IdVenta))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteVentaDetalleCastigo
                    sqlcom1 = New SqlCommand("Sp_ReporteVentaDetalleCastigo", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdVenta", EntidadReportes1.IdVenta))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReportePaquetePorVenta
                    sqlcom1 = New SqlCommand("Pa_ConsultaPaquetesVenta", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdVenta", EntidadReportes1.IdVenta))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteOrdenEmbarque
                    sqlcom1 = New SqlCommand("Sp_ConsultaReporteOrdenEmbarque", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@HabilitaKilos", EntidadReportes1.CheckStatus))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadReportes1.IdEmbarqueEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@NoLote", EntidadReportes1.NoLote))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteDisponibilidadPacasProductor
                    sqlcom1 = New SqlCommand("Sp_ConsultaDisponibilidadPacasProductor", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReportePesosSalidaPacas
                    sqlcom1 = New SqlCommand("Sp_ReportePesosSalida", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdSalidaPacas", EntidadReportes1.IdSalidaPacas))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdComprador", EntidadReportes1.IdComprador))
                    sqlcom1.Parameters.Add(New SqlParameter("@HabilitaCampos", EntidadReportes1.CheckStatus))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReportePacasSinVender
                    sqlcom1 = New SqlCommand("Sp_ConsultaPacasSinVender", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@Valor", EntidadReportes1.Valor))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@Clase", EntidadReportes1.Clase))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReportePacasSinComprar
                    sqlcom1 = New SqlCommand("Sp_ConsultaPacasSinComprar", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@Valor", EntidadReportes1.Valor))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@Clase", EntidadReportes1.Clase))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteResumenLiquidacion
                    sqlcom1 = New SqlCommand("sp_ReporteLiquidacionPacasResumen", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadReportes1.IdProductor))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdCompra", EntidadReportes1.IdCompra))
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreProductor", EntidadReportes1.Nombre))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteResumenLiqGeneral
                    sqlcom1 = New SqlCommand("Sp_ReporteResumenLiquidacion", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadReportes1.IdProductor))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@Desde", EntidadReportes1.Desde))
                    sqlcom1.Parameters.Add(New SqlParameter("@Hasta", EntidadReportes1.Hasta))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteResumenProduccion
                    sqlcom1 = New SqlCommand("Sp_ResumenProduccion", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadReportes1.IdOrdenTrabajo))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadReportes1.IdProductor))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@Fechaini", EntidadReportes1.FechaIni))
                    sqlcom1.Parameters.Add(New SqlParameter("@Fechafin", EntidadReportes1.FechaFin))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteCompras
                    sqlcom1 = New SqlCommand("Pa_ConsultaCompras", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadReportes1.IdOrdenTrabajo))
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadReportes1.IdProductor))
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    'sqlcom1.Parameters.Add(New SqlParameter("@Fechaini", EntidadReportes1.FechaIni))
                    'sqlcom1.Parameters.Add(New SqlParameter("@Fechafin", EntidadReportes1.FechaFin))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteVentas
                    sqlcom1 = New SqlCommand("Pa_ConsultaVentas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadReportes1.IdOrdenTrabajo))
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadReportes1.IdProductor))
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    'sqlcom1.Parameters.Add(New SqlParameter("@Fechaini", EntidadReportes1.FechaIni))
                    'sqlcom1.Parameters.Add(New SqlParameter("@Fechafin", EntidadReportes1.FechaFin))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteExistenciasResumen
                    sqlcom1 = New SqlCommand("Pa_ConsultaExistencias", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReporteExistenciasDetalle
                    sqlcom1 = New SqlCommand("Pa_ConsultaExistenciasDetallado", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdCompra", EntidadReportes1.IdCompra))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPaqVenta", EntidadReportes1.IdPaquete))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdVenta", EntidadReportes1.IdVenta))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarque", EntidadReportes1.IdEmbarqueEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdSalida", EntidadReportes1.IdSalidaPacas))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdComprador", EntidadReportes1.IdComprador))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadReportes1.IdProductor))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@CkCompradas", EntidadReportes1.SoloCompradas))
                    sqlcom1.Parameters.Add(New SqlParameter("@CksinComprar", EntidadReportes1.SoloSinComprar))
                    sqlcom1.Parameters.Add(New SqlParameter("@CkVendidas", EntidadReportes1.SoloVendidas))
                    sqlcom1.Parameters.Add(New SqlParameter("@CkSinVender", EntidadReportes1.SoloSinVender))
                    sqlcom1.Parameters.Add(New SqlParameter("@CkEmbarque", EntidadReportes1.SoloEmbarques))
                    sqlcom1.Parameters.Add(New SqlParameter("@CkSinEmbarque", EntidadReportes1.SoloSinEmbarques))
                    sqlcom1.Parameters.Add(New SqlParameter("@CkSalidas", EntidadReportes1.SoloSalidas))
                    sqlcom1.Parameters.Add(New SqlParameter("@CkExistencias", EntidadReportes1.SoloSinSalida))

                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReportePacaDetalleCompra
                    sqlcom1 = New SqlCommand("Pa_ConsultaPacaDetallesCompra", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@FolioCia", EntidadReportes1.FolioCia))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadReportes1.IdOrdenTrabajo))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdLiquidacion", EntidadReportes1.IdLiquidacionRomaneaje))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdCompra", EntidadReportes1.IdCompra))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@LotID", EntidadReportes1.LotID))
                    sqlcom1.Parameters.Add(New SqlParameter("@Inicio", EntidadReportes1.Desde))
                    sqlcom1.Parameters.Add(New SqlParameter("@Fin", EntidadReportes1.Hasta))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Reporte.ReportePacaDetalleVenta
                    sqlcom1 = New SqlCommand("Pa_ConsultaPacaDetallesVenta", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@FolioCia", EntidadReportes1.FolioCia))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadReportes1.IdOrdenTrabajo))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdLiquidacion", EntidadReportes1.IdLiquidacionRomaneaje))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdVenta", EntidadReportes1.IdVenta))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlanta", EntidadReportes1.IdPlanta))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdSalida", EntidadReportes1.IdSalidaPacas))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarque", EntidadReportes1.IdEmbarqueEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@NoLote", EntidadReportes1.NoLote))
                    sqlcom1.Parameters.Add(New SqlParameter("@PacaInicial", EntidadReportes1.PacaInicial))
                    sqlcom1.Parameters.Add(New SqlParameter("@PacaFinal", EntidadReportes1.PacaFinal))
                    sqldat1.Fill(EntidadReportes1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadReportes = EntidadReportes1
        End Try
    End Sub
    Public Overridable Sub Upsert(ByRef EntidadReportes As Capa_Entidad.Reportes)
        Dim EntidadReportes1 As New Capa_Entidad.Reportes
        EntidadReportes1 = EntidadReportes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Sp_CursorResultadosProduccion", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
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
