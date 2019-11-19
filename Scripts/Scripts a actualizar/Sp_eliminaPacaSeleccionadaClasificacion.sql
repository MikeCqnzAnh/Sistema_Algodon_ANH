CREATE proc Sp_eliminaPacaSeleccionadaClasificacion
@IdPaquete int,
@BaleID int
as
delete CalculoClasificacion 
where IdPaqueteEncabezado = @IdPaquete and baleid = @baleid