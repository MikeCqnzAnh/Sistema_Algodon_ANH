Create Procedure Sp_CastigoUnidormidadCompras
@Uniformidad float
as
select castigo 
from uniformidadCompras 
where @Uniformidad between rango1 and  rango2