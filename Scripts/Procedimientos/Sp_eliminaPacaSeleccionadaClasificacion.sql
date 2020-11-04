alter proc Sp_eliminaPacaSeleccionadaClasificacion
@IdPaquete int,
@BaleID bigint
as
delete CalculoClasificacion 
where IdPaqueteEncabezado = @IdPaquete and baleid = @baleid
