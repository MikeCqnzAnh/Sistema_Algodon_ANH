create procedure pa_consultapacasembarquedis
@idcomprador int ,
@seleccionar bit = 0
as
select IdProduccionDetalle,
	   pd.IdLote,
	   le.Nolote,
	   isnull(pd.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
	   isnull(IdSalidaEncabezado,0) as IdSalidaEncabezado,
	   pd.BaleID,
	   pd.Mic,
	   pd.Strength,
	   pd.UHML,
	   pd.UI,
	   pd.Grade,
	   pd.ColorGrade,
	   pd.TrashID,
	   pd.TrashArea,
	   pd.TrashCount,
	   pd.Kilos,
	   @seleccionar as seleccionar
from Produccion pe right join ProduccionDetalle pd on pe.IdProduccion = pd.IdProduccion
				   LEFT JOIN PaqueteEncabezado pq on pd.IdPaqueteEncabezado = pq.IdPaquete
				   left join Lotesenc le on le.idlote = pd.IdLote
where pd.IdEmbarqueEncabezado is null and pd.IdLote is not null and pq.idComprador = @idcomprador
order by pd.BaleID