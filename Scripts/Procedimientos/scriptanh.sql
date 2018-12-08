--CREATE procedure sp_ConPacProdDetCla
----declare
--@IdProductor int ,
--@Seleccionar bit = 0 
--as
select LR.IdLiquidacion,
	   lr.TotalHueso,
	   count(cc.BaleID)as PacasCantidad,
	   sum(pd.Kilos) as PesoPluma,
	   COUNT(cc.BaleID) as PacasCompradas
	   --@Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
	where cc.FlagTerminado =1 and cc.EstatusCompra  = 1 and lr.IdCliente = 1005 
		group by LR.IdLiquidacion,lr.TotalHueso
	




