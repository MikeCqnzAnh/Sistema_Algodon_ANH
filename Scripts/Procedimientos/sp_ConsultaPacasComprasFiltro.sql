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
	   cc.IdOrdenTrabajo,
	   LR.IdLiquidacion,
	   Pl.Descripcion,
	   cc.BaleID,
	   pd.Kilos,
	   cc.Grade,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and cc.FlagTerminado =1 and cc.EstatusCompra = 1 and
			  cc.BaleID between @PacaIni and @PacaFin and cc.Grade = @Clase
end
else if @Clase = '' and @PacaIni > 0 and @PacaFin > 0
begin
select pd.FolioCIA,
	   cc.IdOrdenTrabajo,
	   LR.IdLiquidacion,
	   Pl.Descripcion,
	   cc.BaleID,
	   pd.Kilos,
	   cc.Grade,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and cc.FlagTerminado =1 and cc.EstatusCompra = 1 and
			  cc.BaleID between @PacaIni and @PacaFin 
end
else if @Clase <> '' and @PacaIni = 0 and @PacaFin = 0
begin
		select pd.FolioCIA,
	   cc.IdOrdenTrabajo,
	   LR.IdLiquidacion,
	   Pl.Descripcion,
	   cc.BaleID,
	   pd.Kilos,
	   cc.Grade,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and cc.FlagTerminado =1 and cc.EstatusCompra = 1 and cc.Grade = @Clase
end
else if @Clase = '' and @PacaIni = 0 and @PacaFin = 0
begin
		select pd.FolioCIA,
	   cc.IdOrdenTrabajo,
	   LR.IdLiquidacion,
	   Pl.Descripcion,
	   cc.BaleID,
	   pd.Kilos,
	   cc.Grade,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and cc.FlagTerminado =1 and cc.EstatusCompra = 1
end