Create Procedure Sp_LlenaComboLargoFibraVenta
as
select IdModoEncabezado
	  ,Descripcion 
from LargosFibraEncabezado
where ModoComercializacion = 2