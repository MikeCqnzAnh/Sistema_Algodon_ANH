alter Procedure Pa_ComboEmbarqueLote
@IdEmbarqueEncabezado int
as
select distinct IdEmbarqueEncabezado as IdEmbarqueDet, NoLote 
from calculoclasificacion where idembarqueencabezado = @IdEmbarqueEncabezado

--select IdEmbarqueDet,NoLote 
--from EmbarqueDet 
--where IdEmbarqueEnc = @IdEmbarqueEncabezado

