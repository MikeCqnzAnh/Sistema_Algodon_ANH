CREATE procedure pa_consultaturnoenc
@idplanta int
as
select IdTurnoenc,
	   Descripcion,
	   idResponsableprensa,
	   idResponsableturno,
	   Horaentrada,
	   Horasalida
from TurnosEnc
where idplanta = @idplanta