create proc sp_InsertarVariedadesAlgodon
@IdVariedadAlgodon int output,
@Descripcion varchar(30),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as
begin
set nocount on
merge [dbo].[VariedadesAlgodon] as target
using (select @IdVariedadAlgodon,@Descripcion,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) as source (IdVariedadAlgodon,Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
ON (target.IdVariedadAlgodon = source.IdVariedadAlgodon)
WHEN MATCHED THEN
UPDATE SET Descripcion = source.Descripcion,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
VALUES (source.Descripcion,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
SET @IdVariedadAlgodon = SCOPE_IDENTITY()
END
RETURN @IdVariedadAlgodon