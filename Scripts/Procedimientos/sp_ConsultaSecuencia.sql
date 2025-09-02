CREATE procedure sp_ConsultaSecuencia
--declare
@IdPlantaOrigen int --= 1
as
select case when etiqueta <= 0 then 0 else Etiqueta end as Etiqueta,
	   case when etiqueta <= 0 then 1 else Secuencia end as Secuencia
from [dbo].[FolioEtiqueta] a
where a.IdplantaOrigen = @IdPlantaOrigen