create procedure sp_ConsultaDiferenciales
--declare
@IdModo int-- = 2
as
select b.Descripcion,       
	   c.Descripcion,
	   a.Diferencial
from [dbo].[ModosCompraDetalle] a,
     [dbo].[ModosCompraEncabezado] b,
     [dbo].[ClasesClasificacion] c
where a.IdModoEncabezado = @IdModo
and   a.IdModoEncabezado = b.IdModoEncabezado
and   a.IdClasificacion = c.IdClasificacion
