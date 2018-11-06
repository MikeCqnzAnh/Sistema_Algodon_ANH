create procedure sp_InsertarPuesto
@IdPuesto int output,
@Descripcion varchar(30),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as
begin
set nocount on
merge [dbo].[Puestos] as target
using (select @IdPuesto,@Descripcion,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) AS SOURCE (IdPuesto,Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
ON (target.IdPuesto = SOURCE.IdPuesto)
WHEN MATCHED THEN
UPDATE SET Descripcion = Source.Descripcion,		 
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
        VALUES (source.Descripcion,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
		SET @IdPuesto = SCOPE_IDENTITY()
		END
RETURN @IdPuesto