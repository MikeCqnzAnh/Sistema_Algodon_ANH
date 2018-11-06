--alter procedure sp_ConsultaCheckBoleta
DECLARE
@IdOrdenTrabajo int = 1 
--as
select a.FlagTerminado
from [dbo].[CalculoClasificacion] a
where a.IdOrdenTrabajo = @IdOrdenTrabajo




SELECT*FROM [dbo].[CalculoClasificacion]


UPDATE [dbo].[CalculoClasificacion]
SET    FlagTerminado = 1
WHERE  IdOrdenTrabajo = 1