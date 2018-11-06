create procedure sp_InsertarMaquinaria
@IdMaquinaria int output,
@Descripcion varchar(50),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as
begin
set nocount on
merge [dbo].[Maquinaria] as target
using (select @IdMaquinaria,@Descripcion,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) as source (IdMaquinaria,Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
ON (target.IdMaquinaria = source.IdMaquinaria)
WHEN MATCHED THEN
UPDATE SET Descripcion = source.Descripcion,		
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
VALUES (source.Descripcion,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
SET @IdMaquinaria = SCOPE_IDENTITY()
END
RETURN @IdMaquinaria