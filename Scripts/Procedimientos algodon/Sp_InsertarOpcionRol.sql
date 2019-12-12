CREATE procedure Sp_InsertarOpcionRol
@IdMenuRoles int output,
@Descripcion varchar(30),
@IdPadre int,
@IdEstatus bit
as
begin
set nocount on
merge MenuRoles as target
using (select @IdMenuRoles,@Descripcion,@IdPadre,@IdEstatus) as source (IdMenuRoles,Descripcion,IdPadre,IdEstatus)
ON (target.IdMenuRoles = source.IdMenuRoles)
WHEN MATCHED THEN
UPDATE SET Descripcion = source.Descripcion,
		   IdPadre = source.IdPadre,
		   IdEstatus = source.IdEstatus
WHEN NOT MATCHED THEN
INSERT (Descripcion,IdPadre,IdEstatus)
VALUES (source.Descripcion,source.IdPadre,source.IdEstatus);
SET @IdMenuRoles = SCOPE_IDENTITY()
END
RETURN @IdMenuRoles