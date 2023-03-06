create procedure pa_consultaturnoactivo
@idplanta int,
@idturnoenc int
as
select idincidencia,
	   idturnoenc,
	   idplanta,
	   fechaincidencia,
	   idresponsableturno,
	   idresponsableprensa,
	   estatus,
	   fechacreacion,
	   fechaactualizacion
from  incidenciaproduccionenc
where idplanta = @idplanta and idturnoenc = @idturnoenc