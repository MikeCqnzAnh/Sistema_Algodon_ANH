create procedure sp_ConsultaTipoIncidencias
as
select a.IdTipoIncidencia,
       a.Descripcion
from [dbo].[TipoIncidencia] a
where a.IdEstatus = 1