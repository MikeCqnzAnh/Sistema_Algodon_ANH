CREATE procedure sp_ConsultaProdPorPorOrden
--declare
@IdOrdenTrabajo int --= 1
as
select a.IdProduccion,
       a.IdPlantaOrigen,
	   a.IdPlantaDestino,
	   a.Fecha,
	   a.Tipo,
	   b.IdCliente,
	   b.Nombre,
	   c.Secuencia
from [dbo].[Produccion] a,
     [dbo].[Clientes] b,
	 [dbo].[FolioEtiqueta] c
where a.IdOrdenTrabajo = @IdOrdenTrabajo
and   a.IdCliente = b.IdCliente
and   a.IdPlantaOrigen = c.IdplantaOrigen
and a.IdEstatus = 1

