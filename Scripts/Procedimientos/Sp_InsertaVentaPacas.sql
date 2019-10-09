CREATE Procedure Sp_InsertaVentaPacas
 @IdVenta int output
,@IdContratoAlgodon int 
,@IdComprador int
,@IdPlanta int
--,@IdModalidadVenta int 
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
,@IdEstatusVenta int
as
begin 
set nocount on
merge VentaPacas as target
using (select @IdVenta
			 ,@IdContratoAlgodon
			 ,@IdComprador
			 ,@IdPlanta
			 --,@IdModalidadCompra
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
			 ,@IdEstatusVenta )
as source(IdVenta
		 ,IdContratoAlgodon
		 ,IdComprador
		 ,IdPlanta
		 --,IdModalidadCompra
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
		 ,IdEstatusVenta)
on (target.IdVenta = source.IdVenta)
when matched then
update set IdContratoAlgodon = source.IdContratoAlgodon
		  ,IdComprador = source.IdComprador
		  ,IdPlanta = source.IdPlanta
		  --,IdModalidadCompra = source.IdModalidadCompra
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
		  ,IdEstatusVenta = source.IdEstatusVenta
		 when not matched then
 INSERT (   [IdContratoAlgodon]
		   ,[IdComprador]
           ,[IdPlanta]
           --,[IdModalidadCompra]
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
           ,[IdEstatusVenta])
     VALUES
           (source.IdContratoAlgodon
           ,source.IdComprador
           ,source.IdPlanta
           --,source.IdModalidadCompra
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
           ,source.IdEstatusVenta);
	set @IdVenta = SCOPE_IDENTITY()
end
   return @IdVenta