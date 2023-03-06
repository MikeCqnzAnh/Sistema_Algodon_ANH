create procedure pa_insertaincidenciaproduccion
@idincidencia int output,
@idturnoenc int,
@idplanta int,
@fechaincidencia datetime,
@idresponsableturno int,
@idresponsableprensa int,
@fechacreacion datetime,
@fechaactualizacion datetime
as
begin
	set nocount on
	merge incidenciaproduccionenc as target
	using (select @idincidencia,
				  @idturnoenc,
				  @idplanta,
				  @fechaincidencia,
				  @idresponsableturno,
				  @idresponsableprensa,
				  @fechacreacion,
				  @fechaactualizacion	  
				  )
	as source(idincidencia,
				  idturnoenc,
				  idplanta,
				  fechaincidencia,
				  idresponsableturno,
				  idresponsableprensa,
				  fechacreacion,
				  fechaactualizacion	)
	on (target.idproduccionenc = source.idproduccionenc)
	when matched then
	update set idturnoenc = source.idturnoenc,
			   idplanta = source.idplanta,
			   fechaincidencia = source.fechaincidencia,
			   idresponsableturno = source.idresponsableturno,
			   idresponsableprensa = source.idresponsableprensa,			   
			   fechaactualizacion = source.fechaactualizacion
	when not matched then
	insert (idproduccionenc,
				  idturnoenc,
				  idplanta,
				  fechaincidencia,
				  idresponsableturno,
				  idresponsableprensa,
				  fechacreacion,
				  fechaactualizacion)
	values (source.idproduccionenc,
			source.idturnoenc,
			source.idplanta,
			source.fechaincidencia,
			source.idresponsableturno,
			source.idresponsableprensa,
			source.fechacreacion,
			source.fechaactualizacion);
	set @idincidencia = SCOPE_IDENTITY();
end
return @idincidencia