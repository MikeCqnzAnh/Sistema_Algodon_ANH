CREATE procedure sp_ActualizaEstatusCompraPaca
@IdProductor int ,
@IdPlanta int,
@BaleID int ,
@IdLiquidacion int,
@IdCompraEnc int,
@PrecioDls float,
@TipoCambio float,
@PrecioMxn float,
@CastigoResistenciaFibra float,
@CastigoMicros float,
@CastigoLargoFibra float,
@EstatusCompraUpdate int,
@EstatusCompraBusqueda int
as
update hd
set hd.estatuscompra = @EstatusCompraUpdate ,
	hd.IdCompraEnc =   case when @IdCompraEnc = 0 then NULL ELSE @IdCompraEnc END,
	hd.PrecioDls = case when @PrecioDls = 0 then NULL ELSE @PrecioDls END,
	hd.TipoCambio = case when @TipoCambio = 0 then NULL ELSE @TipoCambio END,
	hd.PrecioMxn = case when @PrecioMxn = 0 then NULL ELSE @TipoCambio END,
	hd.CastigoResistenciaFibraCompra =   case when @CastigoResistenciaFibra = 0 then NULL ELSE @CastigoResistenciaFibra END,
	hd.castigoMicCompra =   case when @CastigoMicros = 0 then NULL ELSE @CastigoMicros END,
	hd.CastigoLargoFibraCompra =   case when @CastigoLargoFibra = 0 then NULL ELSE @CastigoLargoFibra END
from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join HviDetalle hd 
		on pd.FolioCIA = hd.BaleID left join liquidacionesporromaneaje LR 
		on hd.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
where pr.IdCliente = @IdProductor and hd.FlagTerminado =1 and hd.EstatusCompra  = @EstatusCompraBusqueda and pd.FolioCIA = @BaleID and LR.IdLiquidacion = @IdLiquidacion and hd.IdPlantaOrigen = @IdPlanta 