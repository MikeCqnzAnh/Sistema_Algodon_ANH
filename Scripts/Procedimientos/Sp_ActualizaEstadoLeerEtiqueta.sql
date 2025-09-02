Create Procedure Sp_ActualizaEstadoLeerEtiqueta
@IdPlantaOrigen int,
@LeerEtiqueta bit
as
Update FolioEtiqueta
set LeerEtiqueta = @LeerEtiqueta
where IdplantaOrigen = @IdPlantaOrigen
