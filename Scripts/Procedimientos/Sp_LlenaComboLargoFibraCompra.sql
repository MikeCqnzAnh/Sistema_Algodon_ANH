Create Procedure Sp_LlenaComboLargoFibraCompra
as
select IdModoEncabezado
	  ,Descripcion 
from LargosFibraEncabezado
where ModoComercializacion = 1