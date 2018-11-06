create procedure sp_ConsultaSecuencia
--declare
@IdPlantaOrigen int --= 1
as
select Secuencia
from [dbo].[FolioEtiqueta] a
where a.IdplantaOrigen = @IdPlantaOrigen