create procedure sp_ConsultaExtPuestos
as
select a.IdPuesto,
		a.Descripcion
from [dbo].[Puestos] a
where a.IdEstatus = 1