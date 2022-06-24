alter Procedure Pa_Consultaparamcontcompra
--declare
@IdConfiguracion int=1
as
select IdConfiguracion,
		ParamDia1 ,
		ParamMes1 ,
		ParamTemp1 ,
		ParamMes2 ,
		ParamTemp2 ,
		ParamMes3 ,
		ParamPrompesomin ,
		ParamPrompesomax ,
		ParamPesomin ,
		TemporadaAnual ,
		FechaCreacion ,
		FechaActualizacion 
from ConfiguracionParamContratosCompra
where idconfiguracion = @IdConfiguracion