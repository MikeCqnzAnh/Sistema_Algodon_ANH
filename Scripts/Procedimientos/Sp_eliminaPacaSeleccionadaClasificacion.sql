create proc Sp_eliminaPacaSeleccionadaClasificacion
@IdPaquete int
as
delete CalculoClasificacion 
where @IdPaquete = IdPaqueteEncabezado and Seleccion = 1