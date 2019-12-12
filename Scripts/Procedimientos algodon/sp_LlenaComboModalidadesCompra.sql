create proc sp_LlenaComboModalidadesCompra
as
select IdModoEncabezado, Descripcion 
from [ModosCompraEncabezado]
where IdEstatus = 1