Create Procedure Pa_ConsultaPaquetesVenta
@IdVenta int
as
select IdPaqueteEncabezado as 'NoPaquete',
	   IdPlantaOrigen,
	   count(baleid) as Cantidad,
	   IdVentaEnc as IdVenta
from calculoclasificacion 
where idventaenc = @IdVenta 
group by idpaqueteencabezado,IdPlantaOrigen ,idventaenc
order by IdPaqueteEncabezado