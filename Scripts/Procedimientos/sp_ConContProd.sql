Create procedure sp_ConContProd
@IdProductor int
as
select a.IdContratoAlgodon,
	   a.IdProductor,
	   a.Pacas,
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
	   a.FechaCreacion as Fecha
from [dbo].[ContratoCompra] a
where a.IdEstatus = 1
and a.IdProductor = @IdProductor

select * from [ContratoCompra]