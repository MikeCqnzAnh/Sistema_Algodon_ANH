CREATE proc sp_InsertaModoVentaDetalle
@IdModoDetalle int,
@IdModoEncabezado int,
@IdClasificacion Int,
@Diferencial int
as
BEGIN
SET NOCOUNT ON
MERGE ModosVentaDetalle AS TARGET
USING (SELECT @IdModoDetalle
			 ,@IdModoEncabezado
			 ,@IdClasificacion
			 ,@Diferencial) AS SOURCE 
			 (IdModoDetalle
			 ,IdModoEncabezado
			 ,IdClasificacion
			 ,Diferencial)
ON (TARGET.IdModoDetalle = SOURCE.IdModoDetalle)
WHEN MATCHED THEN
UPDATE SET 	IdModoEncabezado = SOURCE.IdModoEncabezado,
			IdClasificacion = SOURCE.IdClasificacion,
			Diferencial = SOURCE.Diferencial			
WHEN NOT MATCHED THEN
        INSERT (IdModoEncabezado
			   ,IdClasificacion
			   ,Diferencial)
        VALUES (Source.IdModoEncabezado
			   ,Source.IdClasificacion
			   ,Source.Diferencial);
END