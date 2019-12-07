create procedure sp_ConsultaModosVenta
as
select a.IdModoEncabezado,
	   a.Descripcion
from [dbo].[ModosVentaEncabezado] a
where a.IdEstatus = 1
