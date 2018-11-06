create procedure sp_ConsultaEstados
as
select a.IdEstado,
       a.Descripcion
from Estados a
where IdEstatus = 1