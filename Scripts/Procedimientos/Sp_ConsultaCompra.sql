alter Procedure Sp_ConsultaCompra
@IdCompra int,
@Nombre varchar(max)
as
if @IdCompra = 0 and @Nombre <> ''
begin
	SELECT [co].[IdCompra]
		  ,[co].[IdContratoAlgodon]
		  ,[co].[IdProductor]
		  ,[cl].[Nombre]
		  ,[co].[IdPlanta]
		  ,[co].[IdModalidadCompra]
		  ,[co].[Fecha]
		  ,[co].[TotalPacas]
		  ,[co].[Observaciones]
		  ,[co].[CastigoMicros]
		  ,[co].[CastigoLargoFibra]
		  ,[co].[CastigoResistenciaFibra]
		  ,[co].[TotalPesosMx]
		  ,[co].[TotalDlls]
		  ,[co].[InteresPesosMx]
		  ,[co].[InteresDlls]
		  ,[co].[PrecioQuintal]
		  ,[co].[PrecioQuintalBorregos]
		  ,[co].[PrecioDolar]
		  ,[co].[Descuento]
		  ,[co].[Total]
		  ,[co].[IdEstatusCompra]
	  FROM [dbo].[CompraPacas] Co inner join [dbo].[clientes] cl on [co].[idproductor] = [cl].[idcliente]
	  WHERE [cl].[Nombre] like '%'+@Nombre+'%'
 end
 else if @IdCompra > 0 and @Nombre = ''
 begin
		SELECT [co].[IdCompra]
		  ,[co].[IdContratoAlgodon]
		  ,[co].[IdProductor]
		  ,[cl].[Nombre]
		  ,[co].[IdPlanta]
		  ,[co].[IdModalidadCompra]
		  ,[co].[Fecha]
		  ,[co].[TotalPacas]
		  ,[co].[Observaciones]
		  ,[co].[CastigoMicros]
		  ,[co].[CastigoLargoFibra]
		  ,[co].[CastigoResistenciaFibra]
		  ,[co].[TotalPesosMx]
		  ,[co].[TotalDlls]
		  ,[co].[InteresPesosMx]
		  ,[co].[InteresDlls]
		  ,[co].[PrecioQuintal]
		  ,[co].[PrecioQuintalBorregos]
		  ,[co].[PrecioDolar]
		  ,[co].[Descuento]
		  ,[co].[Total]
		  ,[co].[IdEstatusCompra]
	  FROM [dbo].[CompraPacas] Co inner join [dbo].[clientes] cl on [co].[idproductor] = [cl].[idcliente]
	  WHERE [co].[IdCompra] = @IdCompra
end
else
begin
	SELECT [co].[IdCompra]
		  ,[co].[IdContratoAlgodon]
		  ,[co].[IdProductor]
		  ,[cl].[Nombre]
		  ,[co].[IdPlanta]
		  ,[co].[IdModalidadCompra]
		  ,[co].[Fecha]
		  ,[co].[TotalPacas]
		  ,[co].[Observaciones]
		  ,[co].[CastigoMicros]
		  ,[co].[CastigoLargoFibra]
		  ,[co].[CastigoResistenciaFibra]
		  ,[co].[TotalPesosMx]
		  ,[co].[TotalDlls]
		  ,[co].[InteresPesosMx]
		  ,[co].[InteresDlls]
		  ,[co].[PrecioQuintal]
		  ,[co].[PrecioQuintalBorregos]
		  ,[co].[PrecioDolar]
		  ,[co].[Descuento]
		  ,[co].[Total]
		  ,[co].[IdEstatusCompra]
	  FROM [dbo].[CompraPacas] Co inner join [dbo].[clientes] cl on [co].[idproductor] = [cl].[idcliente]
end