create proc sp_InsertarRegimenHidrico
@IdRegimen int output,
@Descripcion varchar(30),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as
begin
set nocount on
merge [dbo].[RegimenHidrico] as target
using (select @IdRegimen,@Descripcion,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) as source (IdRegimen,Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
ON (target.IdRegimen = source.IdRegimen)
WHEN MATCHED THEN
UPDATE SET Descripcion = source.Descripcion,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
VALUES (source.Descripcion, source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
SET @IdRegimen = SCOPE_IDENTITY()
END
RETURN @IdRegimen