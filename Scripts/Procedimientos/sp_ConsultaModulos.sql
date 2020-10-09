alter procedure [dbo].[sp_ConsultaModulos]
as
select 
	   Bo.IdBoleta,
	   Bo.IdPlanta, 
	   Bo.NoTransporte,
	   Bo.FechaEntrada,
	   Bo.FechaSalida, 
	   Bo.Bruto, 
	   Bo.Tara, 
	   Bo.Total, 
	   cl.Nombre, 
	   bo.IdOrdenTrabajo, 
	   bo.FlagCancelada, 
	   bo.FlagRevisada 
from [dbo].[OrdenTrabajoDetalle] Bo inner join [dbo].[Clientes] Cl  on Bo.IdProductor = Cl.IdCliente
order by FechaEntrada desc