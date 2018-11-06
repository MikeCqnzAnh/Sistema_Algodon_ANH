create procedure sp_ConsultaDetallePuestos
as
select a.IdPuesto,
       a.Descripcion,
	   a.IdEstatus
from [dbo].[Puestos] a
where a.IdEstatus=1