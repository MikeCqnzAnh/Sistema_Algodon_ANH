Create procedure sp_InsertarPaquetesHVIEnc
@IdHviEnc int output,
@LotID int,
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
using (select @IdHviEnc,
			  @LotID,
			  @CantidadPacas,
			  @IdPlanta,
			  @Fecha,
			  @IdEstatus,
			  @IdUsuarioCreacion,
			  @FechaCreacion,
			  @IdUsuarioActualizacion,
			  @FechaActualizacion) 
			  AS SOURCE (
			  IdHviEnc,
			  LotID,
			  CantidadPacas,
			  IdPlanta,
			  Fecha,
			  IdEstatus,
			  IdUsuarioCreacion,
			  FechaCreacion,
			  IdUsuarioActualizacion,
			  FechaActualizacion)
ON (target.LotID = SOURCE.LotID and 
	target.IdPlanta = SOURCE.IdPlanta)
WHEN MATCHED THEN
UPDATE SET 
		   CantidadPacas = source.CantidadPacas,
	       --IdPlanta = source.IdPlanta,
		   Fecha = source.Fecha,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (LotID,
		CantidadPacas,
	    IdPlanta,
		Fecha,
		IdEstatus,
		IdUsuarioCreacion,
		FechaCreacion,
		IdUsuarioActualizacion,
		FechaActualizacion)
        VALUES (
		source.LotID,
		source.CantidadPacas,
		source.IdPlanta,
		source.Fecha,
		source.IdEstatus,
		source.IdUsuarioCreacion,
		source.FechaCreacion,
		source.IdUsuarioActualizacion,
		source.FechaActualizacion);
		SET @IdHviEnc = SCOPE_IDENTITY()
		END
RETURN @IdHviEnc