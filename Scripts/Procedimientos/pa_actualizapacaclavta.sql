create procedure pa_actualizapacaclavta
@idproducciondetalle int,
@idpaqueteencabezado int
as
update ProduccionDetalle
set IdPaqueteEncabezado = @idpaqueteencabezado	
where IdProduccionDetalle = @idproducciondetalle