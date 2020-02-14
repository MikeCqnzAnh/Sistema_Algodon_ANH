Create Procedure Sp_LlenaComboUniformidadVenta
as
select IdModoEncabezado
	  ,Descripcion 
from UniformidadEncabezado
where ModoComercializacion = 2