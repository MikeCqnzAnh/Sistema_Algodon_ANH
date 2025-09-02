create procedure pa_consultaperfilres
@idmodoencabezado int
as
select IdModoDetalle,
	   IdModoEncabezado,
	   rango1,
	   rango2,
	   Castigo
from ResistenciaDetalle
where IdModoEncabezado = @IdModoEncabezado
order by Rango1