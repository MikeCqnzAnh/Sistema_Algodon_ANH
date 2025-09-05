create procedure pa_actualizacontratoventa
@idcontrato int,
@compradas int,
@disponibles int
as
update ContratoVenta
set PacasVendidas = @compradas,
	PacasDisponibles = @disponibles
where IdContratoAlgodon = @idcontrato