Create Procedure Sp_ConsultaUniformidadEncabezado
as
select IdModoEncabezado,
	   Descripcion,
	   ModoComercializacion,
	   IdEstatus
from UniformidadEncabezado