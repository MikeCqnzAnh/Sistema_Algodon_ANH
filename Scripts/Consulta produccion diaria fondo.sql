select count(FolioCIA) from ProduccionDetalle where IdOrdenTrabajo = 129 and Fecha between '01/01/2022' and '31/01/2022'

select CAST(fecha AS DATE) AS FechaProduccion 
	  ,count(FolioCIA) as ProduccionDiaria
	  ,IdPlantaOrigen
from ProduccionDetalle
where Fecha between '01/01/2022' and '31/01/2022'
group by CAST(fecha AS DATE),IdPlantaOrigen
order by CAST(fecha AS DATE)