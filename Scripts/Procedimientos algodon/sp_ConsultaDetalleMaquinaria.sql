create procedure sp_ConsultaDetalleMaquinaria
as
select a.IdMaquinaria,
		a.Descripcion,
		a.IdEstatus
from [dbo].[Maquinaria] a
where a.IdEstatus = 1