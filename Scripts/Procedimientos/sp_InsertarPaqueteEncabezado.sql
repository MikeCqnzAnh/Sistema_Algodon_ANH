CREATE procedure sp_InsertarPaqueteEncabezado
@IdPaquete int output,
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
using (select @IdPaquete,@IdPlanta,@IdComprador,@IdClase,@CantidadPacas,@Descripcion,@Entrega,@chkrevisado,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion,@IdUsuarioActualizacion,@FechaActualizacion) 
as source (IdPaquete,IdPlanta,IdComprador,IdClase,CantidadPacas,Descripcion,Entrega,chkrevisado,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
ON (target.IdPaquete = source.IdPaquete)
WHEN MATCHED THEN
UPDATE SET IdPlanta = source.IdPlanta,		
		   IdClase = source.IdClase,
		   IdComprador = source.IdComprador,
		   CantidadPacas = source.CantidadPacas,
		   Descripcion = source.Descripcion,
		   Entrega = source.Entrega,
		   chkrevisado = source.chkrevisado,
		   IdUsuarioActualizacion = source.IdUsuarioActualizacion,
		   FechaActualizacion = source.FechaActualizacion,
		   IdEstatus = source.IdEstatus
WHEN NOT MATCHED THEN
INSERT (IdPlanta,IdComprador,IdClase,CantidadPacas,Descripcion,Entrega,chkrevisado,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
VALUES (source.IdPlanta,source.IdClase,source.IdComprador,source.CantidadPacas,source.Descripcion,source.Entrega,source.chkrevisado,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion,source.IdUsuarioActualizacion,source.FechaActualizacion);
SET @IdPaquete = SCOPE_IDENTITY()
END
RETURN @IdPaquete