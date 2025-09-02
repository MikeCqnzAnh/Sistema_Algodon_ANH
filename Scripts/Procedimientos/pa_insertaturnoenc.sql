create procedure pa_insertaturnoenc
@idturnoenc int output,
@descripcion varchar(40),
@idplanta int,
@horaentrada time,
@horasalida time
as
begin
	set nocount on
	merge turnosenc as target
	using(select @idturnoenc,
				 @descripcion,
				 @idplanta,
				 @horaentrada,
				 @horasalida)
	as source(Idturnoenc,
			  descripcion,
			  idplanta,
			  horaentrada,
			  horasalida)
	on (target.idturnoenc = source.idturnoenc)
	when matched then
	update set descripcion = source.descripcion,
			   idplanta = source.idplanta,
			   horaentrada = source.horaentrada,
			   horasalida = source.horasalida
	when not matched then
	insert (Descripcion,
			Idplanta,
			Horaentrada,
			Horasalida)
	values(source.descripcion,
		   source.idplanta,
		   source.horaentrada,
		   source.horasalida);
	set @idturnoenc = SCOPE_IDENTITY()
end
return @idturnoenc