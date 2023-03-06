select count(FolioCIA) from ProduccionDetalle where Fecha between '01/12/2022' and '31/12/2022'

select CAST(fecha AS DATE) AS FechaProduccion 
	  ,count(FolioCIA) as ProduccionDiaria
	  ,IdPlantaOrigen as IdPlanta
from ProduccionDetalle
where CAST(fecha AS DATE) between '01/01/2023' and '31/01/2023'
group by CAST(fecha AS DATE),IdPlantaOrigen
order by CAST(fecha AS DATE)

--go

select CAST(fecha AS DATE) AS FechaProduccion 
	  ,FolioCIA as Folio
	  ,IdPlantaOrigen as IdPlanta
from ProduccionDetalle
where CAST(fecha AS DATE)  between '01/01/2023' and '31/01/2023'
--group by CAST(fecha AS DATE),IdPlantaOrigen
order by CAST(fecha AS DATE)