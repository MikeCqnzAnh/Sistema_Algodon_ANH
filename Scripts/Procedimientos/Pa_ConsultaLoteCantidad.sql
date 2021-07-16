Create Procedure Pa_ConsultaLoteCantidad
@IdEmbarqueDetalle int
as
select IdEmbarqueDet,IdEmbarqueEnc,CantidadPacas,NoLote
from EmbarqueDet
where IdEmbarqueDet = @IdEmbarqueDetalle