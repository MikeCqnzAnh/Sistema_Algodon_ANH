Create Procedure Sp_ConsultaBitacoraOperacion
as
select row_number() over (order by Operacion) Id, Operacion 
from BitacoraSistema group by Operacion