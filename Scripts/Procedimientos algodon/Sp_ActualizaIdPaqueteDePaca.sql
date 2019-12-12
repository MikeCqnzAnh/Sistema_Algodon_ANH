Create procedure Sp_ActualizaIdPaqueteDePaca
@IdPaquete int,
@IdPlanta int,
@BaleId int
as
update CalculoClasificacion
set LotID = @IdPaquete
where BaleId = @BaleId and IdPlantaOrigen = @IdPlanta 