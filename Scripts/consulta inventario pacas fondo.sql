select pd.FolioCIA,pl.Descripcion as Planta,isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado
from producciondetalle pd left join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID and pd.IdPlantaOrigen = cc.IdPlantaOrigen
						  inner join plantas pl on pd.IdPlantaOrigen = pl.IdPlanta
where CAST(pd.Fecha AS DATE) <= '31/12/2022'
order by pd.foliocia