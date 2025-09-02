alter procedure Pa_ConsultaPacaDetallesVenta
@FolioCia bigint,
@IdOrdenTrabajo int,
@IdLiquidacion int,
@IdVenta int,
@IdPlanta int,
@IdSalida int,
@IdEmbarque int,
@NoLote varchar(15),
@PacaInicial bigint,
@PacaFinal bigint
as
if @foliocia > 0 
begin 
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(cc.IdPaqueteEncabezado,0) as IdPaquete,	  	   		   
	   isnull(cc.idventaenc,0) as IdVenta,
	   isnull(cc.idembarqueencabezado,0) as IdEmbarque,
	   ISNULL(cc.IdSalidaEncabezado,0) as IdSalida,
       ISNULL(cc.Nolote,'S/N') as Nolote,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(pcv.KilosNeto,0),2) as Tara,
	   ROUND(isnull(cc.kilos,0),2 ) as KilosVenta,
	   isnull(cc.Grade,'S/C') as Grade,
	   isnull(cc.quintales,0) as Quintales,
	   ROUND(isnull(cc.PrecioClase,0),2 )  as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.UI,0) as Uniformidad,
	   isnull(cc.Mic,0) as Micros,
	   isnull(cc.Strength,0) as Resistencia,
	   isnull(cc.UHML,0) as Largo,
	   ISNULL(cc.CastigoUIVenta,0) as CastigoUIVenta,
	   ISNULL(cc.castigoMicVenta,0) as CastigoMicVenta,
	   ISNULL(cc.CastigoResistenciaFibraVenta,0) as CastigoResistenciaFibraVenta,
	   ISNULL(cc.CastigoLargoFibraVenta,0) as CastigoLargoFibraVenta,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
						   full join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo=cc.IdOrdenTrabajo  
						   full join liquidacionesporromaneaje LR on pd.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   full join ventapacas vp on cc.IdVentaEnc = vp.IdVenta
						   full join ParametrosContratoVenta pcv on vp.IdContratoAlgodon = pcv.IdContratoVenta
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		WHERE pd.FolioCIA = @FolioCia
		order by LR.IdLiquidacion,pd.FolioCIA
end
else if @IdOrdenTrabajo > 0 
begin
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(cc.IdPaqueteEncabezado,0) as IdPaquete,	  	   		   
	   isnull(cc.idventaenc,0) as IdVenta,
	   isnull(cc.idembarqueencabezado,0) as IdEmbarque,
	   ISNULL(cc.IdSalidaEncabezado,0) as IdSalida,
       ISNULL(cc.Nolote,'S/N') as Nolote,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(pcv.KilosNeto,0),2) as Tara,
	   ROUND(isnull(cc.kilos,0),2 ) as KilosVenta,
	   isnull(cc.Grade,'S/C') as Grade,
	   isnull(cc.quintales,0) as Quintales,
	   ROUND(isnull(cc.PrecioClase,0),2 )  as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.UI,0) as Uniformidad,
	   isnull(cc.Mic,0) as Micros,
	   isnull(cc.Strength,0) as Resistencia,
	   isnull(cc.UHML,0) as Largo,
	   ISNULL(cc.CastigoUIVenta,0) as CastigoUIVenta,
	   ISNULL(cc.castigoMicVenta,0) as CastigoMicVenta,
	   ISNULL(cc.CastigoResistenciaFibraVenta,0) as CastigoResistenciaFibraVenta,
	   ISNULL(cc.CastigoLargoFibraVenta,0) as CastigoLargoFibraVenta,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
						   full join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo=cc.IdOrdenTrabajo  
						   full join liquidacionesporromaneaje LR on pd.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   full join ventapacas vp on cc.IdVentaEnc = vp.IdVenta
						   full join ParametrosContratoVenta pcv on vp.IdContratoAlgodon = pcv.IdContratoVenta
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		WHERE pd.IdOrdenTrabajo = @IdOrdenTrabajo
		order by LR.IdLiquidacion,pd.FolioCIA
