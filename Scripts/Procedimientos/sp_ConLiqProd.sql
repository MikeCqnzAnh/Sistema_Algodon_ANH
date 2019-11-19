CREATE procedure sp_ConLiqProd
--declare
@IdProductor int ,
@Seleccionar bit = 0 
as
select LR.IdLiquidacion,
	   lr.TotalHueso,
	   count(hvid.BaleID)as PacasCantidad,
	   count(case when hvid.EstatusCompra = 1 then hvid.BaleID end)  as PacasDisponibles,
	   count(case when hvid.EstatusCompra = 2 then hvid.BaleID end)  as PacasCompradas,
	   sum(pd.Kilos) as PesoPluma,
	   lr.TotalSemilla,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join HviDetalle hvid 
		on pd.FolioCIA = hvid.BaleID left join liquidacionesporromaneaje LR 
		on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
		where hvid.FlagTerminado = 1 and lr.IdCliente = @IdProductor 
		group by LR.IdLiquidacion,lr.TotalHueso, lr.TotalSemilla
		having   count(case when hvid.EstatusCompra = 2 then hvid.BaleID end) < Count(hvid.BaleID)