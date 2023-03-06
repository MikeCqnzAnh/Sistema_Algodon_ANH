create procedure pa_insertaturnoenc
@idturnoenc int output,
@descripcion varchar(40),
@idplanta int,
@idresponsableturno int,
@responsableturno varchar(40),
@idresponsableprensa int,
@responsableprensa varchar(40),
@horaentrada time,
@horasalida time
as
begin
	set nocount on
	merge TurnosEnc as target
	using(select @idturnoenc,
				 @descripcion,
				 @idplanta,
				 @idresponsableturno,
				 @responsableturno,
				 @idresponsableprensa,
				 @responsableprensa,
				 @horaentrada,
				 @horasalida)
	as source(Idturnoenc,
			  descripcion,
			  idplanta,
			  idresponsableturno,
			  responsableturno,
			  idresponsableprensa,
			  responsableprensa,
			  horaentrada,
			  horasalida)
	on (target.idturnoenc = source.idturnoenc)
	when matched then
	update set descripcion = source.descripcion,
			   idplanta = source.idplanta,
			   idresponsableturno = source.idresponsableturno,
			   responsableturno = source.responsableturno,
			   idresponsableprensa = source.idresponsableprensa,
			   responsableprensa = source.responsableprensa,
			   horaentrada = source.horaentrada,
			   horasalida = source.horasalida
	when not matched then
	insert (Descripcion,
			idplanta,
			idresponsableturno,
			responsableturno,
			idresponsableprensa,
			responsableprensa,
			Horaentrada,
			Horasalida)
	values(source.descripcion,
		   source.idplanta,
		   source.idresponsableturno,
		   source.responsableturno,
		   source.idresponsableprensa,
		   source.responsableprensa,
		   source.horaentrada,
		   source.horasalida);
	set @idturnoenc = SCOPE_IDENTITY()
end
return @idturnoenc