end
else if @IdLiquidacion > 0 
begin
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(cc.IdPaqueteEncabezado,0) as IdPaquete,	  	   		   
	   isnull(cc.idventaenc,0) as IdVenta,
	   isnull(cc.idembarqueencabezado,0) as IdEmbarque,
	   ISNULL(cc.IdSalidaEncabezado,0) as IdSalida,
       ISNULL(cc.Nolote,'S/N') as Nolote,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(pcv.KilosNeto,0),2) as Tara,
	   ROUND(isnull(cc.kilos,0),2 ) as KilosVenta,
	   isnull(cc.Grade,'S/C') as Grade,
	   isnull(cc.quintales,0) as Quintales,
	   ROUND(isnull(cc.PrecioClase,0),2 )  as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.UI,0) as Uniformidad,
	   isnull(cc.Mic,0) as Micros,
	   isnull(cc.Strength,0) as Resistencia,
	   isnull(cc.UHML,0) as Largo,
	   ISNULL(cc.CastigoUIVenta,0) as CastigoUIVenta,
	   ISNULL(cc.castigoMicVenta,0) as CastigoMicVenta,
	   ISNULL(cc.CastigoResistenciaFibraVenta,0) as CastigoResistenciaFibraVenta,
	   ISNULL(cc.CastigoLargoFibraVenta,0) as CastigoLargoFibraVenta,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
						   full join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo=cc.IdOrdenTrabajo  
						   full join liquidacionesporromaneaje LR on pd.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   full join ventapacas vp on cc.IdVentaEnc = vp.IdVenta
						   full join ParametrosContratoVenta pcv on vp.IdContratoAlgodon = pcv.IdContratoVenta
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		WHERE LR.IdLiquidacion = @IdLiquidacion
		order by LR.IdLiquidacion,pd.FolioCIA
end
else if @IdVenta > 0 
begin
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(cc.IdPaqueteEncabezado,0) as IdPaquete,	  	   		   
	   isnull(cc.idventaenc,0) as IdVenta,
	   isnull(cc.idembarqueencabezado,0) as IdEmbarque,
	   ISNULL(cc.IdSalidaEncabezado,0) as IdSalida,
       ISNULL(cc.Nolote,'S/N') as Nolote,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(pcv.KilosNeto,0),2) as Tara,
	   ROUND(isnull(cc.kilos,0),2 ) as KilosVenta,
	   isnull(cc.Grade,'S/C') as Grade,
	   isnull(cc.quintales,0) as Quintales,
	   ROUND(isnull(cc.PrecioClase,0),2 )  as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.UI,0) as Uniformidad,
	   isnull(cc.Mic,0) as Micros,
	   isnull(cc.Strength,0) as Resistencia,
	   isnull(cc.UHML,0) as Largo,
	   ISNULL(cc.CastigoUIVenta,0) as CastigoUIVenta,
	   ISNULL(cc.castigoMicVenta,0) as CastigoMicVenta,
	   ISNULL(cc.CastigoResistenciaFibraVenta,0) as CastigoResistenciaFibraVenta,
	   ISNULL(cc.CastigoLargoFibraVenta,0) as CastigoLargoFibraVenta,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
						   full join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo=cc.IdOrdenTrabajo  
						   full join liquidacionesporromaneaje LR on pd.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   full join ventapacas vp on cc.IdVentaEnc = vp.IdVenta
						   full join ParametrosContratoVenta pcv on vp.IdContratoAlgodon = pcv.IdContratoVenta
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		WHERE cc.idventaenc = @IdVenta
		order by LR.IdLiquidacion,pd.FolioCIA
end
else if @IdPlanta > 0 
begin
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(cc.IdPaqueteEncabezado,0) as IdPaquete,	  	   		   
	   isnull(cc.idventaenc,0) as IdVenta,
	   isnull(cc.idembarqueencabezado,0) as IdEmbarque,
	   ISNULL(cc.IdSalidaEncabezado,0) as IdSalida,
       ISNULL(cc.Nolote,'S/N') as Nolote,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(pcv.KilosNeto,0),2) as Tara,
	   ROUND(isnull(cc.kilos,0),2 ) as KilosVenta,
	   isnull(cc.Grade,'S/C') as Grade,
	   isnull(cc.quintales,0) as Quintales,
	   ROUND(isnull(cc.PrecioClase,0),2 )  as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.UI,0) as Uniformidad,
	   isnull(cc.Mic,0) as Micros,
	   isnull(cc.Strength,0) as Resistencia,
	   isnull(cc.UHML,0) as Largo,
	   ISNULL(cc.CastigoUIVenta,0) as CastigoUIVenta,
	   ISNULL(cc.castigoMicVenta,0) as CastigoMicVenta,
	   ISNULL(cc.CastigoResistenciaFibraVenta,0) as CastigoResistenciaFibraVenta,
	   ISNULL(cc.CastigoLargoFibraVenta,0) as CastigoLargoFibraVenta,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
						   full join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo=cc.IdOrdenTrabajo  
						   full join liquidacionesporromaneaje LR on pd.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   full join ventapacas vp on cc.IdVentaEnc = vp.IdVenta
						   full join ParametrosContratoVenta pcv on vp.IdContratoAlgodon = pcv.IdContratoVenta
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		WHERE pd.IdPlantaOrigen = @IdPlanta
		order by LR.IdLiquidacion,pd.FolioCIA
