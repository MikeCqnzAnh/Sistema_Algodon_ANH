CREATE procedure [dbo].[sp_ConsultaModulosLiquidacion]
@IdOrdenTrabajo as int
as
select bo.IdOrdenTrabajo, 
	   Bo.IdBoleta,
	   Bo.IdPlanta, 
	   Bo.Bruto, 
	   Bo.Tara, 
	   Bo.Total, 
	   Bo.FechaOrden, 
	   bo.FlagRevisada 
from [dbo].[OrdenTrabajoDetalle] Bo inner join [dbo].[Clientes] Cl  on Bo.IdProductor = Cl.IdCliente
where bo.IdOrdenTrabajo = @IdOrdenTrabajo and   bo.FlagCancelada = 0