CREATE procedure sp_ConContProd
@IdProductor int,
@seleccionar bit = 0
as
select a.IdContratoAlgodon,
	   a.IdProductor,
	   a.Pacas,
	   isnull(a.PacasCompradas,0) as PacasCompradas,
	   isnull(a.PacasDisponibles,0) as PacasDisponibles,
	   a.idunidadpeso,
	   up.Descripcion as UnidadPeso,
	   a.SuperficieComprometida,
	   a.PrecioQuintal,
	   a.Puntos,
	   a.FechaLiquidacion,
	   a.Temporada,
	   a.IdModalidadCompra,
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
	   a.FechaCreacion as Fecha,
	   @seleccionar as Seleccionar
from [dbo].[ContratoCompra] a inner join UnidadPesoVenta up on a.IdUnidadPeso = up.IdUnidadPeso
where a.IdEstatus = 1
and a.IdProductor = @IdProductor
