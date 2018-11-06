alter procedure sp_InsertarOrdenTrabajo
@IdOrdenTrabajo int output,
@IdPlanta int,
@IdProductor int,
@RangoInicio int,
@RangoFin int,
@NumeroModulos int,
@IdVariedadAlgodon int,
@IdColonia int,
@Predio varchar(30),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion datetime
as
begin
set nocount on
merge [dbo].[OrdenTrabajo] as target
using (select @IdOrdenTrabajo,@IdPlanta,@IdProductor,@RangoInicio,@RangoFin,@NumeroModulos,@IdVariedadAlgodon,@IdColonia,@Predio,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion,@IdUsuarioActualizacion,@FechaActualizacion) as source (IdOrdenTrabajo,IdPlanta,IdProductor,RangoInicio,RangoFin,NumeroModulos,IdVariedadAlgodon,IdColonia,Predio,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
ON (target.IdOrdenTrabajo = source.IdOrdenTrabajo)
WHEN MATCHED THEN
UPDATE SET IdPlanta = source.IdPlanta,
           IdProductor = source.IdProductor,
		   RangoInicio = source.RangoInicio,
		   RangoFin = source.RangoFin,
		   NumeroModulos = source.NumeroModulos,
		   IdVariedadAlgodon = source.IdVariedadAlgodon,
		   IdColonia = source.IdColonia,
		   Predio = source.Predio,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion		   
WHEN NOT MATCHED THEN
INSERT (IdPlanta,IdProductor,RangoInicio,RangoFin,NumeroModulos,IdVariedadAlgodon,IdColonia,Predio,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
VALUES (source.IdPlanta,source.IdProductor,source.RangoInicio,source.RangoFin,source.NumeroModulos,source.IdVariedadAlgodon,source.IdColonia,source.Predio,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion,source.IdUsuarioActualizacion,source.FechaActualizacion);
SET @IdOrdenTrabajo = SCOPE_IDENTITY()
END
RETURN @IdOrdenTrabajo