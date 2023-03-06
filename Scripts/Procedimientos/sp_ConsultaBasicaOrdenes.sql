CREATE procedure sp_ConsultaBasicaOrdenes
as
select a.IdOrdenTrabajo,
       b.Descripcion as Planta,
	   c.Nombre as Productor,
	   a.RangoInicio,
	   a.RangoFin,
	   a.PesoModulos,
	   isnull(a.CheckPepena,0) as CheckPepena
from [dbo].[OrdenTrabajo] a,
     [dbo].[Plantas] b,
     [dbo].[Clientes] c
where a.IdPlanta = b.IdPlanta
and   a.IdProductor = c.IdCliente
and   a.IdEstatus = 1
