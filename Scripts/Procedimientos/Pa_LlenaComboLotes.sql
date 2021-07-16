alter procedure Pa_LlenaComboLotes
@IdEmbarqueEnc int
as
Select IdEmbarqueDet,Nolote 
from EmbarqueDet
where IdEmbarqueEnc = @IdEmbarqueEnc