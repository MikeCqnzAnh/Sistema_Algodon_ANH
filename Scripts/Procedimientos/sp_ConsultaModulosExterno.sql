CREATE procedure sp_ConsultaModulosExterno
@idordentrabajo int 
as
select 
	   Bo.IdBoleta,
	   Bo.IdPlanta, 
	   Bo.NoTransporte,
	   Bo.FechaOrden, 
	   Bo.Bruto, 
	   Bo.Tara, 
	   Bo.Total, 
	   cl.Nombre, 
	   bo.IdOrdenTrabajo, 
	   bo.FlagCancelada, 
	   bo.FlagRevisada 
from [dbo].[OrdenTrabajoDetalle] Bo inner join [dbo].[Clientes] Cl  on Bo.IdProductor = Cl.IdCliente
where IdOrdenTrabajo = @idordentrabajo