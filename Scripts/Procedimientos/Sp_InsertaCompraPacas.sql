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
,@CastigoUI float
,@CastigoBarkLevel1 float
,@CastigoBarkLevel2 float
,@CastigoPrepLevel1 float
,@CastigoPrepLevel2 float
,@CastigoOtherLevel1 float
,@CastigoOtherLevel2 float
,@CastigoPlasticLevel1 float
,@CastigoPlasticLevel2 float
,@IdUnidadPeso int
,@ValorConversion float
,@Unidad int
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
,@FechaCreacion datetime
,@FechaActualizacion datetime 

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
			 ,@CastigoUI 
			 ,@CastigoBarkLevel1 
			 ,@CastigoBarkLevel2
			 ,@CastigoPrepLevel1 
			 ,@CastigoPrepLevel2 
			 ,@CastigoOtherLevel1 
			 ,@CastigoOtherLevel2 
			 ,@CastigoPlasticLevel1 
			 ,@CastigoPlasticLevel2 
			 ,@IdUnidadPeso 
			 ,@ValorConversion 
			 ,@Unidad 
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
		 ,CastigoUI 
		 ,CastigoBarkLevel1 
		 ,CastigoBarkLevel2
		 ,CastigoPrepLevel1 
		 ,CastigoPrepLevel2 
		 ,CastigoOtherLevel1 
		 ,CastigoOtherLevel2 
		 ,CastigoPlasticLevel1 
		 ,CastigoPlasticLevel2 
		 ,IdUnidadPeso 
		 ,ValorConversion 
		 ,Unidad 
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
		  ,CastigoUI = source.CastigoUI
		  ,CastigoBarkLevel1  = source.CastigoBarkLevel1
		  ,CastigoBarkLevel2 = source.CastigoBarkLevel2
		  ,CastigoPrepLevel1  = source.CastigoPrepLevel1
		  ,CastigoPrepLevel2  = source.CastigoPrepLevel2
		  ,CastigoOtherLevel1  = source.CastigoOtherLevel1
		  ,CastigoOtherLevel2  = source.CastigoOtherLevel2
	  	  ,CastigoPlasticLevel1  = source.CastigoPlasticLevel1
	 	  ,CastigoPlasticLevel2  = source.CastigoPlasticLevel2
		  ,IdUnidadPeso  = source.IdUnidadPeso
		  ,ValorConversion  = source.ValorConversion
		  ,Unidad  = source.Unidad
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
		   ,[CastigoUI] 
		   ,[CastigoBarkLevel1]
		   ,[CastigoBarkLevel2]
		   ,[CastigoPrepLevel1] 
		   ,[CastigoPrepLevel2] 
		   ,[CastigoOtherLevel1] 
		   ,[CastigoOtherLevel2] 
		   ,[CastigoPlasticLevel1] 
		   ,[CastigoPlasticLevel2] 
		   ,[IdUnidadPeso] 
		   ,[ValorConversion] 
		   ,[Unidad] 
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
		   ,source.CastigoUI 
		   ,source.CastigoBarkLevel1 
	       ,source.CastigoBarkLevel2
		   ,source.CastigoPrepLevel1 
		   ,source.CastigoPrepLevel2 
		   ,source.CastigoOtherLevel1 
		   ,source.CastigoOtherLevel2 
		   ,source.CastigoPlasticLevel1 
		   ,source.CastigoPlasticLevel2 
		   ,source.IdUnidadPeso 
		   ,source.ValorConversion 
		   ,source.Unidad 
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