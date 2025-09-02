alter procedure Sp_ActualizaIdPaqueteDePaca
@IdPaquete int,
@IdPlanta int,
@BaleId bigint
as
update CalculoClasificacion
set LotID = @IdPaquete
where BaleId = @BaleId and IdPlantaOrigen = @IdPlanta 