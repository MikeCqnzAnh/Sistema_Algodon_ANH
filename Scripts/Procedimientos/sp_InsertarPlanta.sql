create procedure sp_InsertarPlanta
@IdPlanta int output,
@Descripcion varchar(30),
@Registro varchar(25),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as
begin
set nocount on
merge [dbo].[Plantas] as target
using (select @IdPlanta,@Descripcion,@Registro,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) as source (IdPlanta,Descripcion,Registro,IdEstatus,IdUsuarioCreacion,FechaCreacion)
ON (target.IdPlanta = source.IdPlanta)
WHEN MATCHED THEN
UPDATE SET Descripcion = source.Descripcion,
		   Registro = source.Registro,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (Descripcion,Registro,IdEstatus,IdUsuarioCreacion,FechaCreacion)
VALUES (source.Descripcion,source.Registro,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
SET @IdPlanta = SCOPE_IDENTITY()
END
RETURN @IdPlanta