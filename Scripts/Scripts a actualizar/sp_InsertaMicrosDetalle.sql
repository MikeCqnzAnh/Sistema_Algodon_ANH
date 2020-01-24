CREATE proc sp_InsertaMicrosDetalle
@IdModoDetalle int,
@IdModoEncabezado int,
@Rango1 decimal(6,2),
@Rango2 decimal(6,2),
@Castigo decimal(6,2),
@IdEstatus int
as
BEGIN
SET NOCOUNT ON
MERGE MicrosDetalle AS TARGET
USING (SELECT @IdModoDetalle,@IdModoEncabezado,@Rango1,@Rango2,@Castigo,@IdEstatus) AS SOURCE (IdModoDetalle,IdModoEncabezado,Rango1,Rango2,Castigo,IdEstatus)
ON (TARGET.IdModoDetalle = SOURCE.IdModoDetalle)
WHEN MATCHED THEN
UPDATE SET 	IdModoEncabezado = SOURCE.IdModoEncabezado,
			Rango1 = SOURCE.Rango1,
			Rango2 = SOURCE.Rango2,
			Castigo = SOURCE.Castigo,
			IdEstatus = SOURCE.IdEstatus
WHEN NOT MATCHED THEN
        INSERT (IdModoEncabezado,Rango1,Rango2,Castigo,IdEstatus)
        VALUES (Source.IdModoEncabezado,Source.Rango1, Source.Rango2,Source.Castigo,Source.IdEstatus);
END