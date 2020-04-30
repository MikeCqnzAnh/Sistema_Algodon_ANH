select * from clientes
select * from Produccion
select * from ProduccionDetalle
select * from HviDetalle
select * from OrdenTrabajo
select * from OrdenTrabajoDetalle

select * from hvidetalle
select * from ProduccionDetalle

select	CL.IdCliente
	   ,CL.Nombre
	   ,case 
			when hd.estatuscompra = 1 then COUNT(PD.FolioCIA) 
			
		end as Disponibles
	   ,case 
			when hd.estatuscompra = 2 then COUNT(PD.FolioCIA) 
			
		end as Compradas
	   ,COUNT(PD.FolioCIA) as TotalProducida
from hvidetalle HD inner join ProduccionDetalle PD on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.IdOrdenTrabajo = pd.IdOrdenTrabajo and hd.BaleID = pd.foliocia
				   inner join Produccion PE on PD.IdProduccion = PE.IdProduccion
				   inner join Clientes CL on PE.IdCliente = CL.IdCliente
--where hd.estatuscompra = 1
group by cl.IdCliente,CL.Nombre,hd.estatuscompra
order by cl.Nombre

select	CL.IdCliente,CL.Nombre,COUNT(PD.FolioCIA) as ProduccionTotal
from hvidetalle HD inner join ProduccionDetalle PD on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.IdOrdenTrabajo = pd.IdOrdenTrabajo and hd.BaleID = pd.foliocia
				   inner join Produccion PE on PD.IdProduccion = PE.IdProduccion
				   inner join Clientes CL on PE.IdCliente = CL.IdCliente
group by cl.IdCliente,CL.Nombre
order by cl.Nombre 

select distinct estatuscompra from hvidetalle