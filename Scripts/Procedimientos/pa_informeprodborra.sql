create procedure pa_informeprodborra
@idinforme int output,
@idproduccionenc int,
@baleid bigint
as
begin
	set nocount on
	merge informeproduccionborra as target
	using (select @idinforme,
				  @idproduccionenc,
				  @baleid)
				  as source
			(idinforme,
			 idproduccionenc,
			 baleid		
			)
	on (target.idproduccionenc = source.idproduccionenc and target.idinforme = source.idinforme)
	when matched then
	update set baleid = source.baleid
	when not matched then
	insert(idproduccionenc,
		   baleid)
	values(source.idproduccionenc,
		   source.baleid);
	set @idinforme = SCOPE_IDENTITY();
end
return @idinforme 