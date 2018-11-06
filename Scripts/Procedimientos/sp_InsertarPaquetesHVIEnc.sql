alter procedure sp_InsertarPaquetesHVIEnc
@IdHviEnc int output,
@CantidadPacas int,
@IdPlanta int,
@Fecha datetime,
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion datetime
as 
begin 
set nocount on
merge [dbo].[HVIEncabezado] as target
using (select @IdHviEnc,@CantidadPacas,@IdPlanta,@Fecha,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion,@IdUsuarioActualizacion,@FechaActualizacion) AS SOURCE (IdHviEnc,CantidadPacas,IdPlanta,Fecha,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
ON (target.IdHviEnc = SOURCE.IdHviEnc)
WHEN MATCHED THEN
UPDATE SET 
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (CantidadPacas,IdPlanta,Fecha,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
        VALUES (source.CantidadPacas,source.IdPlanta,source.Fecha,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion,source.IdUsuarioActualizacion,source.FechaActualizacion);
		SET @IdHviEnc = SCOPE_IDENTITY()
		END
RETURN @IdHviEnc