create procedure sp_ActualizarEtiqueta
@IdPlantaOrigen int,
@EtiquetaActual int
as
UPDATE [dbo].[FolioEtiqueta] 
SET    Secuencia = @EtiquetaActual
WHERE  IdplantaOrigen = @IdPlantaOrigen