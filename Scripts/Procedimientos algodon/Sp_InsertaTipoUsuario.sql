Create Procedure sp_InsertarTipoUsuario
@IdTipo int output,
@Descripcion varchar(15)
as
begin
set nocount on
merge [dbo].[TipoUsuario] as target
using (select @IdTipo,@Descripcion) as source (IdTipo,Descripcion)
ON (target.IdTipo = source.IdTipo)
WHEN MATCHED THEN
UPDATE SET Descripcion = source.Descripcion
WHEN NOT MATCHED THEN
INSERT (Descripcion)
VALUES (source.Descripcion);
SET @IdTipo = SCOPE_IDENTITY()
END
RETURN @IdTipo
