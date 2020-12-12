alter Procedure Sp_ReporteResumenLiquidacion
@IdProductor int,
@IdPlanta int,
@Desde int,
@Hasta int
as
if @IdProductor = 0 and @IdPlanta = 0 and @Desde = 0 and @Hasta = 0
begin
select li.IdLiquidacion
	  ,ot.idordentrabajo
	  ,pl.Descripcion as Planta
	  ,cl.IdCliente
	  ,cl.Nombre
	  ,li.Fecha
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
order by li.IdLiquidacion
end
else if @IdProductor > 0 and @IdPlanta = 0 and @Desde = 0 and @Hasta = 0
begin
select li.IdLiquidacion
	  ,ot.idordentrabajo
	  ,pl.Descripcion as Planta
	  ,cl.IdCliente
	  ,cl.Nombre
	  ,li.Fecha
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
where li.IdCliente = @IdProductor
order by li.IdLiquidacion
end
else if @IdProductor > 0 and @IdPlanta > 0 and @Desde = 0 and @Hasta = 0
begin
select li.IdLiquidacion
	   ,ot.idordentrabajo
	  ,pl.Descripcion as Planta
	  ,cl.IdCliente
	  ,cl.Nombre
	  ,li.Fecha
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
where li.IdCliente = @IdProductor and ot.idplanta = @IdPlanta
order by li.IdLiquidacion
end
else if @IdProductor = 0 and @IdPlanta > 0 and @Desde = 0 and @Hasta = 0
begin
select li.IdLiquidacion
	   ,ot.idordentrabajo
	  ,pl.Descripcion as Planta
	  ,cl.IdCliente
	  ,cl.Nombre
	  ,li.Fecha
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
where ot.idplanta = @IdPlanta
order by li.IdLiquidacion
end
else if @IdProductor > 0 and @IdPlanta = 0 and @Desde > 0 and @Hasta > 0
begin
select li.IdLiquidacion
	   ,ot.idordentrabajo
	  ,pl.Descripcion as Planta
	  ,cl.IdCliente
	  ,cl.Nombre
	  ,li.Fecha
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
where li.IdCliente = @IdProductor and li.IdLiquidacion between @Desde and @Hasta 
order by li.IdLiquidacion
end
else if @IdProductor > 0 and @IdPlanta > 0 and @Desde > 0 and @Hasta > 0
begin
select li.IdLiquidacion
	   ,ot.idordentrabajo
	  ,pl.Descripcion as Planta
	  ,cl.IdCliente
	  ,cl.Nombre
	  ,li.Fecha
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
where li.IdCliente = @IdProductor and  ot.idplanta = @IdPlanta and li.IdLiquidacion between @Desde and @Hasta 
order by li.IdLiquidacion
end
else if @IdProductor = 0 and @IdPlanta > 0 and @Desde > 0 and @Hasta > 0
begin
select li.IdLiquidacion
	  ,ot.idordentrabajo
	  ,pl.Descripcion as Planta
	  ,cl.IdCliente
	  ,cl.Nombre
	  ,li.Fecha
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
where ot.idplanta = @IdPlanta and li.IdLiquidacion between @Desde and @Hasta 
order by li.IdLiquidacion
end
