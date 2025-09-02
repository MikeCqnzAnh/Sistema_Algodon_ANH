create procedure sp_InsertarUnidadComercializacion
@IdUnidadPeso int output,
@Descripcion varchar(30),
@ValorConversion float
as
begin
set nocount on
merge [dbo].[UnidadPesoVenta] as target
using (select @IdUnidadPeso
			 ,@Descripcion
			 ,@ValorConversion) AS SOURCE 
			 (IdUnidadPeso
			 ,Descripcion
			 ,ValorConversion)
ON (target.IdUnidadPeso = SOURCE.IdUnidadPeso)
WHEN MATCHED THEN
UPDATE SET Descripcion = Source.Descripcion,
		   ValorConversion = source.ValorConversion
WHEN NOT MATCHED THEN
        INSERT (Descripcion
			   ,ValorConversion)
        VALUES (source.Descripcion
			   ,source.ValorConversion);
		SET @IdUnidadPeso = SCOPE_IDENTITY()
END
RETURN @IdUnidadPeso