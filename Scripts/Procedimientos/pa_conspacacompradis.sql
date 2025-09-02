create procedure pa_conspacacompradis
@idproductor int,
@seleccionar bit = 0
as
select IdProduccionDetalle,
	   pd.IdProduccion,
	   pd.IdPlantaOrigen,
	   isnull(IdCompraenc,0) as IdCompraenc,
	   BaleID,
	   Mic,
	   UHML,
	   UI,
	   Strength,
	   SFI,
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
	   kiloscompra,
	   librascompra,
	   quintalescompra,
	   PrecioDlscompra,
	   PrecioClasecompra,
	   CastigoMicCpa,
	   CastigoLargoFibraCpa,
	   CastigoResistenciaFibraCpa,
	   CastigoUICompra,
	   @seleccionar as Seleccionar
from Produccion pe right join ProduccionDetalle pd on pe.IdProduccion = pd.IdProduccion
where pd.IdCompraenc is null and pd.LotID is not null AND pe.IdCliente = @idproductor
order by pd.BaleID