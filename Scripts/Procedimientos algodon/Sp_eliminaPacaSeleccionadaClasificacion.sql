CREATE proc Sp_eliminaPacaSeleccionadaClasificacion
@IdPaquete int
as
delete CalculoClasificacion 
where IdPaqueteEncabezado = @IdPaquete and Seleccion = 1