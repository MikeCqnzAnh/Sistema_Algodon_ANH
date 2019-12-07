create procedure sp_ConModVenId
@IdModalidadVenta int
as
select a.IdModoDetalle,
       a.IdClasificacion,
	   a.Diferencial
from [dbo].[ModosVentaDetalle] a
where a.IdModoEncabezado = @IdModalidadVenta