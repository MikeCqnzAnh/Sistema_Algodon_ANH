select*from ##TablaTempModulos	order by IdordenTrabajo

select * from produccion


select ord.IdOrdenTrabajo,cli.nombre,pla.descripcion as Planta,pro.fecha 
										from ordentrabajo ord inner join produccion pro on ord.idordentrabajo = pro.idordentrabajo inner join plantas pla on ord.IdPlanta = pla.IdPlanta 
															  inner join Clientes cli on pro.idcliente = cli.idcliente
										where ord.idordentrabajo in (select DISTINCT IDORDENTRABAJO from ordentrabajodetalle WHERE BRUTO IS NOT NULL AND BRUTO > 0 )
										order by ord.idordentrabajo



select distinct od.idordentrabajo from ordentrabajodetalle od where od.fechaentrada <= '31-10-2020 12:59:59.000' and od.fechaentrada >= '01-10-2020 00:00:00.000'

select od.IdOrdenTrabajo,count(od.IdOrdenTrabajo) as NoModulos,cl.Nombre,pl.Descripcion as Planta--,od.FechaSalida--,od.Bruto,od.Tara,od.total as Neto,cl.nombre 
from ordentrabajodetalle od inner join clientes cl on od.idproductor = cl.idcliente 
									 inner join plantas pl on od.IdPlanta = pl.IdPlanta
where od.fechaentrada >= '01-10-2020 00:00:00.000' and  od.fechaentrada <= '31-10-2020 12:59:59.000'
group by od.IdOrdenTrabajo,
		 cl.nombre,
		 pl.Descripcion
order by od.IdOrdenTrabajo

select od.idordentrabajo,cl.nombre ,pl.Descripcion as Planta,count(od.IdOrdenTrabajo) as 'Cantidad Modulos',CONVERT(DATE,od.fechaentrada) as Fecha
from ordentrabajodetalle od inner join clientes cl on od.idproductor = cl.idcliente 
									 inner join plantas pl on od.IdPlanta = pl.IdPlanta
where od.fechaentrada >= '01-10-2020 00:00:00.000' and  od.fechaentrada <= '31-10-2020 12:59:59.000'
group by cl.nombre,
		 od.idordentrabajo,
		 CONVERT(DATE,od.fechaentrada),
		 pl.Descripcion

		
order by od.IdOrdenTrabajo