CREATE procedure sp_ConLiqProdVendida
--declare
@Seleccionar bit = 0 
as
select LR.IdLiquidacion,
	   lr.TotalHueso,
	   count(cc.BaleID)as PacasCantidad,
	   count(case when cc.EstatusVenta = 1 then cc.BaleID end)  as PacasDisponibles,
	   count(case when cc.EstatusVenta = 2 then cc.BaleID end)  as PacasVendidas,
	   sum(pd.Kilos) as PesoPluma,
	   lr.TotalSemilla,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
		where cc.FlagTerminado = 1 
		group by LR.IdLiquidacion,lr.TotalHueso, lr.TotalSemilla
		having   count(case when cc.EstatusVenta = 2 then cc.BaleID end) > 0