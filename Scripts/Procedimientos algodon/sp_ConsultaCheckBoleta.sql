CREATE procedure sp_ConsultaCheckBoleta
@IdOrdenTrabajo int
as
select isnull(cc.FlagTerminado ,0) as FlagTerminado 
from ProduccionDetalle pd left join CalculoClasificacion cc 
on pd.IdOrdenTrabajo = cc.IdOrdenTrabajo and pd.FolioCIA = cc.BaleID
where cc.IdOrdenTrabajo = @IdOrdenTrabajo
