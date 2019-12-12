create procedure sp_EliminarAsociacion
@IdAsociacion int 
as
Delete
from dbo.Asociaciones 
where IdAsociacion = @IdAsociacion