end
else if @PacaInicial > 0 and @PacaFinal > @PacaInicial
begin
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(cc.IdPaqueteEncabezado,0) as IdPaquete,	  	   		   
	   isnull(cc.idventaenc,0) as IdVenta,
	   isnull(cc.idembarqueencabezado,0) as IdEmbarque,
	   ISNULL(cc.IdSalidaEncabezado,0) as IdSalida,
       ISNULL(cc.Nolote,'S/N') as Nolote,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(pcv.KilosNeto,0),2) as Tara,
	   ROUND(isnull(cc.kilos,0),2 ) as KilosVenta,
	   isnull(cc.Grade,'S/C') as Grade,
	   isnull(cc.quintales,0) as Quintales,
	   ROUND(isnull(cc.PrecioClase,0),2 )  as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.UI,0) as Uniformidad,
	   isnull(cc.Mic,0) as Micros,
	   isnull(cc.Strength,0) as Resistencia,
	   isnull(cc.UHML,0) as Largo,
	   ISNULL(cc.CastigoUIVenta,0) as CastigoUIVenta,
	   ISNULL(cc.castigoMicVenta,0) as CastigoMicVenta,
	   ISNULL(cc.CastigoResistenciaFibraVenta,0) as CastigoResistenciaFibraVenta,
	   ISNULL(cc.CastigoLargoFibraVenta,0) as CastigoLargoFibraVenta,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
						   full join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo=cc.IdOrdenTrabajo  
						   full join liquidacionesporromaneaje LR on pd.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   full join ventapacas vp on cc.IdVentaEnc = vp.IdVenta
						   full join ParametrosContratoVenta pcv on vp.IdContratoAlgodon = pcv.IdContratoVenta
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		WHERE pd.FolioCIA >= @PacaInicial and pd.FolioCIA <= @PacaFinal
		order by LR.IdLiquidacion,pd.FolioCIA
end
else if @NoLote <> ''
begin
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(cc.IdPaqueteEncabezado,0) as IdPaquete,	  	   		   
	   isnull(cc.idventaenc,0) as IdVenta,
	   isnull(cc.idembarqueencabezado,0) as IdEmbarque,
	   ISNULL(cc.IdSalidaEncabezado,0) as IdSalida,
       ISNULL(cc.Nolote,'S/N') as Nolote,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(pcv.KilosNeto,0),2) as Tara,
	   ROUND(isnull(cc.kilos,0),2 ) as KilosVenta,
	   isnull(cc.Grade,'S/C') as Grade,
	   isnull(cc.quintales,0) as Quintales,
	   ROUND(isnull(cc.PrecioClase,0),2 )  as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.UI,0) as Uniformidad,
	   isnull(cc.Mic,0) as Micros,
	   isnull(cc.Strength,0) as Resistencia,
	   isnull(cc.UHML,0) as Largo,
	   ISNULL(cc.CastigoUIVenta,0) as CastigoUIVenta,
	   ISNULL(cc.castigoMicVenta,0) as CastigoMicVenta,
	   ISNULL(cc.CastigoResistenciaFibraVenta,0) as CastigoResistenciaFibraVenta,
	   ISNULL(cc.CastigoLargoFibraVenta,0) as CastigoLargoFibraVenta,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
						   full join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo=cc.IdOrdenTrabajo  
						   full join liquidacionesporromaneaje LR on pd.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   full join ventapacas vp on cc.IdVentaEnc = vp.IdVenta
						   full join ParametrosContratoVenta pcv on vp.IdContratoAlgodon = pcv.IdContratoVenta
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		WHERE cc.Nolote = @NoLote
		order by LR.IdLiquidacion,pd.FolioCIA
end
else if @IdEmbarque > 0
begin
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(cc.IdPaqueteEncabezado,0) as IdPaquete,	  	   		   
	   isnull(cc.idventaenc,0) as IdVenta,
	   isnull(cc.idembarqueencabezado,0) as IdEmbarque,
	   ISNULL(cc.IdSalidaEncabezado,0) as IdSalida,
       ISNULL(cc.Nolote,'S/N') as Nolote,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(pcv.KilosNeto,0),2) as Tara,
	   ROUND(isnull(cc.kilos,0),2 ) as KilosVenta,
	   isnull(cc.Grade,'S/C') as Grade,
	   isnull(cc.quintales,0) as Quintales,
	   ROUND(isnull(cc.PrecioClase,0),2 )  as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.UI,0) as Uniformidad,
	   isnull(cc.Mic,0) as Micros,
	   isnull(cc.Strength,0) as Resistencia,
	   isnull(cc.UHML,0) as Largo,
	   ISNULL(cc.CastigoUIVenta,0) as CastigoUIVenta,
	   ISNULL(cc.castigoMicVenta,0) as CastigoMicVenta,
	   ISNULL(cc.CastigoResistenciaFibraVenta,0) as CastigoResistenciaFibraVenta,
	   ISNULL(cc.CastigoLargoFibraVenta,0) as CastigoLargoFibraVenta,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
						   full join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo=cc.IdOrdenTrabajo  
						   full join liquidacionesporromaneaje LR on pd.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   full join ventapacas vp on cc.IdVentaEnc = vp.IdVenta
						   full join ParametrosContratoVenta pcv on vp.IdContratoAlgodon = pcv.IdContratoVenta
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		WHERE cc.idembarqueencabezado = @IdEmbarque
		order by LR.IdLiquidacion,pd.FolioCIA
