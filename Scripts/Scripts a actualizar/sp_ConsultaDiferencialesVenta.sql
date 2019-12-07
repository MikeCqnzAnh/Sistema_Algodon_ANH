create procedure sp_ConsultaDiferencialesVenta
--declare
@IdModo int-- = 2
as
select b.Descripcion,       
	   c.Descripcion,
	   a.Diferencial
from [dbo].[ModosVentaDetalle] a,
     [dbo].[ModosVentaEncabezado] b,
     [dbo].[ClasesClasificacion] c
where a.IdModoEncabezado = @IdModo
and   a.IdModoEncabezado = b.IdModoEncabezado
and   a.IdClasificacion = c.IdClasificacion
