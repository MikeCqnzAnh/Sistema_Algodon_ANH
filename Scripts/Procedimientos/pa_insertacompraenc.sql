create procedure pa_insertacompraenc
@idcompra int output,
@idplanta int,
@idproductor int,
@idcontrato int,
@tara decimal(6,2),
@checktara bit,
@totalpacas int,
@subtotal money,
@castigomic money,
@castigoresistencia money,
@castigouhml money,
@castigoui money,
@deduccion money,
@totalprecio money,
@fechacreacion datetime,
@fechaactualizacion datetime,
@idestatus int
as
begin
	set nocount on 
	merge comprapacasenc as target
	using (select @idcompra,
				  @idplanta,
				  @idproductor,
				  @idcontrato,
				  @tara,
				  @checktara,
				  @totalpacas,
				  @subtotal,
				  @castigomic,
				  @castigoresistencia,
				  @castigouhml,
				  @castigoui,
				  @deduccion,
				  @totalprecio,
				  @fechacreacion,
				  @fechaactualizacion,
				  @idestatus)
	on (target.idcompra = source.idcompra)
	when matched then
	update set 
end