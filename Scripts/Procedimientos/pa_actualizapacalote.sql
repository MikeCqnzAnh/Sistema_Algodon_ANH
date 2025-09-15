create procedure pa_actualizapacalote
@idlote int,
@idproducciondetalle int
as
update ProduccionDetalle
set IdLote = @idlote
where IdProduccionDetalle = @idproducciondetalle