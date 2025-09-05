CREATE procedure pa_conspacaventasel
@idventa int,
@seleccionar bit = 0
as
select IdProduccionDetalle,
	   pd.IdProduccion,
	   pd.IdPlantaOrigen,
	   isnull(IdVentaEnc,0) as IdVentaEnc,
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
	   isnull(kilosventa,0) as kilosventa,
	   isnull(librasventa,0) as librasventa,
	   isnull(quintalesventa,0) as quintalesventa,
	   isnull(PrecioDlsventa,0) as PrecioDlsventa,
	   isnull(PrecioClaseventa,0) as PrecioClaseventa,
	   isnull(CastigoMicvta,0) as CastigoMicvta,
	   isnull(CastigoLargoFibravta,0) as CastigoLargoFibravta,
	   isnull(CastigoResistenciaFibravta,0) as CastigoResistenciaFibravta,
	   isnull(CastigoUIventa,0) as CastigoUIventa,
	   @seleccionar as Seleccionar
from Produccion pe right join ProduccionDetalle pd on pe.IdProduccion = pd.IdProduccion
				   inner join ventapacasenc cenc on pd.IdVentaEnc = cenc.idventa
where pd.IdVentaEnc = @idventa
order by pd.BaleID