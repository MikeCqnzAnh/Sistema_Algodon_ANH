create procedure pa_consultapacasembarquesel
@idembarque int ,
@seleccionar bit = 0
as
select IdProduccionDetalle,
	   pd.IdLote,
	   le.Nolote,
	   pd.IdEmbarqueEncabezado,
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
where pd.IdEmbarqueEncabezado = @idembarque
order by pd.BaleID