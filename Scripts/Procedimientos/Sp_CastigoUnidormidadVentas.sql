Create Procedure Sp_CastigoUnidormidadVentas
@Uniformidad float
as
select castigo 
from uniformidadVentas
where @Uniformidad between rango1 and rango2