create procedure sp_ConModComId
@IdModalidadCompra int
as
select a.IdModoDetalle,
       a.IdClasificacion,
	   a.Diferencial
from [dbo].[ModosCompraDetalle] a
where a.IdModoEncabezado = @IdModalidadCompra

