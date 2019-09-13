Create Procedure Sp_ConsultaCompraPorProductor
@IdProductor int
as
SELECT [IdCompra]
      ,[IdContratoAlgodon]
      ,[IdProductor]
      ,[IdPlanta]
      ,[IdModalidadCompra]
      ,[Fecha]
      ,[TotalPacas]
      ,[Observaciones]
      ,[CastigoMicros]
      ,[CastigoLargoFibra]
      ,[CastigoResistenciaFibra]
      ,[InteresPesosMx]
      ,[InteresDlls]
      ,[PrecioQuintal]
      ,[PrecioQuintalBorregos]
      ,[PrecioDolar]
	  ,[Subtotal]
	  ,[CastigoDls]
	  ,[AnticipoDls]
      ,[TotalDlls]
	  ,[TotalPesosMx]
      ,[IdEstatusCompra]
  FROM [dbo].[CompraPacas]
  where IdProductor = @IdProductor