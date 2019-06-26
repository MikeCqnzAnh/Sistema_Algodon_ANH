alter procedure sp_ConsultaContratosDetalleEmpresa
--declare
@IdContratoAlgodon int 
as
Declare @Lotes VARCHAR(100)
SELECT @Lotes = COALESCE(@Lotes + ', ', '') + Lote FROM [dbo].[ContratoCompraDetalle] a, [dbo].[Tierras] b,[dbo].[ContratoCompra] c where a.IdLote = b.IdTierra and a.IdContratoAlgodon = c.IdContratoAlgodon and a.IdContratoAlgodon = @IdContratoAlgodon
select a.IdContratoAlgodon,
	   b.IdCliente,
       b.Nombre,
	   b.RfcApoderado,
	   b.RfcFisica,
	   b.CalleFisica,
	   b.NumeroFisica,
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
	   a.IdEstatus,
	   d.IdDatosEmpresa,
	   d.RazonSocial,
	   d.RFCEmpresa,
	   d.RepresentanteLegal,
	   d.RFCRepresentante,
	   d.Calle,
	   d.NumExt,
	   d.Colonia,
	   d.CodigoPostal,
	   d.Estado,
	   d.Municipio
from [dbo].[ContratoCompra] a,
	 [dbo].[Clientes] b,
     [dbo].[Asociaciones] c,
	 [dbo].[DatosEmpresa] d
where a.IdProductor = b.IdCliente
and   b.IdCuentaDe = c.IdAsociacion
and   a.IdContratoAlgodon = @IdContratoAlgodon
and   a.IdEstatus = 1