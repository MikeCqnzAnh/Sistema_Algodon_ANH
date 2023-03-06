alter procedure pa_insertaturnoactivo
@idincidencia int output,
@idturnoenc int,
@idplanta int,
@fechaincidencia datetime,
@idresponsableturno int,
@idresponsableprensa int,
@fechacreacion datetime,
@fechaactualizacion datetime,
@horaactual time
as
declare @estatus bit
if 
set @estatus = (select isnull(ip.estatus,0) as estatus
from TurnosEnc te left join incidenciaproduccionenc ip on te.IdTurnoenc = ip.idturnoenc
where te.idplanta = @idplanta and  @horaactual between te.Horaentrada and te.Horasalida );

if @estatus = 0 
begin

	insert into incidenciaproduccionenc (
				  idturnoenc,
				  idplanta,
				  fechaincidencia,
				  idresponsableturno,
				  idresponsableprensa,
				  fechacreacion,
				  fechaactualizacion,
				  estatus)
	values (@idturnoenc,
			@idplanta,
			@fechaincidencia,
			@idresponsableturno,
			@idresponsableprensa,
			@fechacreacion,
			@fechaactualizacion,
			1);
	set @idincidencia = SCOPE_IDENTITY();
end
