Create procedure sp_ActualizaEstatusCompraPaca
@IdProductor int ,
@IdPlanta int,
@IdPaquete int,
@BaleID int ,
@IdLiquidacion int,
@IdCompraEnc int,
@CastigoResistenciaFibra float,
@CastigoMicros float,
@CastigoLargoFibra float,
@EstatusCompraUpdate int,
@EstatusCompraBusqueda int
as
update cc
set cc.estatuscompra = @EstatusCompraUpdate ,
	cc.IdCompraEnc =   case when @IdCompraEnc = 0 then NULL ELSE @IdCompraEnc END,
	cc.CastigoResistenciaFibraCompra =   case when @CastigoResistenciaFibra = 0 then NULL ELSE @CastigoResistenciaFibra END,
	cc.castigoMicCompra =   case when @CastigoMicros = 0 then NULL ELSE @CastigoMicros END,
	cc.CastigoLargoFibraCompra =   case when @CastigoLargoFibra = 0 then NULL ELSE @CastigoLargoFibra END
from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
where pr.IdCliente = @IdProductor and cc.FlagTerminado =1 and cc.EstatusCompra  = @EstatusCompraBusqueda and pd.FolioCIA = @BaleID and LR.IdLiquidacion = @IdLiquidacion and cc.IdPlantaOrigen = @IdPlanta and cc.IdPaqueteEncabezado = @Idpaquete


