Create procedure sp_EnviaPacaVenta
@BaleID					 int ,
@IdLiquidacion			 int,
@IdVentaEnc				 int,
@PrecioDls				 float,
@PrecioClase			 float,
@TipoCambio				 float,
@PrecioMxn				 float,
@Kilos					 float,
@Quintales				 float,
@EstatusVentaUpdate		 int,
@EstatusVentaBusqueda	 int
as
update cc
set cc.estatusVenta = @EstatusVentaUpdate,
	cc.IdVentaEnc =							case when @IdVentaEnc = 0			   then NULL ELSE @IdVentaEnc				 END,
	cc.PrecioDls =					  ROUND(case when @PrecioDls = 0			   then NULL ELSE @PrecioDls				 END,4,0),
	cc.PrecioClase =				  ROUND(case when @PrecioClase = 0			   then NULL ELSE @PrecioClase				 END,4,0),
	cc.TipoCambio =					  ROUND(case when @TipoCambio = 0			   then NULL ELSE @TipoCambio				 END,4,0),
	cc.PrecioMxn =					  ROUND(case when @PrecioMxn = 0			   then NULL ELSE @TipoCambio				 END,4,0),
	cc.Kilos =								@kilos,
	cc.Quintales =					  ROUND(@Quintales,4,0)
from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
where cc.FlagTerminado = 1 and cc.estatusVenta = @EstatusVentaBusqueda and pd.FolioCIA = @BaleID and LR.IdLiquidacion = @IdLiquidacion 
