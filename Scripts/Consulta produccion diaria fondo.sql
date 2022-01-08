select count(FolioCIA) from ProduccionDetalle where IdOrdenTrabajo = 129 and Fecha between '01/11/2021' and '30/11/2021'

select CAST(fecha AS DATE) AS FechaProduccion 
	  ,count(FolioCIA) as ProduccionDiaria
	  ,IdPlantaOrigen
from ProduccionDetalle
--where Fecha between '01/11/2021' and '30/11/2021'
group by CAST(fecha AS DATE),IdPlantaOrigen
order by CAST(fecha AS DATE)