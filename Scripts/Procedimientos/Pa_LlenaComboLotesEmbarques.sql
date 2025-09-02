CREATE procedure Pa_LlenaComboLotesEmbarques
@IdEmbarqueEnc int 
as
select distinct IdEmbarqueDet,NoLote 
from EmbarqueDet 
where IdEmbarqueEnc = @IdEmbarqueEnc