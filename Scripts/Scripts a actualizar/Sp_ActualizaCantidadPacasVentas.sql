Create Procedure Sp_ActualizaCantidadPacasVentas
@IdContrato int,
@PacasVendidas int,
@PacasDisponibles int
as
update ContratoVenta
set PacasVendidas = @PacasVendidas,
	PacasDisponibles = @PacasDisponibles
where IdContratoAlgodon = @IdContrato