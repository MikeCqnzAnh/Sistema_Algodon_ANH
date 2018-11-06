create procedure sp_InsertarEmpleado
@IdEmpleado int output,
@Nombre varchar(50),
@IdPuesto varchar(25),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as
begin
set nocount on
merge [dbo].[Empleados] as target
using (select @IdEmpleado,@Nombre,@IdPuesto,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) as source (IdEmpleado,Nombre,IdPuesto,IdEstatus,IdUsuarioCreacion,FechaCreacion)
ON (target.IdEmpleado = source.IdEmpleado)
WHEN MATCHED THEN
UPDATE SET Nombre = source.Nombre,
		   IdPuesto = source.IdPuesto,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (Nombre,IdPuesto,IdEstatus,IdUsuarioCreacion,FechaCreacion)
VALUES (source.Nombre,source.IdPuesto,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
SET @IdPuesto = SCOPE_IDENTITY()
END
RETURN @IdPuesto