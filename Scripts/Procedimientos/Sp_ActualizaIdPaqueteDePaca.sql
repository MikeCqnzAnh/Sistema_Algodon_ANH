create proc Sp_ActualizaIdPaqueteDePaca
@IdPaquete int,
@BaleId int
as
update CalculoClasificacion
set IdPaqueteEncabezado = @IdPaquete
where BaleId = @BaleId