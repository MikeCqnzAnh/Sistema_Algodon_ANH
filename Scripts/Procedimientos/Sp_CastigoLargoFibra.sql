Create Procedure Sp_CastigoLargoFibra
@LargoFibra as float
as
select Castigo 
from LargosDeFibra
where @LargoFibra between  Rango1 and Rango2