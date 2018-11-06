create procedure sp_ConsultaAsociaciones
as 
select a.IdAsociacion,
       a.Descripcion
from Asociaciones a
where a.IdEstatus = 1