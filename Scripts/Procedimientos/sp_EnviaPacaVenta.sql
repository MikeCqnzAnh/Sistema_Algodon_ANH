create procedure sp_EnviaPacaVenta
@BaleID					 bigint ,
@IdOrdenTrabajo			 int,
@IdVentaEnc				 int,
@PrecioDls				 decimal(18,4),
@PrecioClase			 decimal(18,4),
@TipoCambio				 decimal(18,4),
@PrecioMxn				 decimal(18,4),
@Kilos					 decimal(18,2),
@Quintales				 decimal(18,4),
@EstatusVentaUpdate		 int,
@EstatusVentaBusqueda	 int
as
update cc
set cc.estatusVenta = @EstatusVentaUpdate,
	cc.IdVentaEnc =							case when @IdVentaEnc = 0			   then NULL ELSE @IdVentaEnc				 END,
	cc.PrecioDls =					  ROUND(case when @PrecioDls = 0			   then NULL ELSE @PrecioDls				 END,4,0),
	cc.PrecioClase =				  ROUND(case when @PrecioClase = 0			   then NULL ELSE @PrecioClase				 END,4,0),
	cc.TipoCambio =					  ROUND(case when @TipoCambio = 0			   then NULL ELSE @TipoCambio				 END,4,0),
	cc.PrecioMxn =					  ROUND(case when @PrecioMxn = 0			   then NULL ELSE @PrecioMxn				 END,4,0),
	cc.Kilos =								@kilos,
	cc.Quintales =					  ROUND(@Quintales,4,0)
from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID and pd.IdOrdenTrabajo = cc.IdOrdenTrabajo left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
where cc.FlagTerminado = 1 and cc.estatusVenta = @EstatusVentaBusqueda and pd.FolioCIA = @BaleID and cc.IdOrdenTrabajo = @IdOrdenTrabajo 
