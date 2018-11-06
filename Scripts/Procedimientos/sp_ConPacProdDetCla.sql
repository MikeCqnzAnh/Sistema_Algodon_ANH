alter procedure sp_ConPacProdDetCla
--declare
@IdProductor int,
@Seleccionar bit = 0 
as
select e.FolioCIA,
	   a.IdOrdenTrabajo,
       d.IdLiquidacion,
	   c.Descripcion,
	   a.BaleId,	
	   e.Kilos,
	   a.Clase,
	   @Seleccionar as Seleccionar
from [dbo].[CalculoClasificacion] a,
     [dbo].[OrdenTrabajo] b,
     [dbo].[Plantas] c,
     [dbo].[LiquidacionesPorRomaneaje] d,
     [dbo].[ProduccionDetalle] e
where a.IdOrdenTrabajo = b.IdOrdenTrabajo
and   b.IdPlanta = c.IdPlanta
and   b.IdProductor = @Idproductor
and   a.IdOrdenTrabajo = d.IdOrdenTrabajo
and   a.BaleId = e.FolioCIA
and   a.FlagTerminado = 1



