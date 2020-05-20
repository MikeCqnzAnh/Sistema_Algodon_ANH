alter Procedure Sp_ConsultaPaquetesDisponiblesEmbarques
--declare
@Seleccionar bit = 0,
@IdComprador int 
as
select cc.IdPaqueteEncabezado
	  ,count(cc.BaleID) as Cantidad
	  ,sum(cc.Kilos) as Kilos
	  ,@Seleccionar as Seleccionar 
from PaqueteEncabezado pe inner join CalculoClasificacion cc 
on pe.IdPaquete = cc.IdPaqueteEncabezado and pe.IdPlanta = cc.idPlantaOrigen
where cc.EstatusVenta = 2 and pe.IdComprador = @IdComprador and cc.BaleID not in  
													(select BaleID 
													 from EmbarqueDetalle 
													 where IdComprador = @IdComprador)
group by cc.IdPaqueteEncabezado 
order by cc.IdPaqueteEncabezado