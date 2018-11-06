alter procedure sp_ConsultaPaqueteEncabezadoDetalle
@IdPaquete int 
as
select a.IdPaquete,
       a.IdPlanta,
	   a.IdClase,
	   a.CantidadPacas,
	   a.Descripcion,
	   a.chkrevisado,
	   a.IdEstatus
from [dbo].[PaqueteEncabezado] a
where a.IdPaquete = @IdPaquete
and   a.IdEstatus = 1
