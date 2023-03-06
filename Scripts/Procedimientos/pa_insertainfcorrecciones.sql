create procedure pa_insertainfcorrecciones
@idinforme int output,
@idproduccionenc int,
@descripcion varchar(100)
as
begin
	set nocount on
	merge informecorrecciones as target
	using (select @idinforme,
				  @idproduccionenc,
				  @descripcion)
			as source
		  (idinforme,
		   idproduccionenc,
		   descripcion)
	on (target.idproduccionenc=source.idproduccionenc and target.idinforme = source.idinforme)
	when matched then
	update set descripcion = source.descripcion
	when not matched then
	insert (idproduccionenc,
			descripcion)
	values (source.idproduccionenc,
			source.descripcion);
	set @idinforme = SCOPE_IDENTITY();	
end
return @idinforme