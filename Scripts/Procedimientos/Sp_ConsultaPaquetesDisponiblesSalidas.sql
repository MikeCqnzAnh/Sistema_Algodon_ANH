CREATE Procedure Sp_ConsultaPaquetesDisponiblesSalidas
@Seleccionar bit = 0,
@IdEmbarqueEncabezado int 
as
select cc.IdPaqueteEncabezado
	  ,count(cc.BaleID) as Cantidad
	  ,sum(cc.Kilos) as Kilos
	  ,@Seleccionar as Seleccionar 
from PaqueteEncabezado pe  join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado and pe.IdPlanta = cc.idPlantaOrigen
						   join ventapacas vp on cc.IdVentaenc = vp.Idventa  
where cc.EstatusSalida is null  and cc.IdEmbarqueEncabezado  = @IdEmbarqueEncabezado
group by cc.IdPaqueteEncabezado 
order by cc.IdPaqueteEncabezado