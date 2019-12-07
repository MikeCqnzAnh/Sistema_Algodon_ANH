alter procedure sp_ConLiqProdVendida
--DECLARE
@IdVenta int ,
@Seleccionar bit = 0 
as
select LR.IdLiquidacion,
	   cc.IdOrdenTrabajo,
	   LR.TotalHueso,
	   count(cc.BaleID)as PacasCantidad,
	   count(case when cc.EstatusVenta = 1 then cc.BaleID end)  as PacasDisponibles,
	   count(case when cc.EstatusVenta = 2 then cc.BaleID end)  as PacasVendidas,
	   sum(isnull(CC.Kilos,0)) as PesoPluma,
	   lr.TotalSemilla,
	   @Seleccionar as Seleccionar 
from liquidacionesporromaneaje LR right join CalculoClasificacion CC
on LR.IdOrdenTrabajo = CC.IdOrdenTrabajo
where cc.FlagTerminado = 1 and cc.IdVentaEnc = @IdVenta
		group by LR.IdLiquidacion, cc.IdOrdenTrabajo,lr.TotalHueso, lr.TotalSemilla
		having   count(case when cc.EstatusVenta = 2 then cc.BaleID end) > 0