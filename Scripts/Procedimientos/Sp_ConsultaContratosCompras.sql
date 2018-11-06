create proc Sp_ConsultaContratosCompras
@IdComprador int
as
select IdContratoAlgodon	,
	   IdComprador	,
	   Pacas	,
	   PrecioQuintal	,
	   Puntos	,
	   FechaLiquidacion	,
	   Presidente	,
	   IdModalidadCompra	,
	   Temporada	,
	   PrecioSM	,
	   PrecioMP	,
	   PrecioM	,
	   PrecioSLMP	,
	   PrecioSLM	,
	   PrecioLMP	,
	   PrecioLM	,
	   PrecioSGO	,
	   PrecioGO	,
	   PrecioO	,
	   IdEstatus	,
	   IdUsuarioCreacion	,
	   FechaCreacion	,
	   IdUsuarioActualizacion	,
	   FechaActualizacion 
from   ContratoVenta
where IdComprador = @IdComprador

