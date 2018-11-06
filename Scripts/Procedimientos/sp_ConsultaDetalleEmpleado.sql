create procedure sp_ConsultaDetalleEmpleado
as
select a.IdEmpleado,
		a.Nombre,
		a.IdPuesto,
		a.IdEstatus
from [dbo].[Empleados] a
where a.IdEstatus = 1