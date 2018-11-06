alter procedure sp_ConLiqProd
--declare
@IdProductor int,
@TotalPacasComprar int = 0,
@Seleccionar bit = 0 
as
select a.IdLiquidacion,
       b.Nombre as Cliente,
	   a.Fecha,
	   a.Comentarios,
	   a.TotalPacas,
	   @TotalPacasComprar as PacasComprar,
	   @Seleccionar as Seleccionar
from [dbo].[LiquidacionesPorRomaneaje] a,
     [dbo].[Clientes] b
where a.IdCliente = b.IdCliente
and   a.IdCliente = @IdProductor
and   a.IdEstatus = 1


