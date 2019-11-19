Create Procedure Sp_CastigoLargoFibra
--declare
@LargoFibra  float
as
declare 
@Lenght int
set @Lenght =(select LenghtNDS from LargosFibraEquivalente where @LargoFibra >=  Rango1 and @LargoFibra <=  Rango2)

select Castigo 
from LargosDeFibra
where @Lenght between  Rango1 and Rango2