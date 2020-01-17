Alter procedure sp_ConPacaVendida
--declare
@IdVentaEnc int ,
@Seleccionar bit = 0 
as
select cc.IdPaqueteEncabezado,
	   pd.FolioCIA,
	   cc.IdOrdenTrabajo,
	   LR.IdLiquidacion,
	   pl.Descripcion,
	   cc.BaleID,
	   cc.Kilos,
	   cc.Grade,
	   cc.quintales,
	   cc.PrecioClase,
	   cc.PrecioDls,
	   cc.TipoCambio,
	   cc.PrecioMxn,
	   ISNULL(cc.CastigoUIVenta,0) as CastigoUIVenta,
	   ISNULL(cc.castigoMicVenta,0) as castigoMicVenta,
	   ISNULL(cc.CastigoResistenciaFibraVenta,0) as CastigoResistenciaFibraVenta,
	   ISNULL(cc.CastigoLargoFibraVenta,0) as CastigoLargoFibraVenta,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
		where cc.FlagTerminado =1 and cc.EstatusVenta  = 2 and cc.IdVentaEnc = @IdVentaEnc
		order by cc.IdPaqueteEncabezado