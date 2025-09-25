create procedure pa_consultapacaslotesel
@idlote int,
@seleccionar bit = 0
as
select pd.IdProduccionDetalle,
	   pd.IdPaqueteEncabezado,
	   isnull(pd.IdLote,0) as idlote,
	   isnull(pd.IdEmbarqueEncabezado,0) as idembarqueencabezado,
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
from PaqueteEncabezado pe left join ProduccionDetalle pd on pe.IdPaquete = pd.IdPaqueteEncabezado
where pd.IdPaqueteEncabezado is not null and pd.IdLote = @idlote
order by pd.BaleID