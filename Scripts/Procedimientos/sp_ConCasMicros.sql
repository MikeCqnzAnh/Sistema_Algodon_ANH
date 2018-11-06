create procedure sp_ConCasMicros
as
select a.IdMicro,
       a.Rango1,
	   a.Rango2,
	   a.castigo
from [dbo].[Micros] a
where a.IdEstatus = 1
