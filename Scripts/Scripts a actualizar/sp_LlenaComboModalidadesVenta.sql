create proc sp_LlenaComboModalidadesVenta
as
select IdModoEncabezado, Descripcion 
from [ModosVentaEncabezado]
where IdEstatus = 1