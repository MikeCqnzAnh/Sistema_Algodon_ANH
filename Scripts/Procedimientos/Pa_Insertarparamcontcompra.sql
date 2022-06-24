alter procedure Pa_Insertarparamcontcompra
@IdConfiguracion int output,
@ParamDia1 int,
@ParamMes1 varchar(15),
@ParamTemp1 int,
@ParamMes2 varchar(15),
@ParamTemp2 int,
@ParamMes3 varchar(15),
@ParamPrompesomin decimal(18,2),
@ParamPrompesomax decimal(18,2),
@ParamPesomin decimal(18,2),
@TemporadaAnual int,
@FechaCreacion datetime,
@FechaActualizacion datetime
as 
begin 
set nocount on
merge ConfiguracionParamContratosCompra as target
using (select @IdConfiguracion ,
				@ParamDia1 ,
				@ParamMes1 ,
				@ParamTemp1 ,
				@ParamMes2 ,
				@ParamTemp2 ,
				@ParamMes3 ,
				@ParamPrompesomin ,
				@ParamPrompesomax ,
				@ParamPesomin ,
				@TemporadaAnual ,
				@FechaCreacion ,
				@FechaActualizacion ) 
	AS SOURCE (IdConfiguracion ,
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
				FechaActualizacion )
ON (target.IdConfiguracion = SOURCE.IdConfiguracion)
WHEN MATCHED THEN UPDATE SET 
				ParamDia1 = SOURCE.ParamDia1 ,
				ParamMes1 = SOURCE.ParamMes1 ,
				ParamTemp1 = SOURCE.ParamTemp1 ,
				ParamMes2 = SOURCE.ParamMes2 ,
				ParamTemp2 = SOURCE.ParamTemp2 ,
				ParamMes3 = SOURCE.ParamMes3 ,
				ParamPrompesomin = SOURCE.ParamPrompesomin ,
				ParamPrompesomax = SOURCE.ParamPrompesomax ,
				ParamPesomin = SOURCE.ParamPesomin ,
				TemporadaAnual = SOURCE.TemporadaAnual ,				
				FechaActualizacion = SOURCE.FechaActualizacion
WHEN NOT MATCHED THEN
INSERT (		ParamDia1 ,
				ParamMes1 ,
				ParamTemp1 ,
				ParamMes2 ,
				ParamTemp2 ,
				ParamMes3 ,
				ParamPrompesomin ,
				ParamPrompesomax ,
				ParamPesomin ,
				TemporadaAnual ,
				FechaCreacion,
				FechaActualizacion)
        VALUES (SOURCE.ParamDia1 ,
				SOURCE.ParamMes1 ,
				SOURCE.ParamTemp1 ,
				SOURCE.ParamMes2 ,
				SOURCE.ParamTemp2 ,
				SOURCE.ParamMes3 ,
				SOURCE.ParamPrompesomin ,
				SOURCE.ParamPrompesomax ,
				SOURCE.ParamPesomin ,
				SOURCE.TemporadaAnual ,
				SOURCE.FechaCreacion ,
				SOURCE.FechaActualizacion);
		SET @IdConfiguracion = SCOPE_IDENTITY()
		END
