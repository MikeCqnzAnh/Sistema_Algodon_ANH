create procedure sp_ConsultaDetalleEmpleado
as
select em.IdEmpleado, 
	   em.Nombre, 
	   pu.Descripcion,
	   em.IdPuesto,
	   em.IdEstatus 
from empleados em LEFT join puestos pu on em.IdPuesto = pu.IdPuesto
WHERE em.IdEstatus = 1