ALTER PROCEDURE sp_EncontrarPrimerHueco
--declare
@IdPlanta int-- = 1
AS
SELECT TOP 1 FolioCIA + 1 As PrimerHueco
FROM [dbo].[ProduccionDetalle] T
WHERE NOT EXISTS( SELECT 1 FROM [dbo].[ProduccionDetalle] WHERE (FolioCIA = T.FolioCIA + 1) AND IdPlantaOrigen = @IdPlanta)
AND t.IdPlantaOrigen = @IdPlanta


