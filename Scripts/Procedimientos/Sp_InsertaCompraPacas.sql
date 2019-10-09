Create Procedure Sp_InsertaCompraPacas
 @IdCompra int output
,@IdContratoAlgodon int 
,@IdProductor int
,@IdPlanta int
,@IdModalidadCompra int 
,@Fecha datetime
,@TotalPacas int
,@Observaciones varchar(max)
,@CastigoMicros float
,@CastigoLargoFibra float
,@CastigoResistenciaFibra float
,@InteresPesosMx float
,@InteresDlls float
,@PrecioQuintal float
,@PrecioQuintalBorregos float
,@PrecioDolar float
,@subtotal float
,@CastigoDls float
,@AnticipoDls float
,@TotalDlls float
,@TotalPesosMx float
,@IdEstatusCompra int
as
begin 
set nocount on
merge CompraPacas as target
using (select @IdCompra
			 ,@IdContratoAlgodon
			 ,@IdProductor
			 ,@IdPlanta
			 ,@IdModalidadCompra
			 ,@Fecha
			 ,@TotalPacas
			 ,@Observaciones
			 ,@CastigoMicros
			 ,@CastigoLargoFibra
			 ,@CastigoResistenciaFibra
			 ,@InteresPesosMx
			 ,@InteresDlls
			 ,@PrecioQuintal
			 ,@PrecioQuintalBorregos
			 ,@PrecioDolar
			 ,@subtotal
			 ,@CastigoDls
			 ,@AnticipoDls
			 ,@TotalDlls
			 ,@TotalPesosMx
			 ,@IdEstatusCompra )
as source(IdCompra
		 ,IdContratoAlgodon
		 ,IdProductor
		 ,IdPlanta
		 ,IdModalidadCompra
		 ,Fecha
		 ,TotalPacas
		 ,Observaciones
		 ,CastigoMicros
		 ,CastigoLargoFibra
		 ,CastigoResistenciaFibra
		 ,InteresPesosMx
		 ,InteresDlls
		 ,PrecioQuintal
		 ,PrecioQuintalBorregos
		 ,PrecioDolar
		 ,subtotal
		 ,CastigoDls
		 ,AnticipoDls
		 ,TotalDlls
		 ,TotalPesosMx
		 ,IdEstatusCompra)
on (target.IdCompra = source.IdCompra)
when matched then
update set IdContratoAlgodon = source.IdContratoAlgodon
		  ,IdProductor = source.IdProductor
		  ,IdPlanta = source.IdPlanta
		  ,IdModalidadCompra = source.IdModalidadCompra
		  ,Fecha = source.Fecha
		  ,TotalPacas = source.TotalPacas
		  ,Observaciones = source.Observaciones
		  ,CastigoMicros = source.CastigoMicros
		  ,CastigoLargoFibra = source.CastigoLargoFibra
		  ,CastigoResistenciaFibra = source.CastigoResistenciaFibra
		  ,InteresPesosMx = source.InteresPesosMx
		  ,InteresDlls = source.InteresDlls
		  ,PrecioQuintal = source.PrecioQuintal
		  ,PrecioQuintalBorregos = source.PrecioQuintalBorregos
		  ,PrecioDolar = source.PrecioDolar
		  ,subtotal = source.subtotal
		  ,CastigoDls = source.CastigoDls
		  ,AnticipoDls = source.AnticipoDls
          ,TotalDlls = source.TotalDlls
          ,TotalPesosMx = source.TotalPesosMx
		  ,IdEstatusCompra = source.IdEstatusCompra
		 when not matched then
 INSERT (   [IdContratoAlgodon]
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
           ,[subtotal]
           ,[CastigoDls]
		   ,[AnticipoDls]
           ,[TotalDlls]
           ,[TotalPesosMx]
           ,[IdEstatusCompra])
     VALUES
           (source.IdContratoAlgodon
           ,source.IdProductor
           ,source.IdPlanta
           ,source.IdModalidadCompra
           ,source.Fecha
           ,source.TotalPacas
           ,source.Observaciones
           ,source.CastigoMicros
           ,source.CastigoLargoFibra
           ,source.CastigoResistenciaFibra
		   ,source.InteresPesosMx
           ,source.InteresDlls
           ,source.PrecioQuintal
           ,source.PrecioQuintalBorregos
           ,source.PrecioDolar
		   ,source.subtotal
		   ,source.CastigoDls
           ,source.AnticipoDls
           ,source.TotalDlls
           ,source.TotalPesosMx
           ,source.IdEstatusCompra);
	set @IdCompra = SCOPE_IDENTITY()
end
   return @IdCompra