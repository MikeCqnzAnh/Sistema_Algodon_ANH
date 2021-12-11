--Create procedure Pa_ReporteModulos
declare
@sel bit = 0
--as
select @sel as sel
	  ,ote.IdOrdentrabajo
	  ,ote.IdPlanta
	  ,pla.Descripcion as Planta
	  ,ote.IdProductor
	  ,cli.Nombre
	  ,ote.Rangoinicio
	  ,ote.RangoFin
	  ,ote.NumeroModulos
	  ,(select sum(total) as Bruto from OrdenTrabajoDetalle where idordentrabajo = ote.IdOrdenTrabajo ) as TotalBruto
	  ,ote.Predio 
from OrdenTrabajo ote inner join Clientes cli on ote.IdProductor = cli.IdCliente
					  inner join Plantas pla on ote.IdPlanta= pla.IdPlanta
		