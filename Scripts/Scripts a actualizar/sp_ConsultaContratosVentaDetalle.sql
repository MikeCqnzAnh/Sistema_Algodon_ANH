alter procedure sp_ConsultaContratosVentaDetalle
--declare
@IdContratoAlgodon int --= 1
as
select a.IdContratoAlgodon,
	   b.IdComprador,
       b.Nombre,	   
	   a.Pacas,	 
	   a.PacasCompradas,
	   a.PacasDisponibles,
	   a.PrecioQuintal,
	   a.IdUnidadPeso,
	   a.ValorConversion,
	   a.Puntos,
	   a.FechaLiquidacion,
	   a.Presidente,
	   a.IdModalidadVenta,
	   a.Temporada,
	   a.PrecioSM,
	   a.PrecioMP,
	   a.PrecioM,
	   a.PrecioSLMP,
	   a.PrecioSLM,
	   a.PrecioLMP,
	   a.PrecioLM,
	   a.PrecioSGO,
	   a.PrecioGO,
	   a.PrecioO,
	   a.IdEstatus
from   [dbo].[ContratoVenta] a,
       [dbo].[Compradores] b
where  a.IdComprador = b.IdComprador and a.IdContratoAlgodon = @IdContratoAlgodon
and    a.IdEstatus = 1