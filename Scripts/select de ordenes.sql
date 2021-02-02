--CREATE procedure [dbo].[sp_ConsultaModulos]
--as
select distinct bo.IdOrdenTrabajo,
	   Bo.IdBoleta as 'No Modulo',
	   --Bo.IdPlanta, 
	   ot.Predio,
	   pl.descripcion as Planta,
	   --Bo.NoTransporte,
	   isnull(Bo.FechaEntrada,0) as FechaEntrada,
	   --(select MIN(Fecha) from ProduccionDetalle where IdOrdenTrabajo = bo.Idordentrabajo) as FechaProduccion,
	   --isnull(Bo.FechaSalida,0) as FechaSalida, 
	   Bo.Bruto, 
	   Bo.Tara, 
	   Bo.Total, 
	   cl.Nombre 
	   --bo.IdOrdenTrabajo, 
	   --bo.FlagCancelada, 
	   --bo.FlagRevisada 
from [dbo].[OrdenTrabajoDetalle] Bo inner join [dbo].[Clientes] Cl  on Bo.IdProductor = Cl.IdCliente
									inner join plantas pl on bo.idplanta = pl.idplanta
									inner join ordentrabajo ot on ot.idordentrabajo = Bo.IdOrdenTrabajo
where  Bo.FechaEntrada >= '01/12/2020' and  Bo.FechaEntrada <= '31/12/2020'

order by cl.Nombre,ot.Predio,bo.idboleta

--select * from Plantas
--select * from OrdenTrabajo
--select * from [OrdenTrabajoDetalle]


--select * from ProduccionDetalle