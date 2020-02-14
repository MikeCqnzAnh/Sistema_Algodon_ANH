CREATE procedure sp_InsertaLargoFibraEncabezado
@IdModoEncabezado int output,
@Descripcion varchar(30),
@ModoComercializacion int,
@IdEstatus int
as
begin
set nocount on
merge [dbo].[LargosFibraEncabezado] as target
using (select @IdModoEncabezado
			 ,@Descripcion
			 ,@ModoComercializacion
			 ,@IdEstatus) as source 
			 (IdModoEncabezado
			 ,Descripcion
			 ,ModoComercializacion
			 ,IdEstatus)
ON (target.IdModoEncabezado = source.IdModoEncabezado)
WHEN MATCHED THEN
UPDATE SET Descripcion = source.Descripcion,
		   ModoComercializacion = source.ModoComercializacion,
		   IdEstatus = source.IdEstatus
WHEN NOT MATCHED THEN
INSERT (Descripcion,ModoComercializacion,IdEstatus)
VALUES (source.Descripcion,source.ModoComercializacion,source.IdEstatus);
SET @IdModoEncabezado = SCOPE_IDENTITY()
END
RETURN @IdModoEncabezado