CREATE procedure sp_InsertarPaqueteEncabezado
@IdPaquete int output,
@LotID int ,
@IdPlanta int,
@IdComprador int,
@IdClase int,
@CantidadPacas int,
@Descripcion varchar(20),
@Entrega varchar(15),
@chkrevisado bit,
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion  datetime
as
begin
set nocount on
merge [dbo].[PaqueteEncabezado] as target
using (select @IdPaquete,
			  @LotID,
			  @IdPlanta,
			  @IdComprador,
			  @IdClase,
			  @CantidadPacas,
			  @Descripcion,
			  @Entrega,
			  @chkrevisado,
			  @IdEstatus,
			  @IdUsuarioCreacion,
			  @FechaCreacion,
			  @IdUsuarioActualizacion,
			  @FechaActualizacion) 
as source (IdPaquete,
		   LotID,
		   IdPlanta,
		   IdComprador,
		   IdClase,
		   CantidadPacas,
		   Descripcion,
		   Entrega,
		   chkrevisado,
		   IdEstatus,
		   IdUsuarioCreacion,
		   FechaCreacion,
		   IdUsuarioActualizacion,
		   FechaActualizacion)
ON (target.IdPaquete = source.IdPaquete)
WHEN MATCHED THEN
UPDATE SET IdPlanta = source.IdPlanta,		
		   IdClase = source.IdClase,
		   IdComprador = source.IdComprador,
		   CantidadPacas = source.CantidadPacas,
		   Descripcion = source.Descripcion,
		   Entrega = source.Entrega,
		   chkrevisado = 1,
		   IdUsuarioActualizacion = source.IdUsuarioActualizacion,
		   FechaActualizacion = source.FechaActualizacion,
		   IdEstatus = source.IdEstatus
WHEN NOT MATCHED THEN
INSERT (LotID,
		IdPlanta,
		IdComprador,
		IdClase,
		CantidadPacas,
		Descripcion,
		Entrega,
		chkrevisado,
		IdEstatus,
		IdUsuarioCreacion,
		FechaCreacion,
		IdUsuarioActualizacion,
		FechaActualizacion)
VALUES (source.LotID,
		source.IdPlanta,
		source.IdComprador,
		source.IdClase,
		source.CantidadPacas,
		source.Descripcion,
		source.Entrega,
		1,
		source.IdEstatus,
		source.IdUsuarioCreacion,
		source.FechaCreacion,
		source.IdUsuarioActualizacion,
		source.FechaActualizacion);
SET @IdPaquete = SCOPE_IDENTITY()
END
RETURN @IdPaquete