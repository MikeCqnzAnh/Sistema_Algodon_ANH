CREATE procedure sp_ConsultaModosCompraEncabezado
as
select a.IdModoEncabezado,
		a.Descripcion,
		a.IdEstatus
from [dbo].[ModosCompraEncabezado] a
where a.IdEstatus = 1