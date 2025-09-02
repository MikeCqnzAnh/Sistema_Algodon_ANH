Create Procedure Sp_ConsultaBitacoraUsuario
as
select row_number() over (order by usuario) Id, Usuario 
from BitacoraSistema group by Usuario