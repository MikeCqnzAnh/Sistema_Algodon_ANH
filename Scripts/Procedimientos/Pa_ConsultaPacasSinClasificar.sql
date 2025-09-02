create Procedure Pa_ConsultaPacasSinClasificar
@IdOrdenTrabajo int
as
select pd.idproduccion
	  ,pd.FolioCIA
	  ,pd.Kilos
	  ,pd.Fecha 
	  ,case 
	  when isnull(hd.baleid,0) = 0 then CAST(0 AS BIT)
	  else CAST(1 AS BIT) 
	  end as Sel
from ProduccionDetalle pd left join hvidetalle hd on pd.idordentrabajo = hd.idordentrabajo and pd.IdPlantaOrigen = hd.IdPlantaOrigen and pd.foliocia = hd.baleid
where pd.IdOrdenTrabajo = @IdOrdenTrabajo
order by pd.FolioCIA