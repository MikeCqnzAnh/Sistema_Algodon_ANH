create PROC sp_SeleccionPacaClasificacion
@IdPaquete int,
@BaleID int,
@Seleccion bit
as
update CalculoClasificacion
set Seleccion = @seleccion
where IdPaqueteEncabezado = @IdPaquete AND BaleID = @BaleID