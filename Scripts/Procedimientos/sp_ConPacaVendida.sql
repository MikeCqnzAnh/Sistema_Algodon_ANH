CREATE procedure sp_ConPacaVendida
@IdVentaEnc int ,
@Seleccionar bit = 0 
as
select pd.FolioCIA,
	   cc.IdOrdenTrabajo,
	   LR.IdLiquidacion,
	   Pl.Descripcion,
	   cc.BaleID,
	   pd.Kilos,
	   cc.Grade,
	   ISNULL(cc.castigoMicVenta,0) as castigoMicVenta,
	   ISNULL(cc.CastigoResistenciaFibraVenta,0) as CastigoResistenciaFibraVenta,
	   ISNULL(cc.CastigoLargoFibraVenta,0) as CastigoLargoFibraVenta,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta

		where cc.FlagTerminado =1 and cc.EstatusVenta  = 2 and cc.IdVentaEnc = @IdVentaEnc