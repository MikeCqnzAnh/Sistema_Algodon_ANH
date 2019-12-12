Create Procedure Sp_InsertaAlmacen
@IdAlmacen int output,
@Descripcion varchar(30),
@IdTipoAlmacen int,
@Calle varchar(50),
@Numero varchar(7),
@CodigoPostal varchar(8),
@Colonia varchar(50),
@Ciudad Int,
@Estado int,
@Capacidad float
as
begin
set nocount on
merge Almacen as target
using (select @IdAlmacen,@Descripcion,@IdTipoAlmacen,@Calle,@Numero,@CodigoPostal,@Colonia,@Ciudad,@Estado,@Capacidad)
as source(IdAlmacen,Descripcion,IdTipoAlmacen,Calle,Numero,CodigoPostal,Colonia,Ciudad,Estado,Capacidad)
on (target.IdAlmacen = source.IdAlmacen)
when matched then 
update set Descripcion = source.Descripcion,
		   IdTipoAlmacen = source.IdTipoAlmacen,
		   Calle = source.Calle,
		   Numero = source.Numero,
		   CodigoPostal = source.CodigoPostal,
		   Colonia = source.Colonia,
		   Ciudad = source.Ciudad,
		   Estado = source.Estado,
		   Capacidad = source.Capacidad
when not matched then
insert(Descripcion,IdTipoAlmacen,Calle,Numero,CodigoPostal,Colonia,Ciudad,Estado,Capacidad)
values(source.Descripcion,source.IdTipoAlmacen,source.Calle,source.Numero,source.CodigoPostal,source.Colonia,source.Ciudad,source.Estado,source.Capacidad);
set @IdAlmacen = SCOPE_IDENTITY()
end
return @IdAlmacen