end
else if @IdSalida > 0
begin
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(cc.IdPaqueteEncabezado,0) as IdPaquete,	  	   		   
	   isnull(cc.idventaenc,0) as IdVenta,
	   isnull(cc.idembarqueencabezado,0) as IdEmbarque,
	   ISNULL(cc.IdSalidaEncabezado,0) as IdSalida,
       ISNULL(cc.Nolote,'S/N') as Nolote,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(pcv.KilosNeto,0),2) as Tara,
	   ROUND(isnull(cc.kilos,0),2 ) as KilosVenta,
	   isnull(cc.Grade,'S/C') as Grade,
	   isnull(cc.quintales,0) as Quintales,
	   ROUND(isnull(cc.PrecioClase,0),2 )  as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.UI,0) as Uniformidad,
	   isnull(cc.Mic,0) as Micros,
	   isnull(cc.Strength,0) as Resistencia,
	   isnull(cc.UHML,0) as Largo,
	   ISNULL(cc.CastigoUIVenta,0) as CastigoUIVenta,
	   ISNULL(cc.castigoMicVenta,0) as CastigoMicVenta,
	   ISNULL(cc.CastigoResistenciaFibraVenta,0) as CastigoResistenciaFibraVenta,
	   ISNULL(cc.CastigoLargoFibraVenta,0) as CastigoLargoFibraVenta,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
						   full join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo=cc.IdOrdenTrabajo  
						   full join liquidacionesporromaneaje LR on pd.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   full join ventapacas vp on cc.IdVentaEnc = vp.IdVenta
						   full join ParametrosContratoVenta pcv on vp.IdContratoAlgodon = pcv.IdContratoVenta
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		WHERE cc.IdSalidaEncabezado = @IdSalida
		order by LR.IdLiquidacion,pd.FolioCIA
end
else
begin
select pd.FolioCIA,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   isnull(pd.IdOrdenTrabajo,0) as IdOrdenTrabajo,
	   isnull(cc.IdPaqueteEncabezado,0) as IdPaquete,	  	   		   
	   isnull(cc.idventaenc,0) as IdVenta,
	   isnull(cc.idembarqueencabezado,0) as IdEmbarque,
	   ISNULL(cc.IdSalidaEncabezado,0) as IdSalida,
       ISNULL(cc.Nolote,'S/N') as Nolote,
	   Pl.Descripcion as Planta,
	   isnull(pd.Kilos,0) as KilosProduccion,
	   ROUND(isnull(pcv.KilosNeto,0),2) as Tara,
	   ROUND(isnull(cc.kilos,0),2 ) as KilosVenta,
	   isnull(cc.Grade,'S/C') as Grade,
	   isnull(cc.quintales,0) as Quintales,
	   ROUND(isnull(cc.PrecioClase,0),2 )  as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.UI,0) as Uniformidad,
	   isnull(cc.Mic,0) as Micros,
	   isnull(cc.Strength,0) as Resistencia,
	   isnull(cc.UHML,0) as Largo,
	   ISNULL(cc.CastigoUIVenta,0) as CastigoUIVenta,
	   ISNULL(cc.castigoMicVenta,0) as CastigoMicVenta,
	   ISNULL(cc.CastigoResistenciaFibraVenta,0) as CastigoResistenciaFibraVenta,
	   ISNULL(cc.CastigoLargoFibraVenta,0) as CastigoLargoFibraVenta,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta
		from Produccion pr full join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
						   full join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo=cc.IdOrdenTrabajo  
						   full join liquidacionesporromaneaje LR on pd.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   full join ventapacas vp on cc.IdVentaEnc = vp.IdVenta
						   full join ParametrosContratoVenta pcv on vp.IdContratoAlgodon = pcv.IdContratoVenta
						   join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		order by LR.IdLiquidacion,pd.FolioCIA
end
