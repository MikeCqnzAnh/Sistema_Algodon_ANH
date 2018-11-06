create procedure sp_ConsultaModosCompra
as
select a.IdModoEncabezado,
	   a.Descripcion
from [dbo].[ModosCompraEncabezado] a
where a.IdEstatus = 1
