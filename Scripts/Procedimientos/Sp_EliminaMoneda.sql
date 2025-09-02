CREATE Procedure Sp_EliminaMoneda
@IdMoneda int,
@IdEstatus int,
@IdUsuarioActualizacion int,
@FechaActualizacion datetime
as
Update moneda
set IdEstatus = @IdEstatus,
	IdUsuarioActualizacion = @IdUsuarioActualizacion,
	FechaActualizacion = @FechaActualizacion
where idMoneda = @IdMoneda