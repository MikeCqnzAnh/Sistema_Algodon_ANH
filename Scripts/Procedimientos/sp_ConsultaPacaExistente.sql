alter procedure sp_ConsultaPacaExistente
--DECLARE
@FolioCIA int ,
@IdPlantaOrigen int  
AS
BEGIN
DECLARE @resultado INT
IF exists (select 1 from [dbo].[ProduccionDetalle] a where a.FolioCIA = @FolioCIA and IdPlantaOrigen = @IdPlantaOrigen)
			BEGIN
				SET @resultado = 1
				--PRINT @resultado
				select (@resultado) as Resultado
			END
		ELSE
			BEGIN
				SET @resultado = 0
				--PRINT @resultado
				select (@resultado)  as Resultado
			END		
END
exec sp_ConsultaPacaExistente @FolioCIA,@IdPlantaOrigen