Alter procedure sp_ConLiqProdVendida
--DECLARE
@IdVenta int ,
@Seleccionar bit = 0 
as
select cc.IdPaqueteEncabezado,
	   --LR.IdLiquidacion,
	   --cc.IdOrdenTrabajo,
	   sum(LR.TotalHueso) as TotalHueso,
	   count(cc.BaleID)as PacasCantidad,
	   count(case when cc.EstatusVenta = 1 then cc.BaleID end)  as PacasDisponibles,
	   count(case when cc.EstatusVenta = 2 then cc.BaleID end)  as PacasVendidas,
	   sum(isnull(CC.Kilos,0)) as PesoPluma,
	   sum(lr.TotalSemilla) as TotalSemilla,
	   @Seleccionar as Seleccionar 
from liquidacionesporromaneaje LR right join CalculoClasificacion CC
on LR.IdOrdenTrabajo = CC.IdOrdenTrabajo
where cc.FlagTerminado = 1 and cc.IdVentaEnc = @IdVenta
		group by cc.IdPaqueteEncabezado
		having   count(case when cc.EstatusVenta = 2 then cc.BaleID end) > 0
		order by cc.IdPaqueteEncabezado