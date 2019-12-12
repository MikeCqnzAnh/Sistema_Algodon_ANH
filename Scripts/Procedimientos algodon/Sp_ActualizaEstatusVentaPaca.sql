CREATE procedure sp_ActualizaEstatusVentaPaca
@IdComprador int ,
@BaleID int ,
@IdLiquidacion int,
@IdVentaEnc int,
@CastigoResistenciaFibra float,
@CastigoMicros float,
@CastigoLargoFibra float,
@EstatusVentaUpdate int,
@EstatusVentaBusqueda int
as
update cc
set cc.estatusVenta = @EstatusVentaUpdate ,
	cc.IdVentaEnc =   case when @IdVentaEnc = 0 then NULL ELSE @IdVentaEnc END,
	cc.CastigoResistenciaFibraVenta =   case when @CastigoResistenciaFibra = 0 then NULL ELSE @CastigoResistenciaFibra END,
	cc.castigoMicVenta =   case when @CastigoMicros = 0 then NULL ELSE @CastigoMicros END,
	cc.CastigoLargoFibraVenta =   case when @CastigoLargoFibra = 0 then NULL ELSE @CastigoLargoFibra END
from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
where cc.FlagTerminado =1 and cc.estatusVenta  = @EstatusVentaBusqueda and pd.FolioCIA = @BaleID and LR.IdLiquidacion = @IdLiquidacion


