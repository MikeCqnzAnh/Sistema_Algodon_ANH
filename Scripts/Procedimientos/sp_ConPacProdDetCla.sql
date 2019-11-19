Create procedure sp_ConPacProdDetCla
--declare
@IdProductor int ,
@Seleccionar bit = 0 
as
select pd.FolioCIA,
	   hvid.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   HviD.IdPlantaOrigen,
	   hvid.BaleID,
	   pd.Kilos,
	   hvid.Grade,
	   HviD.quintales,
	   hvid.PrecioDls,
	   Hvid.TipoCambio,
	   Hvid.PrecioMxn,
	   hvid.UI as Uniformidad,
	   hvid.Mic as Micros,
	   hvid.Strength as Resistencia,
	   hvid.UHML as Largo,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       left join HviDetalle hvid on pd.FolioCIA = hvid.BaleID 
						   right join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		where pr.IdCliente = @IdProductor and hvid.FlagTerminado =1 and hvid.EstatusCompra  = 1
		order by BaleID