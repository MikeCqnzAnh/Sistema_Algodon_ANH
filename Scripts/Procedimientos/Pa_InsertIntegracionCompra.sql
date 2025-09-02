Create Procedure Pa_InsertIntegracionCompra
@IdIntegracionCompra int output,
@IdContrato int,
@IdCompra int,
@IdProductor int,
@ImporteFacturas decimal(18,5),
@TotalToneladasFacturas decimal(18,5),
@TotalPacasFacturas integer,
@FechaCreacion datetime,
@FechaActualizacion datetime
as 
begin 
set nocount on
merge IntegracionCompra as target
using (select @IdIntegracionCompra ,
			  @IdContrato ,
			  @IdCompra ,
			  @IdProductor ,
			  @ImporteFacturas ,
			  @TotalToneladasFacturas ,
			  @TotalPacasFacturas ,
			  @FechaCreacion ,
			  @FechaActualizacion ) 
	AS SOURCE (IdIntegracionCompra ,
			   IdContrato ,
			   IdCompra ,
			   IdProductor ,
			   ImporteFacturas ,
			   TotalToneladasFacturas ,
			   TotalPacasFacturas ,
			   FechaCreacion ,
			   FechaActualizacion)
ON (target.IdIntegracionCompra = SOURCE.IdIntegracionCompra)
WHEN MATCHED THEN
UPDATE SET 	   IdContrato = SOURCE.IdContrato ,
			   IdCompra = SOURCE.IdCompra ,
			   IdProductor = SOURCE.IdProductor ,
			   ImporteFacturas = SOURCE.ImporteFacturas ,
			   TotalToneladasFacturas = SOURCE.TotalToneladasFacturas ,
			   TotalPacasFacturas = SOURCE.TotalPacasFacturas ,
			   FechaActualizacion = SOURCE.FechaActualizacion
WHEN NOT MATCHED THEN
INSERT (	   IdContrato ,
			   IdCompra ,
			   IdProductor ,
			   ImporteFacturas ,
			   TotalToneladasFacturas ,
			   TotalPacasFacturas ,
			   FechaCreacion ,
			   FechaActualizacion)
        VALUES (source.IdContrato
			   ,source.IdCompra
			   ,source.IdProductor
			   ,source.ImporteFacturas
			   ,source.TotalToneladasFacturas
			   ,source.TotalPacasFacturas
			   ,source.FechaCreacion
			   ,source.FechaActualizacion);
		SET @IdIntegracionCompra = SCOPE_IDENTITY()
		END
RETURN @IdIntegracionCompra