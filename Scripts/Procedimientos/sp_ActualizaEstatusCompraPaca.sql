alter procedure sp_ActualizaEstatusCompraPaca
@IdProductor int ,
@IdPlanta int,
@BaleID bigint ,
@IdLiquidacion int,
@IdCompraEnc int,
@PrecioDls float,
@PrecioClase FLOAT,
@TipoCambio float,
@PrecioMxn float,
@CastigoUniformidad float,
@CastigoResistenciaFibra float,
@CastigoMicros float,
@CastigoLargoFibra float,
@EstatusCompraUpdate int,
@EstatusCompraBusqueda int
as
update hd
set hd.estatuscompra = @EstatusCompraUpdate ,
	hd.IdCompraEnc =   case when @IdCompraEnc = 0 then NULL ELSE @IdCompraEnc END,
	hd.PrecioDls =round(case when @PrecioDls = 0 then NULL ELSE @PrecioDls END,4,0),
	hd.PrecioClase = case when @PrecioClase = 0 then NULL ELSE @PrecioClase END,
	hd.TipoCambio = case when @TipoCambio = 0 then NULL ELSE @TipoCambio END,
	hd.PrecioMxn =round( case when @PrecioMxn = 0 then NULL ELSE @TipoCambio END,4,0),
	hd.CastigoUICompra = round(case when @CastigoUniformidad = 0 then NULL ELSE @CastigoUniformidad END,4,0),
	hd.CastigoResistenciaFibraCompra = round(  case when @CastigoResistenciaFibra = 0 then NULL ELSE @CastigoResistenciaFibra END,4,0),
	hd.castigoMicCompra =  round( case when @CastigoMicros = 0 then NULL ELSE @CastigoMicros END,4,0),
	hd.CastigoLargoFibraCompra = round(  case when @CastigoLargoFibra = 0 then NULL ELSE @CastigoLargoFibra END,4,0)
from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join HviDetalle hd 
		on pd.FolioCIA = hd.BaleID and pd.IdOrdenTrabajo = hd.IdOrdenTrabajo left join liquidacionesporromaneaje LR 
		on hd.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
where pr.IdCliente = @IdProductor and hd.FlagTerminado =1 and hd.EstatusCompra  = @EstatusCompraBusqueda and pd.FolioCIA = @BaleID and LR.IdLiquidacion = @IdLiquidacion and hd.IdPlantaOrigen = @IdPlanta 
