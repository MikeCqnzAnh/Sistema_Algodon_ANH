CREATE proc sp_InsertaLargoFibraEquivalente 
@IdLargoFibraDetalle int,
@IdModoEncabezado int,
@ModoComercializacion int,
@Rango1 decimal(6,2),
@Rango2 decimal(6,2),
@LenghtNDS int
as
BEGIN
SET NOCOUNT ON
MERGE LargosFibraEquivalenteDetalle AS TARGET
USING (SELECT @IdLargoFibraDetalle,@IdModoEncabezado,@ModoComercializacion,@Rango1,@Rango2,@LenghtNDS) AS SOURCE (IdLargoFibraDetalle,IdModoEncabezado,ModoComercializacion,Rango1,Rango2,LenghtNDS)
ON (TARGET.IdLargoFibraDetalle = SOURCE.IdLargoFibraDetalle)
WHEN MATCHED THEN
UPDATE SET 	IdModoEncabezado = SOURCE.IdModoEncabezado,
			ModoComercializacion = SOURCE.ModoComercializacion,
			Rango1 = SOURCE.Rango1,
			Rango2 = SOURCE.Rango2,
			LenghtNDS = SOURCE.LenghtNDS
WHEN NOT MATCHED THEN
        INSERT (IdModoEncabezado,Rango1,Rango2,LenghtNDS)
        VALUES (Source.IdModoEncabezado,Source.Rango1, Source.Rango2,Source.LenghtNDS);
END