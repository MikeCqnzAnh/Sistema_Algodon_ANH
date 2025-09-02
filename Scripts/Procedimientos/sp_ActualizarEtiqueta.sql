alter procedure sp_ActualizarEtiqueta
@IdPlantaOrigen int,
@EtiquetaActual bigint
as
UPDATE [dbo].[FolioEtiqueta] 
SET    Secuencia = @EtiquetaActual
WHERE  IdplantaOrigen = @IdPlantaOrigen