CREATE procedure pa_conspacaventadis
@idcomprador int,
@seleccionar bit = 0
as
select IdProduccionDetalle,
	   pd.IdProduccion,
	   pd.IdPaqueteEncabezado,
	   pd.IdPlantaOrigen,
	   pl.Descripcion as Planta,
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
	   isnull(CastigoMicVta,0) as CastigoMicvta,
	   isnull(CastigoLargoFibravta,0) as CastigoLargoFibravta,
	   isnull(CastigoResistenciaFibravta,0) as CastigoResistenciaFibravta,
	   isnull(CastigoUIventa,0) as CastigoUIventa,
	   @seleccionar as Seleccionar
from Produccion pe right join ProduccionDetalle pd on pe.IdProduccion = pd.IdProduccion
				   LEFT JOIN PaqueteEncabezado pq on pd.IdPaqueteEncabezado = pq.IdPaquete
				   inner join Plantas pl on pd.IdPlantaOrigen = pl.IdPlanta
where pd.IdVentaEnc is null and pd.IdPaqueteEncabezado is not null and pq.idComprador = @idcomprador
order by pd.BaleID