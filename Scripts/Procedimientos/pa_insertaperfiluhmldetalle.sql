CREATE procedure pa_insertaperfiluhmldetalle
@idmododetalle int,
@idmodoencabezado int,
@rango1 decimal(6,2),
@rango2 decimal(6,2),
@LenghtNDS int,
@castigo decimal(6,2)
as
begin
	set nocount on
	merge perfiluhmldetalle as target
	using (select @idmododetalle ,
					@idmodoencabezado ,
					@rango1 ,
					@rango2 ,
					@LenghtNDS ,
					@castigo )
	as source (idmododetalle ,
					idmodoencabezado ,
					rango1 ,
					rango2 ,
					LenghtNDS ,
					castigo  )
	on (target.idmododetalle = source.idmododetalle and 
		target.idmodoencabezado = source.idmodoencabezado)
	when matched then
	update set 		rango1 = source.rango1 ,
					rango2 = source.rango2 ,
					LenghtNDS = source.LenghtNDS ,
					castigo = source.castigo
	when not matched then
	insert (idmodoencabezado ,
					rango1 ,
					rango2 ,
					LenghtNDS ,
					castigo )
	values (source.idmodoencabezado ,
					source.rango1 ,
					source.rango2 ,
					source.LenghtNDS ,
					source.castigo );
	set @idmododetalle = SCOPE_IDENTITY()	
end

