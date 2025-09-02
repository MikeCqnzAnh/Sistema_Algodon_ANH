Alter Procedure Sp_CastigoLargoFibra
--declare
@IdModoEncabezado int,
@LargoFibra  float
as
declare 
@Lenght int
set @Lenght =(select LenghtNDS from LargosFibraEquivalenteDetalle where @LargoFibra >=  Rango1 and @LargoFibra <=  Rango2 and IdModoEncabezado = @IdModoEncabezado)

select Castigo 
from LargosFibraDetalle
where @Lenght between  Rango1 and Rango2 and IdModoEncabezado = @IdModoEncabezado
