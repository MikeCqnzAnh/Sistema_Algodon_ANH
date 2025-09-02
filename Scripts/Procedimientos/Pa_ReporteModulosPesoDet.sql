--alter procedure Pa_ReporteModulosPesoDet
--@IdOrdentrabajo int 
--as
select ote.IdOrdenTrabajo
	  ,otd.idboleta as IdModulo
	  ,pla.descripcion as Planta
	  --,ote.IdPlanta 
	  --,ote.IdProductor
	  --,cli.Nombre
	  ,otd.Bruto
	  ,otd.Tara
	  ,otd.Total
	  --,otd.NoTransporte
	  --,ote.Predio
	  ,otd.FechaEntrada
	  ,otd.FechaSalida
	  --,otd.FlagRevisada
	  --,ote.NumeroModulos
from ordentrabajo ote inner join ordentrabajodetalle otd on ote.idordentrabajo = otd.idordentrabajo 
					  inner join clientes cli on ote.idproductor = cli.idcliente
					  inner join plantas pla on otd.idplanta = pla.idplanta
where otd.FechaEntrada between '01/11/2021' and '30/11/2021'
--where ote.idordentrabajo = @IdOrdentrabajo