create procedure pa_actualizacontratocompra
@idcontrato int,
@compradas int,
@disponibles int
as
update ContratoCompra
set PacasCompradas = @compradas,
	PacasDisponibles = @disponibles
where IdContratoAlgodon = @idcontrato