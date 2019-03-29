create procedure sp_InsertarMonedas
@IdMoneda int output,
@NombreMoneda varchar(40),
@Abreviacion varchar(6),
@TipoDeCambio decimal(6,4),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion datetime
as 
begin 
set nocount on
merge [dbo].[Moneda] as target
using (select @IdMoneda,@NombreMoneda,@Abreviacion,@TipodeCambio,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion,@IdUsuarioActualizacion,@FechaActualizacion) 
	AS SOURCE (IdMoneda,NombreMoneda,Abreviacion,TipodeCambio,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
ON (target.IdMoneda = SOURCE.IdMoneda)
WHEN MATCHED THEN
UPDATE SET NombreMoneda = Source.NombreMoneda,
		   Abreviacion = source.Abreviacion,
		   TipodeCambio = source.TipodeCambio,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion,
		   IdUsuarioActualizacion = source.IdUsuarioActualizacion,
		   FechaActualizacion = source.FechaActualizacion
WHEN NOT MATCHED THEN
INSERT (NombreMoneda,Abreviacion,TipodeCambio,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
        VALUES (source.NombreMoneda,source.Abreviacion,source.TipodeCambio,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion,source.IdUsuarioActualizacion,source.FechaActualizacion);
		SET @IdMoneda = SCOPE_IDENTITY()
		END
RETURN @IdMoneda