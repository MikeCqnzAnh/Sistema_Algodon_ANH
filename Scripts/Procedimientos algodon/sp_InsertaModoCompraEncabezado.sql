create procedure sp_InsertaModoCompraEncabezado
@IdModoEncabezado int output,
@Descripcion varchar(30),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as
begin
set nocount on
merge [dbo].[ModosCompraEncabezado] as target
using (select @IdModoEncabezado,@Descripcion,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) as source (IdModoEncabezado,Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
ON (target.IdModoEncabezado = source.IdModoEncabezado)
WHEN MATCHED THEN
UPDATE SET Descripcion = source.Descripcion,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
VALUES (source.Descripcion,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
SET @IdModoEncabezado = SCOPE_IDENTITY()
END
RETURN @IdModoEncabezado