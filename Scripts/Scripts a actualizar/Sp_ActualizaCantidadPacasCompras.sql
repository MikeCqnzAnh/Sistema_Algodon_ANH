Create Procedure Sp_ActualizaCantidadPacasCompras
@IdContrato int,
@PacasCompradas int,
@PacasDisponibles int
as
update ContratoCompra
set PacasCompradas = @PacasCompradas,
	PacasDisponibles = @PacasDisponibles
where IdContratoAlgodon = @IdContrato