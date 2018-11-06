ALTER procedure sp_InsertarTipoIncidencia
@IdTipoIncidencia int output,
@Descripcion varchar(50),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as
begin 
set nocount on
merge [dbo].[TipoIncidencia] as target
using(select @IdTIpoIncidencia,@Descripcion,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) as source (IdTIpoIncidencia,Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
on (target.IdTipoIncidencia = source.IdTipoIncidencia)
when matched then
update 
set   Descripcion = source.Descripcion,
	  IdEstatus = source.IdEstatus,
	  IdUsuarioCreacion = source.IdUsuarioCreacion,
	  FechaCreacion = source.FechaCreacion
when not matched then
insert (Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
values (source.Descripcion,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
		set @IdTipoIncidencia = SCOPE_IDENTITY()
end
return @IdTipoIncidencia