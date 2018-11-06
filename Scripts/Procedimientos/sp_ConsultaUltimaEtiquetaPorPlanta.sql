CREATE procedure sp_ConsultaUltimaEtiquetaPorPlanta
--declare
@IdPlantaOrigen int --= 1
as
select ISNULL(Secuencia,0) as Secuencia
from [dbo].[FolioEtiqueta] a
where a.IdPlantaOrigen = @IdPlantaOrigen
