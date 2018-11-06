create procedure sp_InsertarCamion
@IdCamion int output,
@Descripcion varchar(100),
@Placas varchar(15),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as
begin
set nocount on
merge [dbo].[Camiones] as target
using (select @IdCamion,@Descripcion,@Placas,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) as source (IdCamion,Descripcion,Placas,IdEstatus,IdUsuarioCreacion,FechaCreacion)
ON (target.IdCamion = source.IdCamion)
WHEN MATCHED THEN
UPDATE SET Descripcion = source.Descripcion,
		   Placas = source.Placas,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (Descripcion,Placas,IdEstatus,IdUsuarioCreacion,FechaCreacion)
VALUES (source.Descripcion,source.Placas,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
SET @IdCamion = SCOPE_IDENTITY()
END
RETURN @IdCamion