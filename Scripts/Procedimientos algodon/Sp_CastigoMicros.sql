Create Procedure Sp_CastigoMicros
@Micros as float
as
select castigo
from Micros
where @Micros between rango1 and Rango2