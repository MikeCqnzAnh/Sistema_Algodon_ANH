create procedure pa_actualizapacalote
@idlote int,
@idproducciondetalle int
as
update ProduccionDetalle
set IdLote = case when @idlote = 0 then null else @idlote end				
where IdProduccionDetalle = @idproducciondetalle