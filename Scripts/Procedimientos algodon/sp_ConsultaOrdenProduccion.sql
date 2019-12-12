create procedure sp_ConsultaOrdenProduccion
@IdProduccion int
as
select a.IdProduccion,
       a.IdOrdenTrabajo,
	   a.IdPlantaOrigen
from [dbo].[Produccion] a
where a.IdProduccion = @IdProduccion
