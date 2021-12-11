Create Procedure Pa_ConsultaDetalleOrdenes
@IdOrdenTrabajo int
as
select IdBoleta
	  ,IdOrdenTrabajo
	  ,IdPlanta
	  ,FechaOrden
	  ,Bruto
	  ,Tara
	  ,Total
	  ,IdProductor
	  ,IdBodega
	  ,NoTransporte
	  ,FlagCancelada
	  ,FlagRevisada
	  ,IdEstatus
	  ,FechaEntrada
	  ,FechaSalida 
from OrdenTrabajoDetalle
where IdOrdenTrabajo = @IdOrdenTrabajo