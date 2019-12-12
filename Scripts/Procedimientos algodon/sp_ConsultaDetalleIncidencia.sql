create procedure sp_ConsultaDetalleIncidencia
as
select a.IdIncidencia,
       a.IdTipo,
       a.Descripcion,
	   a.IdEstatus
from [dbo].[Incidencias] a
where a.IdEstatus = 1