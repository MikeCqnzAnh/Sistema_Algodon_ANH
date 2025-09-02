Create Procedure Sp_LlenaComboOrdenTrabajo
@IdProductor int
as
select IdOrdenTrabajo 
from OrdenTrabajo 
where IdProductor = @IdProductor