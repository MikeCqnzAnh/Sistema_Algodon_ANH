create procedure sp_ConsultaEmpleados
as
select a.IdEmpleado,
       a.Nombre
from [dbo].[Empleados] a
where a.IdEstatus = 1