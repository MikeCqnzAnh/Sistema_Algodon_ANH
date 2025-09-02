CREATE procedure pa_consultaperfiluhmldetalle
@idmodoencabezado int,
@sel bit = 0
as
select idmododetalle,
		idmodoencabezado,
		rango1,
		rango2,
		lenghtNDS,
		castigo,
		@sel as sel
from perfiluhmldetalle
where idmodoencabezado = @idmodoencabezado
order by lenghtNDS