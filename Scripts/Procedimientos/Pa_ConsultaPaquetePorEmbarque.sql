Create Procedure Pa_ConsultaPaquetePorEmbarque
@IdEmbarqueEncabezado int ,
@seleccionar bit = 0
as
Select IdPaqueteEncabezado,
	   count(BaleID) as Cantidad,
	   sum(Kilos) as Kilos,
	   @seleccionar as Seleccionar
from CalculoClasificacion
where IdEmbarqueEncabezado = @IdEmbarqueEncabezado
group by  IdPaqueteEncabezado,IdEmbarqueEncabezado