Create Procedure Sp_OpcionesSubMenu
@IdMenuDetalle int
as
Select IdOpciones,Nombre 
from OpcionesSubMenu
where IdMenuDetalle = @IdMenuDetalle