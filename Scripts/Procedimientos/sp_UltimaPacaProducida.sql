create proc sp_UltimaPacaProducida
@idplantaOrigen int ,
@idordentrabajo int
as
select isnull(max(IdProduccionDetalle),0) as IdProduccionDetalle
from ProduccionDetalle 
where IdPlantaOrigen = @IdPlantaOrigen and IdOrdenTrabajo = @IdOrdenTrabajo