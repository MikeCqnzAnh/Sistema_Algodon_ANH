Create Procedure Sp_ConsultaPaquetesDisponiblesEmbarques
--declare
@Seleccionar bit = 0,
@IdComprador int 
as
select cc.IdPaqueteEncabezado
	  ,count(cc.BaleID) as Cantidad
	  ,sum(cc.Kilos) as Kilos
	  ,@Seleccionar as Seleccionar 
from PaqueteEncabezado pe inner join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado and pe.IdPlanta = cc.idPlantaOrigen
						  inner join ventapacas vp on cc.IdVentaenc = vp.Idventa  
where cc.EstatusVenta = 2 and vp.IdComprador = @IdComprador 
														and cc.BaleID not in  
													(select BaleID 
													 from EmbarqueDetalle 
													 where IdComprador = @IdComprador)
group by cc.IdPaqueteEncabezado 
order by cc.IdPaqueteEncabezado