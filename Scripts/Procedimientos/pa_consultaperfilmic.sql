create procedure pa_consultaperfilmic
@idmodoencabezado int
as
select IdModoDetalle,
	   IdModoEncabezado,
	   rango1,
	   rango2,
	   Castigo
from MicrosDetalle
where IdModoEncabezado = @IdModoEncabezado
order by Rango1