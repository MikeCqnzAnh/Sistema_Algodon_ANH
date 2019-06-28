CREATE procedure sp_ConsultaContratosDetalle
--declare
@IdContratoAlgodon int 
as
Declare @Lotes VARCHAR(100)
SELECT @Lotes = COALESCE(@Lotes + ', ', '') + Lote FROM [dbo].[ContratoCompraDetalle] a, [dbo].[Tierras] b,[dbo].[ContratoCompra] c where a.IdLote = b.IdTierra and a.IdContratoAlgodon = c.IdContratoAlgodon and a.IdContratoAlgodon = @IdContratoAlgodon
select a.IdContratoAlgodon,
	   b.IdCliente,
       b.Nombre,
	   b.RfcApoderado,
	   b.Rfc,
	   c.IdAsociacion,
	   c.Descripcion,
	   a.Pacas,
	   a.SuperficieComprometida,
	   @Lotes as Lotes,
	   a.PrecioQuintal,
	   a.Puntos,
	   a.FechaLiquidacion,
	   a.Presidente,
	   a.IdModalidadCompra,
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
from [dbo].[ContratoCompra] a,
	 [dbo].[Clientes] b,
     [dbo].[Asociaciones] c
	 --[dbo].[ContratoCompraDetalle] d,
	 --[dbo].[Tierras] e
where a.IdProductor = b.IdCliente
and   b.IdCuentaDe = c.IdAsociacion
and   a.IdContratoAlgodon = @IdContratoAlgodon
and   a.IdEstatus = 1
