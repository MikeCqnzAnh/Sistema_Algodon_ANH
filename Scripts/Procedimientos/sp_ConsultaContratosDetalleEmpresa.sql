ALTER Procedure sp_ConsultaContratosDetalleEmpresa
@IdContratoAlgodon int
as
Declare @Lotes VARCHAR(100)
SELECT @Lotes = COALESCE(@Lotes + ', ', '') + Lote FROM [dbo].[ContratoCompraDetalle] a, [dbo].[Tierras] b,[dbo].[ContratoCompra] c where a.IdLote = b.IdTierra and a.IdContratoAlgodon = c.IdContratoAlgodon and a.IdContratoAlgodon = @IdContratoAlgodon
select a.IdContratoAlgodon,
	   b.IdTipoPersona,
	   b.IdCliente,
       b.Nombre,
	   b.Rfc,
	   b.ApoderadoFisica,
	   b.RfcApoderado,
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
	   a.PacasCompradas,
	   a.PacasDisponibles,
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
	   d.LugarExpedicion,
	   e.IdConfiguracion,
	   e.ParamDia1,
	   e.ParamMes1,
	   e.ParamTemp1,
	   e.ParamMes2,
	   e.ParamTemp2,
	   e.Parammes3,
	   e.ParamPrompesomin,
	   e.ParamPromPesomax,
	   e.Parampesomin,
	   e.TemporadaAnual	   
from [dbo].[ContratoCompra] a inner join [dbo].[Clientes] b on a.IdProductor = b.IdCliente
							  left join [dbo].[Asociaciones] c	on b.IdCuentaDe = c.IdAsociacion
    ,[dbo].[DatosEmpresa] d,ConfiguracionParamContratosCompra e
where a.IdContratoAlgodon = @IdContratoAlgodon
and   a.IdEstatus = 1
