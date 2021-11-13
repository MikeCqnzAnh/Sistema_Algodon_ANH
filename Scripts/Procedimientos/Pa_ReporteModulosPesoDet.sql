alter procedure Pa_ReporteModulosPesoDet
@IdOrdentrabajo int 
as
select ote.IdOrdenTrabajo
	  ,ote.IdPlanta 
	  ,ote.IdProductor
	  ,cli.Nombre
	  ,pla.descripcion as Planta
	  ,otd.idboleta as NoModulo
	  ,otd.Bruto
	  ,otd.Tara
	  ,otd.Total
	  ,otd.NoTransporte
	  ,ote.Predio
	  ,otd.FechaEntrada
	  ,otd.FechaSalida
	  ,otd.FlagRevisada
	  ,ote.NumeroModulos
from ordentrabajo ote inner join ordentrabajodetalle otd on ote.idordentrabajo = otd.idordentrabajo 
					  inner join clientes cli on ote.idproductor = cli.idcliente
					  inner join plantas pla on otd.idplanta = pla.idplanta
where ote.idordentrabajo = @IdOrdentrabajo