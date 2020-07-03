Create Procedure Sp_LlenaComboResistenciaCompra
as
select IdModoEncabezado
	  ,Descripcion 
from ResistenciaEncabezado
where ModoComercializacion = 1