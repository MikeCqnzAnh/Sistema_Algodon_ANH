Create Procedure Sp_ConsultaCampos
@NombreTabla as varchar(40)
as
Declare @Modulos VARCHAR(MAX) = '' 

SELECT @Modulos =  @Modulos +',' + convert(varchar(MAX),COLUMN_NAME) from INFORMATION_SCHEMA.COLUMNS  where TABLE_NAME = @NombreTabla
SET @Modulos = SUBSTRING(@Modulos,2,LEN(@Modulos))
SELECT @Modulos AS CadenaCampos