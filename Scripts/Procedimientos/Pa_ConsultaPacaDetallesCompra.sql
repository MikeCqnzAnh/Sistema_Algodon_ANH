alter Procedure Pa_ConsultaPacaDetallesCompra
@FolioCia bigint,
@IdOrdenTrabajo int,
@IdLiquidacion int,
@IdCompra int,
@IdPlanta int
as
if @FolioCia > 0 
begin
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(hvid.LotID,0) as LotID,
	   isnull(hvid.IdCompraEnc,0) as IdCompra,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(HviD.Kilos,0),2)  as KilosCompra,
	   ISNULL(hvid.Grade,'S/C') as Grade,
	   ISNULL(HviD.quintales,0) as Quintales,
	   ROUND(ISNULL(HviD.PrecioClase,0),2) as PrecioClase,
	   ISNULL(hvid.PrecioDls,0) as PrecioDls,
	   ISNULL(hvid.UI,0) as Uniformidad,
	   ISNULL(hvid.Mic,0) as Micros,
	   ISNULL(hvid.Strength,0) as Resistencia,
	   ISNULL(hvid.UHML,0) as Largo,
	   ISNULL(hvid.CastigoUICompra,0) as CastigoUICompra,
	   ISNULL(hvid.castigoMicCompra,0) as CastigoMicCompra,
	   ISNULL(hvid.CastigoResistenciaFibraCompra,0) as CastigoResistenciaFibraCompra,
	   ISNULL(hvid.CastigoLargoFibraCompra,0) as CastigoLargoFibraCompra,
	   isnull(hvid.CastigoBarkLevel1Compra,0) as CastigoBarkLevel1Compra, 
       isnull(hvid.CastigoBarkLevel2Compra,0) as CastigoBarkLevel2Compra,
       isnull(hvid.CastigoPrepLevel1Compra,0) as CastigoPrepLevel1Compra,
       isnull(hvid.CastigoPrepLevel2Compra,0) as CastigoPrepLevel2Compra,
       isnull(hvid.CastigoOtherLevel1Compra,0) as CastigoOtherLevel1Compra,
       isnull(hvid.CastigoOtherLevel2Compra,0) as CastigoOtherLevel2Compra,
       isnull(hvid.CastigoPlasticLevel1Compra,0) as CastigoPlasticLevel1Compra,
       isnull(hvid.CastigoPlasticLevel2Compra,0) as CastigoPlasticLevel2Compra
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       full join HviDetalle hvid on pd.FolioCIA = hvid.BaleID and pd.IdOrdenTrabajo = hvid.IdOrdenTrabajo
						   full join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		where pd.FolioCIA= @FolioCia
		order by LR.IdLiquidacion, pd.FolioCIA
end
else if @IdOrdenTrabajo > 0
begin
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(hvid.LotID,0) as LotID,
	   isnull(hvid.IdCompraEnc,0) as IdCompra,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(HviD.Kilos,0),2)  as KilosCompra,
	   ISNULL(hvid.Grade,'S/C') as Grade,
	   ISNULL(HviD.quintales,0) as Quintales,
	   ROUND(ISNULL(HviD.PrecioClase,0),2) as PrecioClase,
	   ISNULL(hvid.PrecioDls,0) as PrecioDls,
	   ISNULL(hvid.UI,0) as Uniformidad,
	   ISNULL(hvid.Mic,0) as Micros,
	   ISNULL(hvid.Strength,0) as Resistencia,
	   ISNULL(hvid.UHML,0) as Largo,
	   ISNULL(hvid.CastigoUICompra,0) as CastigoUICompra,
	   ISNULL(hvid.castigoMicCompra,0) as CastigoMicCompra,
	   ISNULL(hvid.CastigoResistenciaFibraCompra,0) as CastigoResistenciaFibraCompra,
	   ISNULL(hvid.CastigoLargoFibraCompra,0) as CastigoLargoFibraCompra,
	   isnull(hvid.CastigoBarkLevel1Compra,0) as CastigoBarkLevel1Compra, 
       isnull(hvid.CastigoBarkLevel2Compra,0) as CastigoBarkLevel2Compra,
       isnull(hvid.CastigoPrepLevel1Compra,0) as CastigoPrepLevel1Compra,
       isnull(hvid.CastigoPrepLevel2Compra,0) as CastigoPrepLevel2Compra,
       isnull(hvid.CastigoOtherLevel1Compra,0) as CastigoOtherLevel1Compra,
       isnull(hvid.CastigoOtherLevel2Compra,0) as CastigoOtherLevel2Compra,
       isnull(hvid.CastigoPlasticLevel1Compra,0) as CastigoPlasticLevel1Compra,
       isnull(hvid.CastigoPlasticLevel2Compra,0) as CastigoPlasticLevel2Compra
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       full join HviDetalle hvid on pd.FolioCIA = hvid.BaleID and pd.IdOrdenTrabajo = hvid.IdOrdenTrabajo
						   full join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		where pd.IdOrdenTrabajo= @IdOrdenTrabajo
		order by LR.IdLiquidacion, pd.FolioCIA
