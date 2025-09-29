CREATE procedure pa_conspacacompradis
@idproductor int,
@seleccionar bit = 0
as
select IdProduccionDetalle,
	   pd.IdProduccion,
	   pd.IdPlantaOrigen,
	   pl.Descripcion as Planta,
	   isnull(IdCompraenc,0) as IdCompraenc,
	   BaleID,
	   Mic,
	   UHML,
	   UI,
	   Strength,
	   Elongation,
	   Grade,
	   ColorGrade,
	   TrashCount,
	   TrashArea,
	   TrashID,
	   SCI,
	   Kilos,
	   Libras,
	   Quintales,
	   isnull(kiloscompra,0) as kiloscompra,
	   isnull(librascompra,0) as librascompra,
	   isnull(quintalescompra,0) as quintalescompra,
	   isnull(PrecioDlscompra,0) as PrecioDlscompra,
	   isnull(PrecioClasecompra,0) as PrecioClasecompra,
	   isnull(CastigoMicCpa,0) as CastigoMicCpa,
	   isnull(CastigoLargoFibraCpa,0) as CastigoLargoFibraCpa,
	   isnull(CastigoResistenciaFibraCpa,0) as CastigoResistenciaFibraCpa,
	   isnull(CastigoUICompra,0) as CastigoUICompra,
	   @seleccionar as Seleccionar
from Produccion pe right join ProduccionDetalle pd on pe.IdProduccion = pd.IdProduccion
				   inner join Plantas pl on pd.IdPlantaOrigen = pl.IdPlanta
where pd.IdCompraenc is null and pd.LotID is not null AND pe.IdCliente = @idproductor
order by pd.BaleID