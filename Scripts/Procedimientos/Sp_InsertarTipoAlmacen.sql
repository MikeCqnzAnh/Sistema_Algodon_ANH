Create Procedure Sp_InsertarTipoAlmacen
@IdTipoAlmacen int output,
@Descripcion varchar(30)
as 
begin
set nocount on
merge [dbo].[TipoAlmacen] as target
using (select @IdTipoAlmacen,@Descripcion) as source (IdTipoAlmacen,Descripcion)
ON (target.IdTipoAlmacen = source.IdTipoAlmacen)
WHEN MATCHED THEN
UPDATE SET Descripcion = source.Descripcion
		  
WHEN NOT MATCHED THEN
INSERT (Descripcion)
VALUES (source.Descripcion);
SET @IdTipoAlmacen = SCOPE_IDENTITY()
END
RETURN @IdTipoAlmacen