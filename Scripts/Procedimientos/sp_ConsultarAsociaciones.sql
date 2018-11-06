create procedure sp_ConsultarAsociaciones
as
select a.IdAsociacion,
	   a.Descripcion,
	   a.IdEstatus
from [dbo].[Asociaciones] a
where a.IdEstatus = 1