end
else if @IdLiquidacion > 0
begin
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(hvid.LotID,0) as LotID,
	   isnull(hvid.IdCompraEnc,0) as IdCompra,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(HviD.Kilos,0),2)  as KilosCompra,
	   ISNULL(hvid.Grade,'S/C') as Grade,
	   ISNULL(HviD.quintales,0) as Quintales,
	   ROUND(ISNULL(HviD.PrecioClase,0),2) as PrecioClase,
	   ISNULL(hvid.PrecioDls,0) as PrecioDls,
	   ISNULL(hvid.UI,0) as Uniformidad,
	   ISNULL(hvid.Mic,0) as Micros,
	   ISNULL(hvid.Strength,0) as Resistencia,
	   ISNULL(hvid.UHML,0) as Largo,
	   ISNULL(hvid.CastigoUICompra,0) as CastigoUICompra,
	   ISNULL(hvid.castigoMicCompra,0) as CastigoMicCompra,
	   ISNULL(hvid.CastigoResistenciaFibraCompra,0) as CastigoResistenciaFibraCompra,
	   ISNULL(hvid.CastigoLargoFibraCompra,0) as CastigoLargoFibraCompra,
	   isnull(hvid.CastigoBarkLevel1Compra,0) as CastigoBarkLevel1Compra, 
       isnull(hvid.CastigoBarkLevel2Compra,0) as CastigoBarkLevel2Compra,
       isnull(hvid.CastigoPrepLevel1Compra,0) as CastigoPrepLevel1Compra,
       isnull(hvid.CastigoPrepLevel2Compra,0) as CastigoPrepLevel2Compra,
       isnull(hvid.CastigoOtherLevel1Compra,0) as CastigoOtherLevel1Compra,
       isnull(hvid.CastigoOtherLevel2Compra,0) as CastigoOtherLevel2Compra,
       isnull(hvid.CastigoPlasticLevel1Compra,0) as CastigoPlasticLevel1Compra,
       isnull(hvid.CastigoPlasticLevel2Compra,0) as CastigoPlasticLevel2Compra
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       full join HviDetalle hvid on pd.FolioCIA = hvid.BaleID and pd.IdOrdenTrabajo = hvid.IdOrdenTrabajo
						   full join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		where LR.IdLiquidacion= @IdLiquidacion
		order by LR.IdLiquidacion, pd.FolioCIA
end
else
begin
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(hvid.LotID,0) as LotID,
	   isnull(hvid.IdCompraEnc,0) as IdCompra,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(HviD.Kilos,0),2)  as KilosCompra,
	   ISNULL(hvid.Grade,'S/C') as Grade,
	   ISNULL(HviD.quintales,0) as Quintales,
	   ROUND(ISNULL(HviD.PrecioClase,0),2) as PrecioClase,
	   ISNULL(hvid.PrecioDls,0) as PrecioDls,
	   ISNULL(hvid.UI,0) as Uniformidad,
	   ISNULL(hvid.Mic,0) as Micros,
	   ISNULL(hvid.Strength,0) as Resistencia,
	   ISNULL(hvid.UHML,0) as Largo,
	   ISNULL(hvid.CastigoUICompra,0) as CastigoUICompra,
	   ISNULL(hvid.castigoMicCompra,0) as CastigoMicCompra,
	   ISNULL(hvid.CastigoResistenciaFibraCompra,0) as CastigoResistenciaFibraCompra,
	   ISNULL(hvid.CastigoLargoFibraCompra,0) as CastigoLargoFibraCompra,
	   isnull(hvid.CastigoBarkLevel1Compra,0) as CastigoBarkLevel1Compra, 
       isnull(hvid.CastigoBarkLevel2Compra,0) as CastigoBarkLevel2Compra,
       isnull(hvid.CastigoPrepLevel1Compra,0) as CastigoPrepLevel1Compra,
       isnull(hvid.CastigoPrepLevel2Compra,0) as CastigoPrepLevel2Compra,
       isnull(hvid.CastigoOtherLevel1Compra,0) as CastigoOtherLevel1Compra,
       isnull(hvid.CastigoOtherLevel2Compra,0) as CastigoOtherLevel2Compra,
       isnull(hvid.CastigoPlasticLevel1Compra,0) as CastigoPlasticLevel1Compra,
       isnull(hvid.CastigoPlasticLevel2Compra,0) as CastigoPlasticLevel2Compra
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       full join HviDetalle hvid on pd.FolioCIA = hvid.BaleID and pd.IdOrdenTrabajo = hvid.IdOrdenTrabajo
						   full join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		order by LR.IdLiquidacion, pd.FolioCIA
end