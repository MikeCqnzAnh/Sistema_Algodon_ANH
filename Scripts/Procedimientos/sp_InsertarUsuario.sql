CREATE Procedure sp_InsertarUsuario
@IdUsuario int output,
@Nombre varchar(40),
@Usuario varchar(15),
@Clave varchar(max),
@Tipo int,
@Estatus int
as
begin
set nocount on
merge [dbo].[Usuarios] as target
using (select @IdUsuario,@Nombre,@Usuario,@Clave,@Tipo,@Estatus) as source (IdUsuario,Nombre,Usuario,Clave,Tipo,Estatus)
ON (target.IdUsuario = source.IdUsuario)
WHEN MATCHED THEN
UPDATE SET Nombre = source.Nombre,
		   Usuario = source.Usuario,
		   Clave = source.Clave,
		   Tipo = source.Tipo,
		   Estatus = source.Estatus
WHEN NOT MATCHED THEN
INSERT (Nombre,Usuario,Clave,Tipo,Estatus)
VALUES (source.Nombre,source.Usuario,source.Clave,source.Tipo,source.Estatus);
SET @IdUsuario = SCOPE_IDENTITY()
END
RETURN @IdUsuario