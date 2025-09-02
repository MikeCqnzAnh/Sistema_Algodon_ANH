alter Procedure Sp_CastigoMicros
@IdModoEncabezado int,
@Micros as float
as
select castigo
from MicrosDetalle
where @Micros between rango1 and Rango2 and IdModoEncabezado = @IdModoEncabezado