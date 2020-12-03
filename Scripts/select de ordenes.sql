CREATE procedure [dbo].[sp_ConsultaModulos]
as
select bo.IdOrdenTrabajo,
	   Bo.IdBoleta as 'No Modulo',
	   --Bo.IdPlanta, 
	   pl.descripcion as Planta,
	   --Bo.NoTransporte,
	   isnull(Bo.FechaEntrada,0) as FechaEntrada,
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
--where BO.Bruto IS NOT NULL AND BO.Bruto > 0
order by bo.IdBoleta asc

select * from Plantas
select * from [OrdenTrabajoDetalle]