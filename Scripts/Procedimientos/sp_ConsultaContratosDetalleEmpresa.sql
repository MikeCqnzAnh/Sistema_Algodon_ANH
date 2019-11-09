CREATE Procedure sp_ConsultaContratosDetalleEmpresa
--declare
@IdContratoAlgodon int 
as
Declare @Lotes VARCHAR(100)
SELECT @Lotes = COALESCE(@Lotes + ', ', '') + Lote FROM [dbo].[ContratoCompraDetalle] a, [dbo].[Tierras] b,[dbo].[ContratoCompra] c where a.IdLote = b.IdTierra and a.IdContratoAlgodon = c.IdContratoAlgodon and a.IdContratoAlgodon = @IdContratoAlgodon
select a.IdContratoAlgodon,
	   b.IdTipoPersona,
	   b.IdCliente,
       b.Nombre,
	   b.RfcApoderado,
	   b.Rfc,
	   b.CalleFisica,
	   b.NumeroFisica,
	   b.ColoniaFisica,
	   b.CalleMoral,
	   b.NumeroMoral,
	   b.ColoniaMoral,
	   b.IdTipoPersona,
	   isnull(c.IdAsociacion,0) as IdAsociacion,
	   isnull(c.Descripcion,'') as Descripcion,
	   a.Pacas,
	   a.SuperficieComprometida,
	   isnull(@Lotes,'') as Lotes,
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
	   d.EntreCalle1,
	   d.EntreCalle2,
	   d.Referencia,
	   d.Poblacion,
	   d.Colonia,
	   d.CodigoPostal,
	   d.Pais,
	   d.Estado,
	   d.Municipio,
	   d.LugarExpedicion
from [dbo].[ContratoCompra] a inner join [dbo].[Clientes] b on a.IdProductor = b.IdCliente
							  left join [dbo].[Asociaciones] c	on b.IdCuentaDe = c.IdAsociacion
    ,[dbo].[DatosEmpresa] d
where a.IdContratoAlgodon = @IdContratoAlgodon
and   a.IdEstatus = 1