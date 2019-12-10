alter procedure sp_ConPacVentDet
--declare
@Seleccionar bit = 0 
as
select pd.FolioCIA,
	   cc.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   cc.BaleID,
	   pd.Kilos,
	   cc.Grade,
	   isnull(cc.quintales,0) as quintales,
	   isnull(cc.PrecioClase,0) as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.TipoCambio,0) as TipoCambio,
	   isnull(cc.PrecioMxn,0) as PrecioMxn,
	   cc.UI as Uniformidad,
	   cc.Mic as Micros,
	   cc.Strength as Resistencia,
	   cc.UHML as Largo,
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
		where cc.FlagTerminado =1 and cc.EstatusVenta  = 1 and lr.IdLiquidacion is not null
		order by cc.IdOrdenTrabajo, cc.BaleID