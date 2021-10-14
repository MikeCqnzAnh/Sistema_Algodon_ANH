Create Procedure Pa_ExisteNoloteEmbarque
@IdEmbarque int,
@NoLote varchar(15)
as
if exists (select NoLote from EmbarqueDet where IdEmbarqueEnc = @IdEmbarque and Nolote = @Nolote)
	begin
		select 1 as Valida
	end
else
	begin
		select 0 as Valida
	end