select li.IdLiquidacion
	  ,ot.idordentrabajo
	  ,pl.Descripcion as Planta
	  ,cl.IdCliente
	  ,cl.Nombre
	  ,(select MIN(Fecha) from ProduccionDetalle where IdOrdenTrabajo = li.Idordentrabajo) as Fecha 
	  ,(select count(baleid) as PacasCompradas from HviDetalle where IdOrdenTrabajo = li.Idordentrabajo and idcompraenc is null) as PacasSinComprar
	  ,(select count(baleid) as PacasCompradas from HviDetalle where IdOrdenTrabajo = li.Idordentrabajo and idcompraenc is not null) as PacasCompradas
	  ,li.totalboletas
	  ,li.totalhueso
	  ,li.TotalPacas
	  ,li.TotalPluma
	  ,li.TotalSemilla
	  ,(select MIN(foliocia) from ProduccionDetalle where IdOrdenTrabajo = li.Idordentrabajo) as PacaIni 
	  ,(select max(foliocia) from ProduccionDetalle where IdOrdenTrabajo = li.Idordentrabajo) as PacaFin  
from LiquidacionesPorRomaneaje li inner join OrdenTrabajo ot on li.IdOrdenTrabajo = ot.IdOrdenTrabajo and li.IdCliente = ot.IdProductor
										   inner join clientes cl on li.IdCliente = cl.IdCliente
										   inner join plantas pl on ot.IdPlanta = pl.IdPlanta


