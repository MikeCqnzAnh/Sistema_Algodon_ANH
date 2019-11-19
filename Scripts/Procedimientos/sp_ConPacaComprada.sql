Create procedure sp_ConPacaComprada
--declare
@IdProductor int ,
@IdCompraEnc int ,
@Seleccionar bit = 0 
as
select pd.FolioCIA,
	   hvid.IdOrdenTrabajo,
	   LR.IdLiquidacion,
	   Pl.Descripcion,
	   hvid.idplantaorigen,
	   hvid.BaleID,
	   pd.Kilos,
	   hvid.Grade,
	   HviD.quintales,
	   hvid.PrecioDls,
	   Hvid.TipoCambio,
	   Hvid.PrecioMxn,
	   ISNULL(HVID.CastigoUICompra,0) as CastigoUICompra,
	   ISNULL(hvid.castigoMicCompra,0) as castigoMicCompra,
	   ISNULL(hvid.CastigoResistenciaFibraCompra,0) as CastigoResistenciaFibraCompra,
	   ISNULL(hvid.CastigoLargoFibraCompra,0) as CastigoLargoFibraCompra,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join HviDetalle hvid 
		on pd.FolioCIA = hvid.BaleID left join liquidacionesporromaneaje LR 
		on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and hvid.FlagTerminado =1 and hvid.EstatusCompra  = 2 and hvid.IdCompraEnc = @IdCompraEnc