Create Procedure Sp_ConsultarOrdenRevision
@IdOrdenTrabajo int
as
select IdOrdenTrabajo
	  ,IdProduccion
	  ,IdplantaOrigen
	  ,min(FolioCIA) as PrimerPaca
	  ,max(FolioCIA) as UltimaPaca
	  ,count(Foliocia) as PacasProducidas 
	  ,round(avg(kilos),0,1) as PesoPromedio
	  ,(select top 1 FolioCIA from ProduccionDetalle where idordentrabajo = @IdOrdenTrabajo and  kilos in ( select min(kilos) from ProduccionDetalle where IdOrdenTrabajo = @IdOrdenTrabajo)) as EtiquetaPacaLigera
	  ,min(Kilos) as PacaLigera
	  ,(select top 1FolioCIA from ProduccionDetalle where idordentrabajo = @IdOrdenTrabajo and  kilos in ( select max(kilos) from ProduccionDetalle where IdOrdenTrabajo = @IdOrdenTrabajo)) as EtiquetaPacaPesada
	  ,max(Kilos) as PacaPesada
from ProduccionDetalle 
where idordentrabajo = @IdOrdenTrabajo
group by IdOrdenTrabajo
		,IdProduccion
		,IdPlantaOrigen 