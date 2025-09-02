CREATE procedure sp_ReporteLiquidacionPacasResumen
--declare
@IdProductor int,
@IdCompra int,
@NombreProductor varchar(80) 
as
select pd.idplantaorigen,
	   LR.IdLiquidacion,
	   lr.IdOrdenTrabajo,
	   lr.TotalHueso,
	   count(HVId.BaleID)as PacasCantidad,
	   count(case when HVId.EstatusCompra = 1 then HVId.BaleID end)  as PacasDisponibles,
	   count(case when HVId.EstatusCompra = 2 then HVId.BaleID end)  as PacasCompradas,
	   sum(pd.Kilos) as PesoPluma,
	   lr.TotalSemilla,
	   @NombreProductor as Nombre
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join HviDetalle HVId 
		on pd.FolioCIA = HVId.BaleID and pd.idordentrabajo = hvid.idordentrabajo left join liquidacionesporromaneaje LR 
		on HVId.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
		where HVId.FlagTerminado = 1 and lr.IdCliente = @IdProductor  and HVId.IdCompraEnc = @IdCompra
		group by pd.idplantaorigen,LR.IdLiquidacion,lr.IdOrdenTrabajo,lr.TotalHueso, lr.TotalSemilla
		having   count(case when HVId.EstatusCompra = 2 then HVId.BaleID end) > 0
