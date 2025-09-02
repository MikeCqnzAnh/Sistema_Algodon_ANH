Create Procedure Sp_ConsultaProduccionPesos
@IdOrdentrabajo int ,
@KilosElegir int ,
@NumRegistros int ,
@PesoElegir bit 
as
if @PesoElegir = 0
begin
	select top (@NumRegistros) foliocia as Etiqueta
		  ,Kilos 
	from ProduccionDetalle 
	where IdOrdenTrabajo = @IdOrdentrabajo and kilos <= @KilosElegir
	order by kilos
end
else if  @PesoElegir = 1
begin
	select top (@NumRegistros) foliocia as Etiqueta
		  ,Kilos 
	from ProduccionDetalle 
	where IdOrdenTrabajo = @IdOrdentrabajo and kilos >= @KilosElegir
	order by kilos desc
end