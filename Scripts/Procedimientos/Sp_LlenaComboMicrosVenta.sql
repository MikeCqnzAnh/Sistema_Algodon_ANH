Create Procedure Sp_LlenaComboMicrosVenta
as
select IdModoEncabezado
	  ,Descripcion 
from MicrosEncabezado
where ModoComercializacion = 2