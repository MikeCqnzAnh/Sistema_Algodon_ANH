alter procedure sp_InsertarContratoCompra
@IdContratoAlgodon int output, 
@IdProductor int,
@Pacas int,
@PacasCompradas int,
@PacasDisponibles int,
@SuperficieComprometida float,
@PrecioQuintal float,
@Puntos float,
@FechaLiquidacion datetime,
@Presidente varchar(100),
@IdModalidadCompra int,
@Temporada varchar(20),
@PrecioSM float,
@PrecioMP float,
@PrecioM float,
@PrecioSLMP float,
@PrecioSLM float,
@PrecioLMP float,
@PrecioLM float,
@PrecioSGO float,
@PrecioGO float,
@PrecioO float,
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion datetime
as
begin
set nocount on
merge [dbo].[ContratoCompra] as target
using (select @IdContratoAlgodon
			 ,@IdProductor
			 ,@Pacas
			 ,@PacasCompradas 
			 ,@PacasDisponibles 
			 ,@SuperficieComprometida
			 ,@PrecioQuintal
			 ,@Puntos
			 ,@FechaLiquidacion
			 ,@Presidente
			 ,@IdModalidadCompra
			 ,@Temporada
			 ,@PrecioSM
			 ,@PrecioMP
			 ,@PrecioM
			 ,@PrecioSLMP
			 ,@PrecioSLM
			 ,@PrecioLMP
			 ,@PrecioLM
			 ,@PrecioSGO
			 ,@PrecioGO
			 ,@PrecioO
			 ,@IdEstatus
			 ,@IdUsuarioCreacion
			 ,@FechaCreacion
			 ,@IdUsuarioActualizacion
			 ,@FechaActualizacion) as source 
			 (IdContratoAlgodon
			 ,IdProductor
			 ,Pacas
			 ,PacasCompradas
			 ,PacasDisponibles
			 ,SuperficieComprometida
			 ,PrecioQuintal
			 ,Puntos
			 ,FechaLiquidacion
			 ,Presidente
			 ,IdModalidadCompra
			 ,Temporada
			 ,PrecioSM
			 ,PrecioMP
			 ,PrecioM
			 ,PrecioSLMP
			 ,PrecioSLM
			 ,PrecioLMP
			 ,PrecioLM
			 ,PrecioSGO
			 ,PrecioGO
			 ,PrecioO
			 ,IdEstatus
			 ,IdUsuarioCreacion
			 ,FechaCreacion
			 ,IdUsuarioActualizacion
			 ,FechaActualizacion)
ON (target.IdContratoAlgodon = source.IdContratoAlgodon)
WHEN MATCHED THEN
UPDATE SET 
		IdProductor = source.IdProductor,
		Pacas = source.Pacas,
		SuperficieComprometida = source.SuperficieComprometida,
		PrecioQuintal = source.PrecioQuintal,
		Puntos = source.Puntos,
		FechaLiquidacion = source.FechaLiquidacion,
		Presidente = source.Presidente,
		IdModalidadCompra = source.IdModalidadCompra,
		Temporada = source.Temporada,
		PrecioSM = source.PrecioSM,
		PrecioMP = source.PrecioMP,
		PrecioM = source.PrecioM,
		PrecioSLMP = source.PrecioSLMP,
		PrecioSLM = source.PrecioSLM,
		PrecioLMP = source.PrecioLMP,
		PrecioLM = source.PrecioLM,
		PrecioSGO = source.PrecioSGO,
		PrecioGO = source.PrecioGO,
		PrecioO = source.PrecioO,
		IdEstatus = source.IdEstatus,
		IdUsuarioActualizacion = source.IdUsuarioActualizacion,
		FechaActualizacion = source.FechaActualizacion
WHEN NOT MATCHED THEN
INSERT (IdProductor
	   ,Pacas
	   ,PacasDisponibles
	   ,SuperficieComprometida
	   ,PrecioQuintal
	   ,Puntos
	   ,FechaLiquidacion
	   ,Presidente
	   ,IdModalidadCompra
	   ,Temporada
	   ,PrecioSM
	   ,PrecioMP
	   ,PrecioM
	   ,PrecioSLMP
	   ,PrecioSLM
	   ,PrecioLMP
	   ,PrecioLM
	   ,PrecioSGO
	   ,PrecioGO
	   ,PrecioO
	   ,IdEstatus
	   ,IdUsuarioCreacion
	   ,FechaCreacion
	   ,IdUsuarioActualizacion
	   ,FechaActualizacion)
VALUES (source.IdProductor	   ,source.Pacas	   ,source.PacasDisponibles	   ,source.SuperficieComprometida	   ,source.PrecioQuintal	   ,source.Puntos	   ,source.FechaLiquidacion	   ,source.Presidente	   ,source.IdModalidadCompra	   ,source.Temporada	   ,source.PrecioSM	   ,source.PrecioMP	   ,source.PrecioM	   ,source.PrecioSLMP	   ,source.PrecioSLM
	   ,source.PrecioLMP
	   ,source.PrecioLM
	   ,source.PrecioSGO
	   ,source.PrecioGO
	   ,source.PrecioO
	   ,source.IdEstatus
	   ,source.IdUsuarioCreacion
	   ,source.FechaCreacion
	   ,source.IdUsuarioActualizacion
	   ,source.FechaActualizacion);
SET @IdContratoAlgodon = SCOPE_IDENTITY()
END
RETURN @IdContratoAlgodon