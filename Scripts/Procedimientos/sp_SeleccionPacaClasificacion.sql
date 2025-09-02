alter Procedure sp_SeleccionPacaClasificacion
@IdPaquete int,
@BaleID bigint,
@Seleccion bit
as
update CalculoClasificacion
set Seleccion = @seleccion
where IdPaqueteEncabezado = @IdPaquete AND BaleID = @BaleID