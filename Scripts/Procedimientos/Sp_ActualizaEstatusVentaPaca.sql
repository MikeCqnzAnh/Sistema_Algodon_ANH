alter procedure sp_ActualizaEstatusVentaPaca
--@IdComprador			 int ,
@BaleID					 bigint ,
@IdLiquidacion			 int,
@IdVentaEnc				 int,
--@PrecioDls				 float,
--@PrecioClase			 float,
@TipoCambio				 float,
@PrecioMxn				 float,
--@Kilos					 float,
--@Quintales				 float,
@CastigoResistenciaFibra float,
@CastigoMicros			 float,
@CastigoLargoFibra		 float,
@CastigoUI				 float,
@CastigoBarkLevel1		 float,
@CastigoBarkLevel2		 float,
@CastigoPrepLevel1		 float,
@CastigoPrepLevel2		 float,
@CastigoOtherLevel1		 float,
@CastigoOtherLevel2		 float,
@CastigoPlasticLevel1	 float,
@CastigoPlasticLevel2	 float
--@EstatusVentaUpdate		 int,
--@EstatusVentaBusqueda	 int
as
update cc
set --cc.estatusVenta = @EstatusVentaUpdate ,
	--cc.IdVentaEnc =							case when @IdVentaEnc = 0			   then NULL ELSE @IdVentaEnc				 END,
	--cc.PrecioDls =					  ROUND(case when @PrecioDls = 0			   then null ELSE @PrecioDls				 END,4,0),
	--cc.PrecioClase =				  ROUND(case when @PrecioClase = 0			   then NULL ELSE @PrecioClase				 END,4,0),
	cc.TipoCambio =					  ROUND(case when @TipoCambio = 0			   then NULL ELSE @TipoCambio				 END,4,0),
	cc.PrecioMxn =					  ROUND(case when @PrecioMxn = 0			   then NULL ELSE @TipoCambio				 END,4,0),
	cc.CastigoResistenciaFibraVenta = ROUND(case when @CastigoResistenciaFibra = 0 then NULL ELSE @CastigoResistenciaFibra	 END,4,0),
	cc.castigoMicVenta =			  ROUND(case when @CastigoMicros = 0		   then NULL ELSE @CastigoMicros			 END,4,0),
	cc.CastigoLargoFibraVenta =		  ROUND(case when @CastigoLargoFibra = 0	   then NULL ELSE @CastigoLargoFibra		 END,4,0),
	cc.CastigoUIVenta =				  ROUND(case when @CastigoUI = 0			   then NULL ELSE @CastigoUI				 END,4,0),
	cc.CastigoBarkLevel1Venta =		  ROUND(case when @CastigoBarkLevel1 = 0 	   then NULL ELSE @CastigoBarkLevel1		 END,4,0),
	cc.CastigoBarkLevel2Venta =		  ROUND(case when @CastigoBarkLevel2 = 0	   then NULL ELSE @CastigoBarkLevel2		 END,4,0),
	cc.CastigoPrepLevel1Venta =		  ROUND(case when @CastigoPrepLevel1 = 0	   then NULL ELSE @CastigoPrepLevel1		 END,4,0),
	cc.CastigoPrepLevel2Venta =		  ROUND(case when @CastigoPrepLevel2 = 0	   then NULL ELSE @CastigoPrepLevel2		 END,4,0),
	cc.CastigoOtherLevel1Venta =	  ROUND(case when @CastigoOtherLevel1 = 0	   then NULL ELSE @CastigoOtherLevel1		 END,4,0),
	cc.CastigoOtherLevel2Venta =	  ROUND(case when @CastigoOtherLevel2 = 0	   then NULL ELSE @CastigoOtherLevel2		 END,4,0),
	cc.CastigoPlasticLevel1Venta =	  ROUND(case when @CastigoPlasticLevel1 = 0    then NULL ELSE @CastigoPlasticLevel1		 END,4,0),
	cc.CastigoPlasticLevel2Venta =	  ROUND(case when @CastigoPlasticLevel2 = 0	   then NULL ELSE @CastigoPlasticLevel2		 END,4,0)
	--cc.Kilos =								@kilos,
	--cc.Quintales =					  ROUND(@Quintales,4,0)
from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
where pd.FolioCIA = @BaleID and LR.IdLiquidacion = @IdLiquidacion and cc.IdVentaEnc = @IdVentaEnc
