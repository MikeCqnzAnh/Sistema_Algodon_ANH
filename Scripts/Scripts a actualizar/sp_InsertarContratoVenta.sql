alter procedure sp_InsertarContratoVenta
@IdContratoAlgodon int output, 
@IdComprador int,
@Pacas int,
@PacasCompradas int,
@PacasDisponibles int,
@PrecioQuintal float,
@IdUnidadPeso int,
@ValorConversion float,
@Puntos float,
@FechaLiquidacion datetime,
@Presidente varchar(100),
@IdModalidadVenta int,
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
merge [dbo].[ContratoVenta] as target
using (select @IdContratoAlgodon
			 ,@IdComprador
			 ,@Pacas
			 ,@PacasCompradas
			 ,@PacasDisponibles 
			 ,@PrecioQuintal
			 ,@IdUnidadPeso 
			 ,@ValorConversion 
			 ,@Puntos
			 ,@FechaLiquidacion
			 ,@Presidente
			 ,@IdModalidadVenta
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
			 ,IdComprador
			 ,Pacas
			 ,PacasCompradas
			 ,PacasDisponibles 
			 ,PrecioQuintal
			 ,IdUnidadPeso 
			 ,ValorConversion 
			 ,Puntos
			 ,FechaLiquidacion
			 ,Presidente
			 ,IdModalidadVenta
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
IdComprador = source.IdComprador,
Pacas = source.Pacas,
PacasCompradas = source.PacasCompradas,
PacasDisponibles  = source.PacasDisponibles,
PrecioQuintal = source.PrecioQuintal,
IdUnidadPeso  = source.IdUnidadPeso,
ValorConversion  = source.ValorConversion,
Puntos = source.Puntos,
FechaLiquidacion = source.FechaLiquidacion,
Presidente = source.Presidente,
IdModalidadVenta = source.IdModalidadVenta,
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
INSERT (IdComprador
	   ,Pacas
	   ,PacasCompradas
	   ,PacasDisponibles 
	   ,PrecioQuintal
	   ,IdUnidadPeso 
	   ,ValorConversion 
	   ,Puntos
	   ,FechaLiquidacion
	   ,Presidente
	   ,IdModalidadVenta
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
VALUES (source.IdComprador
	   ,source.Pacas
	   ,source.PacasCompradas
	   ,source.PacasDisponibles 
	   ,source.PrecioQuintal
	   ,source.IdUnidadPeso 
	   ,source.ValorConversion 
	   ,source.Puntos
	   ,source.FechaLiquidacion
	   ,source.Presidente
	   ,source.IdModalidadVenta
	   ,source.Temporada
	   ,source.PrecioSM
	   ,source.PrecioMP
	   ,source.PrecioM
	   ,source.PrecioSLMP
	   ,source.PrecioSLM
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