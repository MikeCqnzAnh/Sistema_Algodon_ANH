CREATE procedure sp_ConPacProdDetCla
--declare
@IdProductor int =1,
@Seleccionar bit = 0 
as
select e.FolioCIA,
	   a.IdOrdenTrabajo,
       d.IdLiquidacion,
	   c.Descripcion,
	   a.BaleId,	
	   e.Kilos,
	   a.Grade,
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