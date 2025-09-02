create procedure pa_consultaperfilui
@idmodoencabezado int
as
select IdModoDetalle,
	   IdModoEncabezado,
	   rango1,
	   rango2,
	   Castigo
from UniformidadDetalle
where IdModoEncabezado = @IdModoEncabezado
order by Rango1