Create Procedure Pa_ConsultaRevisionProduccion
@IdProduccion int
as
select isnull(EstatusRevisado,0) as EstatusRevisado
from Produccion 
where IdProduccion = @IdProduccion