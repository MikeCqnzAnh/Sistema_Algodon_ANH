alter procedure sp_ConsultaModulos
as
select 
	   Bo.IdBoleta,
	   Bo.IdPlanta, 
	   Bo.NoTransporte,
	   isnull(Bo.FechaEntrada,0) as FechaEntrada,
	   isnull(Bo.FechaSalida,0) as FechaSalida, 
	   Bo.Bruto, 
	   Bo.Tara, 
	   Bo.Total, 
	   cl.Nombre, 
	   bo.IdOrdenTrabajo, 
	   bo.FlagCancelada, 
	   bo.FlagRevisada 
from [dbo].[OrdenTrabajoDetalle] Bo inner join [dbo].[Clientes] Cl  on Bo.IdProductor = Cl.IdCliente
order by FechaEntrada desc