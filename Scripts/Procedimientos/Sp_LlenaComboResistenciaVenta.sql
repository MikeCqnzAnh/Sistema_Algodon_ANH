Create Procedure Sp_LlenaComboResistenciaVenta
as
select IdModoEncabezado
	  ,Descripcion 
from ResistenciaEncabezado
where ModoComercializacion = 2