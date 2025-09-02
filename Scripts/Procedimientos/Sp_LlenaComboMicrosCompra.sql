Create Procedure Sp_LlenaComboMicrosCompra
as
select IdModoEncabezado
	  ,Descripcion 
from MicrosEncabezado
where ModoComercializacion = 1