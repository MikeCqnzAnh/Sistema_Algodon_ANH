create procedure sp_InsertarIncidencia
@IdIncidencia int output,
@IdTipo int,
@Descripcion varchar(300),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as
begin
set nocount on
merge [dbo].[Incidencias] as target
using (select @IdIncidencia,@IdTipo,@Descripcion,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) as source (IdIncidencia,IdTipo,Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
on (target.IdIncidencia = source.IdIncidencia)
when matched then
update
set IdTipo = source.IdTipo,
    Descripcion = source.Descripcion,
	IdEstatus = source.IdEstatus,
	IdUsuarioCreacion = source.IdUsuarioCreacion,
	FechaCreacion = source.FechaCreacion
when not matched then
insert (IdTipo,Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
values (source.IdTipo,source.Descripcion,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
set @IdIncidencia = SCOPE_IDENTITY()
end 
return @IdIncidencia