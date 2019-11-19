CREATE procedure sp_ConsultaPacasComprasFiltro
--declare
@IdProductor int ,
@Seleccionar bit =0 ,
@PacaIni int,
@PacaFin int,
@Clase varchar(4)
as
if @Clase <> '' and @PacaIni > 0 and @PacaFin > 0
begin 
select pd.FolioCIA,
	   hvid.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   HviD.IdPlantaOrigen,
	   hvid.BaleID,
	   pd.Kilos,
	   Hvid.quintales,
	   hvid.Grade,
	   hvid.UI as Uniformidad,
	   hvid.Mic as Micros,
	   hvid.Strength as Resistencia,
	   hvid.UHML as Largo,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       left join HviDetalle hvid on pd.FolioCIA = hvid.BaleID 
						   right join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and hvid.FlagTerminado =1 and hvid.EstatusCompra = 1 and
			  hvid.BaleID between @PacaIni and @PacaFin and hvid.Grade = @Clase
end
else if @Clase = '' and @PacaIni > 0 and @PacaFin > 0
begin
select pd.FolioCIA,
	   hvid.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   HviD.IdPlantaOrigen,
	   hvid.BaleID,
	   pd.Kilos,
	   Hvid.quintales,
	   hvid.Grade,
	   hvid.UI as Uniformidad,
	   hvid.Mic as Micros,
	   hvid.Strength as Resistencia,
	   hvid.UHML as Largo,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       left join HviDetalle hvid on pd.FolioCIA = hvid.BaleID 
						   right join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and hvid.FlagTerminado =1 and hvid.EstatusCompra = 1 and
			  hvid.BaleID between @PacaIni and @PacaFin 
end
else if @Clase <> '' and @PacaIni = 0 and @PacaFin = 0
begin
select pd.FolioCIA,
	   hvid.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   HviD.IdPlantaOrigen,
	   hvid.BaleID,
	   pd.Kilos,
	   Hvid.quintales,
	   hvid.Grade,
	   hvid.UI as Uniformidad,
	   hvid.Mic as Micros,
	   hvid.Strength as Resistencia,
	   hvid.UHML as Largo,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       left join HviDetalle hvid on pd.FolioCIA = hvid.BaleID 
						   right join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and hvid.FlagTerminado =1 and hvid.EstatusCompra = 1 and hvid.Grade = @Clase
end
else if @Clase = '' and @PacaIni = 0 and @PacaFin = 0
begin
select pd.FolioCIA,
	   hvid.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   HviD.IdPlantaOrigen,
	   hvid.BaleID,
	   pd.Kilos,
	   Hvid.quintales,
	   hvid.Grade,
	   hvid.UI as Uniformidad,
	   hvid.Mic as Micros,
	   hvid.Strength as Resistencia,
	   hvid.UHML as Largo,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       left join HviDetalle hvid on pd.FolioCIA = hvid.BaleID 
						   right join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and hvid.FlagTerminado =1 and hvid.EstatusCompra = 1
end