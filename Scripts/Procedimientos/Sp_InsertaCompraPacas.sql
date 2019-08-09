Create Procedure Sp_InsertaCompraPacas
 @IdCompra int output
,@IdContratoAlgodon int 
,@IdProductor int
,@IdPlanta int
,@IdModalidadCompra int 
,@Fecha datetime
,@TotalPacas int
,@Observaciones varchar(500)
,@CastigoMicros float
,@CastigoLargoFibra float
,@CastigoResistenciaFibra float
,@TotalPesosMx float
,@TotalDlls float
,@InteresPesosMx float
,@InteresDlls float
,@PrecioQuintal float
,@PrecioQuintalBorregos float
,@PrecioDolar float
,@Descuento float
,@Total float
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
			 ,@TotalPesosMx
			 ,@TotalDlls
			 ,@InteresPesosMx
			 ,@InteresDlls
			 ,@PrecioQuintal
			 ,@PrecioQuintalBorregos
			 ,@PrecioDolar
			 ,@Descuento
			 ,@Total
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
		 ,TotalPesosMx
		 ,TotalDlls
		 ,InteresPesosMx
		 ,InteresDlls
		 ,PrecioQuintal
		 ,PrecioQuintalBorregos
		 ,PrecioDolar
		 ,Descuento
		 ,Total
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
		  ,TotalPesosMx = source.TotalPesosMx
		  ,TotalDlls = source.TotalDlls
		  ,InteresPesosMx = source.InteresPesosMx
		  ,InteresDlls = source.InteresDlls
		  ,PrecioQuintal = source.PrecioQuintal
		  ,PrecioQuintalBorregos = source.PrecioQuintalBorregos
		  ,PrecioDolar = source.PrecioDolar
		  ,Descuento = source.Descuento
		  ,Total = source.Total
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
           ,[TotalPesosMx]
           ,[TotalDlls]
           ,[InteresPesosMx]
           ,[InteresDlls]
           ,[PrecioQuintal]
           ,[PrecioQuintalBorregos]
           ,[PrecioDolar]
           ,[Descuento]
           ,[Total]
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
           ,source.TotalPesosMx
           ,source.TotalDlls
           ,source.InteresPesosMx
           ,source.InteresDlls
           ,source.PrecioQuintal
           ,source.PrecioQuintalBorregos
           ,source.PrecioDolar
           ,source.Descuento
           ,source.Total
           ,source.IdEstatusCompra);
	set @IdCompra = SCOPE_IDENTITY()
end
   return @IdCompra