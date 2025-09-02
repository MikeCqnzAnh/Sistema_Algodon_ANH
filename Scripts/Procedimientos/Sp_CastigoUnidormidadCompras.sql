Alter Procedure Sp_CastigoUnidormidadCompras
@IdModoEncabezado int,
@Uniformidad float
as
select castigo 
from UniformidadDetalle 
where @Uniformidad between rango1 and  rango2 and IdmodoEncabezado = @IdModoEncabezado
