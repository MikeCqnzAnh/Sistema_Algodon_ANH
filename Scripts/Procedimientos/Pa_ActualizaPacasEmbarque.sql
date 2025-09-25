CREATE procedure Pa_ActualizaPacasEmbarque
@idproducciondetalle int,
@IdEmbarqueEncabezado int
as
update ProduccionDetalle
set IdEmbarqueEncabezado = case when @IdEmbarqueEncabezado = 0 then null else @IdEmbarqueEncabezado end
where idproducciondetalle = @idproducciondetalle