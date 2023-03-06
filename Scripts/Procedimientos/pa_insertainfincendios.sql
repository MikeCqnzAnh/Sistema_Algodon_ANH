create procedure pa_insertainfincendios
@idinforme int output,
@idproduccionenc int,
@baleidsiniestrada bigint,
@baleidant1 bigint,
@baleidant2 bigint,
@baleidpos1 bigint,
@baleidpos2 bigint
as
begin
	set nocount on
	merge informeincendios as target
	using (select @idinforme,
				  @idproduccionenc,
				  @baleidsiniestrada,
				  @baleidant1,
				  @baleidant2,
				  @baleidpos1,
				  @baleidpos2)
	as source(idinforme,
			  idproduccionenc,
			  baleidsiniestrada,
			  baleidant1,
			  baleidant2,
			  baleidpos1,
			  baleidpos2)
	on (target.idproduccionenc = source.idproduccionenc and target.baleidsiniestrada = source.baleidsiniestrada)
	when matched then
	update set baleidant1 = source.baleidant1,
			   baleidant2 = source.baleidant2,
			   baleidpos1 = source.baleidpos1,
			   baleidpos2 = source.baleidpos2
	when not matched then
	insert (idproduccionenc,
			baleidsiniestrada,
			baleidant1,
			baleidant2,
			baleidpos1,
			baleidpos2)
	values (source.idproduccionenc,
			source.baleidsiniestrada,
			source.baleidant1,
			source.baleidant2,
			source.baleidpos1,
			source.baleidpos2);
	set @idinforme = SCOPE_IDENTITY();
end
return @idinforme