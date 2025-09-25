CREATE Procedure Pa_ConsultaLotesInventario
@IdComprador int
as
select lc.Nolote
from Lotesenc lc 
where lc.idcomprador = @IdComprador
order by lc.Nolote