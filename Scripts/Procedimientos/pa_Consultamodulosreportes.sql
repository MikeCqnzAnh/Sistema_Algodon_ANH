alter procedure pa_Consultamodulosreportes
as
select ot.IdOrdenTrabajo as OrdenTrabajo
	  ,cl.Nombre
	  ,pl.Descripcion as Planta
	  ,co.Descripcion as Colonia
	  ,ot.Predio
	  ,od.IdBoleta as Modulo
	  ,od.NoTransporte
	  ,od.Bruto
	  ,od.Tara,od.total as Neto
	  ,od.FechaEntrada
	  ,od.FechaSalida
	  ,RIGHT( CONVERT(DATETIME, od.FechaEntrada, 0),8) AS HrEntrada
from OrdenTrabajo ot right join OrdenTrabajoDetalle od on ot.IdOrdenTrabajo = od.IdOrdenTrabajo and ot.IdPlanta = od.IdPlanta
					 inner join clientes cl on od.idproductor = cl.idcliente
					 inner join Colonias co on ot.IdColonia = co.IdColonia
					 inner join plantas pl on ot.idplanta = pl.idplanta