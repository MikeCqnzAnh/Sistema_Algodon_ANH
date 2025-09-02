Create Procedure Sp_ConsultaEstatusEtiqueta
@IdPlantaOrigen int
as
select LeerEtiqueta 
from FolioEtiqueta 
where IdplantaOrigen = @IdPlantaOrigen