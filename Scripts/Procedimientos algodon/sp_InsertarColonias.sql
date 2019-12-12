create procedure sp_InsertarColonias
@IdColonia int output,
@Descripcion varchar(50),
@NoPacas float,
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as 
begin 
set nocount on
merge [dbo].[Colonias] as target
using (select @IdColonia,@Descripcion,@NoPacas,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) AS SOURCE (IdColonia,Descripcion,NoPacas,IdEstatus,IdUsuarioCreacion,FechaCreacion)
ON (target.IdColonia = SOURCE.IdColonia)
WHEN MATCHED THEN
UPDATE SET Descripcion = Source.Descripcion,
		   NoPacas = source.NoPacas,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (Descripcion,NoPacas,IdEstatus,IdUsuarioCreacion,FechaCreacion)
        VALUES (source.Descripcion,source.NoPacas,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
		SET @IdColonia = SCOPE_IDENTITY()
		END
RETURN @IdColonia