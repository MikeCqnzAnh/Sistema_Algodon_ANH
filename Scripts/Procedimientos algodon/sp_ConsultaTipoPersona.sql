create procedure sp_ConsultaTipoPersona
as
select a.IdTipoPersona,
       a.Descripcion
from TipoPersona a
where IdEstatus = 1