alter Procedure Sp_ConsultaDisponibilidadPacasProductor
as
select	CL.IdCliente
	   ,CL.Nombre
	   ,sum (case when hd.estatuscompra = 1 then 1 else 0 end) Disponibles
	   ,sum (case when hd.estatuscompra = 2 then 1 else 0 end) Compradas
	   ,count (pd.foliocia) ProduccionTotal
from hvidetalle HD right join ProduccionDetalle PD on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.IdOrdenTrabajo = pd.IdOrdenTrabajo and hd.BaleID = pd.foliocia
				   inner join Produccion PE on PD.IdProduccion = PE.IdProduccion
				   inner join Clientes CL on PE.IdCliente = CL.IdCliente
group by cl.IdCliente,CL.Nombre
order by cl.Nombre
