Create Procedure Sp_EliminaPacaEmbarque
@IdEmbarqueDetalle int
as
delete from EmbarqueDetalle
where IdEmbarqueDetalle = @IdEmbarqueDetalle