create procedure sp_InsertarAsociacion
@IdAsociacion int output,
@Descripcion varchar(100),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as
begin
set nocount on
merge [dbo].[Asociaciones] as target
using (select @IdAsociacion,@Descripcion,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) AS SOURCE (IdAsociacion,Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
ON (target.IdAsociacion = SOURCE.IdAsociacion)
WHEN MATCHED THEN
UPDATE SET Descripcion = Source.Descripcion,
		   IdEstatus = source.IdEstatus
WHEN NOT MATCHED THEN
        INSERT (Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
        VALUES (source.Descripcion,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
		SET @IdAsociacion = SCOPE_IDENTITY()
END
RETURN @IdAsociacion