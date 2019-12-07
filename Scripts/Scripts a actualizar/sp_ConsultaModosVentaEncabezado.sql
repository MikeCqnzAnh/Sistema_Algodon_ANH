CREATE procedure sp_ConsultaModosVentaEncabezado
as
select a.IdModoEncabezado,
		a.Descripcion,
		a.IdEstatus
from [dbo].[ModosVentaEncabezado] a
where a.IdEstatus = 1