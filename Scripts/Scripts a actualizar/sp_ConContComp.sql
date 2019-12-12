alter procedure sp_ConContComp
@IdComprador int
as
SELECT a.IdContratoAlgodon,
	   a.IdComprador,
	   a.Pacas,
	   isnull(a.PacasVendidas, 0) as PacasVendidas,
	   isnull(a.PacasDisponibles, 0) as PacasDisponibles,
	   a.PrecioQuintal,
	   a.IdUnidadPeso,
	   a.ValorConversion,
	   a.Puntos,
	   a.FechaLiquidacion,
	   a.Temporada,
	   a.IdModalidadVenta,
	   a.PrecioSM,
	   a.PrecioMP,
	   a.preciom,
	   a.PrecioSLMP,
	   a.PrecioSLM,
	   a.PrecioLMP,
	   a.PrecioLM,
	   a.PrecioSGO,
	   a.PrecioGO,
	   a.PrecioO,
	   a.FechaCreacion as Fecha
FROM ContratoVenta a
where a.IdEstatus = 1
and a.IdComprador = @IdComprador