Create Procedure Sp_LlenaComboUniformidadCompra
as
select IdModoEncabezado
	  ,Descripcion 
from UniformidadEncabezado
where ModoComercializacion = 1