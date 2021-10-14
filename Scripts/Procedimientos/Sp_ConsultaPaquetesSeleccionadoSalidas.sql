CREATE Procedure Sp_ConsultaPaquetesSeleccionadoSalidas
@Seleccionar bit = 0,
@IdSalidaEncabezado int 
as
select cc.IdPaqueteEncabezado
	  ,count(cc.BaleID) as Cantidad
	  ,sum(cc.Kilos) as Kilos
	  ,@Seleccionar as Seleccionar 
from PaqueteEncabezado pe inner join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado and pe.IdPlanta = cc.idPlantaOrigen
						  inner join ventapacas vp on cc.IdVentaenc = vp.Idventa  
where cc.EstatusSalida = 1  and cc.IdSalidaEncabezado  = @IdSalidaEncabezado
group by cc.IdPaqueteEncabezado 
order by cc.IdPaqueteEncabezado