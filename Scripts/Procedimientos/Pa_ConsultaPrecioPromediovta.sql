alter Procedure Pa_ConsultaPrecioPromediovta
@idcomprador int
as
select isnull(convert(numeric(6,4),round(sum(pacasvendidas*precioquintal)/sum(PacasVendidas),4,1)),0) as PrecioPromedio
from contratoventa
where pacas = pacasvendidas and IdComprador = @idcomprador