create procedure sp_InsertarMonedas
@IdMoneda int output,
@NombreMoneda varchar(50),
@Abreviacion varchar(6),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion datetime
as 
begin 
set nocount on
merge [dbo].[Moneda] as target
using (select @IdMoneda,@NombreMoneda,@Abreviacion,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion,@IdUsuarioActualizacion,@FechaActualizacion) 
	AS SOURCE (IdMoneda,NombreMoneda,Abreviacion,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
ON (target.IdMoneda = SOURCE.IdMoneda)
WHEN MATCHED THEN
UPDATE SET NombreMoneda = Source.NombreMoneda,
		   Abreviacion = source.Abreviacion,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion,
		   IdUsuarioActualizacion = source.IdUsuarioActualizacion,
		   FechaActualizacion = source.FechaActualizacion
WHEN NOT MATCHED THEN
INSERT (NombreMoneda,Abreviacion,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
        VALUES (source.NombreMoneda,source.Abreviacion,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion,source.IdUsuarioActualizacion,source.FechaActualizacion);
		SET @IdMoneda = SCOPE_IDENTITY()
		END
RETURN @IdMoneda