Create Procedure Sp_ConsultaBitacoraModulo
as
select row_number() over (order by Modulo) Id, Modulo 
from BitacoraSistema group by Modulo