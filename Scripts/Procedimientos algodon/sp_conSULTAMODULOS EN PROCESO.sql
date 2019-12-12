--create proc Sp_ConsultaOrdenLiquidacion
declare
@IdPlantaOrigen as int = 1,
@IdProduccion as int = 2
--as
select cl.IdCliente,
	   cl.Nombre,
	   Aso.Descripcion ,
	   bp.Total,
	   bp.IdOrdenTrabajo,
	   Pr.IdProduccion
	   
from Clientes cl inner join OrdenTrabajo ot on cl.IdCliente = ot.IdProductor
				 inner join Asociaciones Aso on cl.IdCuentaDe = Aso.IdAsociacion
				 left join BoletasPorOrden Bp on ot.IdOrdenTrabajo = Bp.IdOrdenTrabajo and bp.FlagCancelada = 0
				 inner join Produccion Pr on ot.IdOrdenTrabajo = Pr.IdOrdenTrabajo and ot.IdPlanta = Pr.IdPlantaOrigen
				
where ot.IdPlanta = @IdPlantaOrigen and Pr.IdProduccion = @IdProduccion
select * from OrdenTrabajo
--select * from Clientes
--select * from Asociaciones
select * from BoletasPorOrden
select * from Produccion
select * from ProduccionDetalle


select Ot.IdPlanta, ot.IdOrdenTrabajo from OrdenTrabajo Ot inner join Clientes cl on ot.idproductor =  cl.idcliente

select Pr.IdOrdenTrabajo,Pr.IdPlantaOrigen,Pr.Tipo,Cl.Nombre,Aso.Descripcion as PorCuenta,SUM(Bo.Total) as TotalHueso,COUNT(Pd.IdProduccionDetalle) 
from Produccion Pr inner join Clientes Cl on pr.IdCliente = Cl.IdCliente
				   inner join Asociaciones Aso on cl.IdCuentaDe = Aso.IdAsociacion
				   right join BoletasPorOrden Bo on Pr.IdOrdenTrabajo = Bo.IdOrdenTrabajo
				   right join ProduccionDetalle Pd on Pr.IdProduccion = Pd.IdProduccion and Pr.IdOrdenTrabajo = pd.IdOrdenTrabajo
where Bo.Total > 0
group by Pr.IdOrdenTrabajo, Pr.IdPlantaOrigen, Pr.Tipo, Cl.Nombre, Aso.Descripcion, Pd.IdProduccionDetalle




select count(pr.IdProduccion)as NoPacas, sum(pd.Kilos) as Kilos 
from Produccion Pr right join ProduccionDetalle Pd on Pr.IdProduccion = pd.IdProduccion 
group by Pr.IdProduccion

