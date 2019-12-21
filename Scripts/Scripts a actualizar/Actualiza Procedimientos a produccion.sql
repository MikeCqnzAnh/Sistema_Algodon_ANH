alter procedure sp_ConsultaLiquidacionVenta
--declare
@Seleccionar bit = 0 
as
select LR.IdLiquidacion,
	   lr.IdOrdenTrabajo,
	   lr.TotalHueso,
	   count(cc.BaleID)as PacasCantidad,
	   count(case when cc.EstatusVenta = 1 then cc.BaleID end)  as PacasDisponibles,
	   count(case when cc.EstatusVenta = 2 then cc.BaleID end)  as PacasVendidas,
	   sum(pd.Kilos) as PesoPluma,
	   lr.TotalSemilla,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
		where cc.FlagTerminado = 1 and lr.IdLiquidacion is not null
		group by LR.IdLiquidacion,lr.IdOrdenTrabajo,lr.TotalHueso, lr.TotalSemilla
		having   count(case when cc.EstatusVenta = 1 then cc.BaleID end) > 0 --< Count(cc.BaleID)
		order by  lr.IdOrdenTrabajo
go
alter procedure sp_ConModVenId
@IdModalidadVenta int
as
select a.IdModoDetalle,
       a.IdClasificacion,
	   a.Diferencial
from [dbo].[ModosVentaDetalle] a
where a.IdModoEncabezado = @IdModalidadVenta
go
alter proc sp_ConsultaDetalleModoVenta
@IdModoEncabezado int
as
select md.IdModoDetalle,me.IdModoEncabezado,cc.idclasificacion, cc.clavecorta,cc.descripcion,md.Diferencial 
from ClasesClasificacion cc, ModosVentaEncabezado me, ModosVentaDetalle md 
where me.IdModoEncabezado = md.IdModoEncabezado and md.IdClasificacion = cc.IdClasificacion and me.IdModoEncabezado = @IdModoEncabezado
go
alter procedure sp_ConsultaDiferencialesVenta
--declare
@IdModo int-- = 2
as
select b.Descripcion,       
	   c.Descripcion,
	   a.Diferencial
from [dbo].[ModosVentaDetalle] a,
     [dbo].[ModosVentaEncabezado] b,
     [dbo].[ClasesClasificacion] c
where a.IdModoEncabezado = @IdModo
and   a.IdModoEncabezado = b.IdModoEncabezado
and   a.IdClasificacion = c.IdClasificacion
go
alter procedure sp_ConsultaModosVenta
as
select a.IdModoEncabezado,
	   a.Descripcion
from [dbo].[ModosVentaEncabezado] a
where a.IdEstatus = 1
go
alter procedure sp_ConsultaModosVentaEncabezado
as
select a.IdModoEncabezado,
		a.Descripcion,
		a.IdEstatus
from [dbo].[ModosVentaEncabezado] a
where a.IdEstatus = 1
go
Alter proc sp_InsertaModoVentaDetalle
@IdModoDetalle int,
@IdModoEncabezado int,
@IdClasificacion Int,
@Diferencial int
as
BEGIN
SET NOCOUNT ON
MERGE ModosVentaDetalle AS TARGET
USING (SELECT @IdModoDetalle
			 ,@IdModoEncabezado
			 ,@IdClasificacion
			 ,@Diferencial) AS SOURCE 
			 (IdModoDetalle
			 ,IdModoEncabezado
			 ,IdClasificacion
			 ,Diferencial)
ON (TARGET.IdModoDetalle = SOURCE.IdModoDetalle)
WHEN MATCHED THEN
UPDATE SET 	IdModoEncabezado = SOURCE.IdModoEncabezado,
			IdClasificacion = SOURCE.IdClasificacion,
			Diferencial = SOURCE.Diferencial			
WHEN NOT MATCHED THEN
        INSERT (IdModoEncabezado
			   ,IdClasificacion
			   ,Diferencial)
        VALUES (Source.IdModoEncabezado
			   ,Source.IdClasificacion
			   ,Source.Diferencial);
END
go
Alter procedure sp_InsertaModoVentaEncabezado
@IdModoEncabezado int output,
@Descripcion varchar(30),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as
begin
set nocount on
merge [dbo].[ModosVentaEncabezado] as target
using (select @IdModoEncabezado
			 ,@Descripcion
			 ,@IdEstatus
			 ,@IdUsuarioCreacion
			 ,@FechaCreacion) as source 
			 (IdModoEncabezado
			 ,Descripcion
			 ,IdEstatus
			 ,IdUsuarioCreacion
			 ,FechaCreacion)
ON (target.IdModoEncabezado = source.IdModoEncabezado)
WHEN MATCHED THEN
UPDATE SET Descripcion = source.Descripcion,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (Descripcion,IdEstatus,IdUsuarioCreacion,FechaCreacion)
VALUES (source.Descripcion,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
SET @IdModoEncabezado = SCOPE_IDENTITY()
END
RETURN @IdModoEncabezado
go
Alter proc sp_InsertaModosVentaDetalle
@IdModoDetalle int,
@IdModoEncabezado int,
@IdClasificacion int,
@Diferencial int
as
begin
set nocount on
merge [dbo].[ModosVentaDetalle] as target
using (select @IdModoDetalle
			 ,@IdModoEncabezado
			 ,@IdClasificacion
			 ,@Diferencial) as source 
			 (IdModoDetalle
			 ,IdModoEncabezado
			 ,IdClasificacion
			 ,Diferencial)
ON (target.IdModoDetalle = source.IdModoDetalle)
WHEN MATCHED THEN
UPDATE SET IdModoEncabezado = source.IdModoEncabezado,
		   IdClasificacion = source.IdClasificacion,
		   Diferencial = source.Diferencial
WHEN NOT MATCHED THEN
INSERT (IdModoEncabezado,IdClasificacion,Diferencial)
VALUES (source.IdModoEncabezado,source.IdClasificacion,source.Diferencial);
END
go
Alter proc sp_LlenaComboModalidadesVenta
as
select IdModoEncabezado, Descripcion 
from [ModosVentaEncabezado]
where IdEstatus = 1
go
alter proc sp_consultaClasesCalculo
--DECLARE
@NumPaca int ,
@IdPlanta int,
@IdPaquete int
as
if @NumPaca = 0
	begin
		select
		     hd.[IdPlantaOrigen]
			,isnull(hd.[Kilos],0) as Kilos
			,Hd.[LotID]
			,hd.[BaleID]
			,hd.[BaleGroup]
			,hd.[Operator]
			,hd.[Date]
			,hd.[Temperature]
			,hd.[Humidity]
			,hd.[Amount]
			,hd.[UHML]
			,hd.[UI]
			,hd.[Strength]
			,hd.[Elongation]
			,hd.[SFI]
			,hd.[Maturity]
			,Cc.ClaveCorta as Grade
			,hd.[Moist]
			,hd.[Mic]
			,hd.[Rd]
			,hd.[Plusb]
			,hd.[ColorGrade]
			,hd.[TrashCount]
			,hd.[TrashArea]
			,hd.[TrashID]
			,hd.[SCI]
			,hd.[Nep]
			,hd.[UV]
			,0 as FlagTerminado
			,Pd.IdOrdenTrabajo
		from [dbo].[HVIDetalle] Hd inner join ProduccionDetalle Pd on Hd.BaleID = Pd.FolioCIA
						   inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
						   inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
  		where Pd.FolioCIA = @NumPaca and hd.IdPlantaOrigen = @IdPlanta
		order by BaleID asc
	end
--else if exists (select baleid from CalculoClasificacion where BaleId = @NumPaca and IdPlantaOrigen = @IdPlanta and IdPaqueteEncabezado = @IdPaquete)
--	begin
--		select 
--		     [IdPlantaOrigen]
--			,[LotID]
--			,[BaleID]
--			,[BaleGroup]
--			,[Operator]
--			,[Date]
--			,[Temperature]
--			,[Humidity]
--			,[Amount]
--			,[UHML]
--			,[UI]
--			,[Strength]
--			,[Elongation]
--			,[SFI]
--			,[Maturity]
--			,[Grade]
--			,[Moist]
--			,[Mic]
--			,[Rd]
--			,[Plusb]
--			,[ColorGrade]
--			,[TrashCount]
--			,[TrashArea]
--			,[TrashID]
--			,[SCI]
--			,[Nep]
--			,[UV]
--			,FlagTerminado
--			,IdHviDetalle 
--			,IdOrdenTrabajo
--		from CalculoClasificacion 
--		where  BaleId = @NumPaca and IdPlantaOrigen = @IdPlanta and IdPaqueteEncabezado = @IdPaquete
--	end
else
	begin
		select
		     Hd.[IdPlantaOrigen]
			,isnull(hd.[Kilos],0) as Kilos
			,hd.[LotID]
			,hd.[BaleID]
			,hd.[BaleGroup]
			,hd.[Operator]
			,hd.[Date]
			,hd.[Temperature]
			,hd.[Humidity]
			,hd.[Amount]
			,hd.[UHML]
			,hd.[UI]
			,hd.[Strength]
			,hd.[Elongation]
			,hd.[SFI]
			,hd.[Maturity]
			,Cc.ClaveCorta as Grade
			,hd.[Moist]
			,hd.[Mic]
			,hd.[Rd]
			,hd.[Plusb]
			,hd.[ColorGrade]
			,hd.[TrashCount]
			,hd.[TrashArea]
			,hd.[TrashID]
			,hd.[SCI]
			,hd.[Nep]
			,hd.[UV]
			,0 as FlagTerminado
			,Pd.IdOrdenTrabajo
		from [dbo].[HVIDetalle] Hd inner join ProduccionDetalle Pd on Hd.BaleID = Pd.FolioCIA
						   inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
						   inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where Pd.FolioCIA = @NumPaca and hd.IdPlantaOrigen = @IdPlanta 
			order by BaleID asc
end
go
Alter procedure sp_ConsultaPacasCalculoClasif
@IdPaquete int 
as
select   
		 a.[IdPlantaOrigen]
		,isnull(a.[Kilos],0) as Kilos
		,a.[LotID]
		,a.[BaleID]
		,a.[BaleGroup]
		,a.[Operator]
		,a.[Date]
		,a.[Temperature]
		,a.[Humidity]
		,a.[Amount]
		,a.[UHML]
		,a.[UI]
		,a.[Strength]
		,a.[Elongation]
		,a.[SFI]
		,a.[Maturity]
		,a.[Grade]
		,a.[Moist]
		,a.[Mic]
		,a.[Rd]
		,a.[Plusb]
		,a.[ColorGrade]
		,a.[TrashCount]
		,a.[TrashArea]
		,a.[TrashID]
		,a.[SCI]
		,a.[Nep]
		,a.[UV]
		,a.FlagTerminado
		,a.IdVentaEnc
		,a.IdOrdenTrabajo
from [dbo].[CalculoClasificacion] a
where a.IdPaqueteEncabezado = @IdPaquete 
order by a.BaleId asc
go
alter procedure [dbo].[sp_InsertarClasificacionPacas]
@IdCalculoClasificacion int,
@IdPaqueteEncabezado int,
@IdOrdenTrabajo int,
@IdPlantaOrigen int,
@Kilos int,
@LotID int,
@BaleID int ,
@BaleGroup varchar(5) ,
@Operator varchar(25) ,
@Date datetime ,
@Temperature float ,
@Humidity float ,
@Amount int ,
@UHML float ,
@UI float ,
@Strength float ,
@Elongation float ,
@SFI float ,
@Maturity float ,
@Grade varchar(6) ,
@Moist float ,
@Mic float ,
@Rd float ,
@Plusb float ,
@ColorGrade varchar(4) ,
@TrashCount int ,
@TrashArea float ,
@TrashID int ,
@SCI int ,
@Nep int ,
@UV float ,
@FlagTerminado bit,
@EstatusVenta int
as 
begin 
set nocount on
merge [dbo].[CalculoClasificacion] as target
  using (select @IdCalculoClasificacion,
				@IdPaqueteEncabezado,
				@IdOrdenTrabajo,
				@IdPlantaOrigen,
				@Kilos,
				@LotID,
				@BaleID  ,
				@BaleGroup  ,
				@Operator ,
				@Date  ,
				@Temperature  ,
				@Humidity  ,
				@Amount  ,
				@UHML  ,
				@UI  ,
				@Strength  ,
				@Elongation  ,
				@SFI  ,
				@Maturity  ,
				@Grade  ,
				@Moist  ,
				@Mic  ,
				@Rd  ,
				@Plusb  ,
				@ColorGrade  ,
				@TrashCount  ,
				@TrashArea  ,
				@TrashID  ,
				@SCI  ,
				@Nep  ,
				@UV  ,
				@FlagTerminado,
				@EstatusVenta) 
								AS SOURCE 
			   (IdCalculoClasificacion,
				IdPaqueteEncabezado,
				IdOrdenTrabajo,
				IdPlantaOrigen,
				Kilos,
				LotID,
				BaleID  ,
				BaleGroup  ,
				Operator ,
				[Date]  ,
				Temperature  ,
				Humidity  ,
				Amount  ,
				UHML  ,
				UI  ,
				Strength  ,
				Elongation  ,
				SFI  ,
				Maturity  ,
				Grade  ,
				Moist  ,
				Mic  ,
				Rd  ,
				Plusb  ,
				ColorGrade  ,
				TrashCount  ,
				TrashArea  ,
				TrashID  ,
				SCI  ,
				Nep  ,
				UV  ,
				FlagTerminado,
				EstatusVenta)
ON (target.BaleId = SOURCE.BaleId and target.IdPaqueteEncabezado = SOURCE.IdPaqueteEncabezado and target.IdPlantaOrigen = SOURCE.IdPlantaOrigen)
WHEN MATCHED THEN
UPDATE SET		kilos = source.Kilos,
				lotid = source.lotid,
				BaleGroup  = source.BaleGroup ,
				Operator = source.Operator ,
				[Date]  = source.[Date] ,
				Temperature  = source.Temperature ,
				Humidity  = source.Humidity ,
				Amount  = source.Amount ,
				UHML  = source.UHML ,
				UI  = source.UI ,
				Strength  = source.Strength ,
				Elongation  = source.Elongation ,
				SFI  = source.SFI ,
				Maturity  = source.Maturity ,
				Grade  = source.Grade ,
				Moist  = source.Moist ,
				Mic  = source.Mic ,
				Rd  = source.Rd ,
				Plusb  = source.Plusb ,
				ColorGrade  = source.ColorGrade ,
				TrashCount  = source.TrashCount ,
				TrashArea  = source.TrashArea ,
				TrashID  = source.TrashID ,
				SCI  = source.SCI ,
				Nep  = source.Nep ,
				UV  = source.UV ,
				FlagTerminado = 1 ,
				EstatusVenta = source.EstatusVenta

WHEN NOT MATCHED THEN
INSERT (IdPaqueteEncabezado
		,IdOrdenTrabajo
		,IdPlantaOrigen
		,Kilos
		,LotID
		,BaleId
		,BaleGroup
		,Operator
		,[Date]
		,Temperature
		,Humidity
		,Amount
		,UHML
		,UI
		,Strength
		,Elongation
		,SFI
		,Maturity
		,Grade
		,Moist
		,Mic
		,Rd
		,Plusb
		,ColorGrade
		,TrashCount
		,TrashArea
		,TrashID
		,SCI
		,Nep
		,UV
		,flagterminado
		,EstatusVenta)
        VALUES 
		(source.IdPaqueteEncabezado
		,source.IdOrdenTrabajo
		,source.IdPlantaOrigen
		,source.Kilos
		,source.LotID
		,source.BaleId
		,source.BaleGroup
		,source.Operator
		,source.[Date]
		,source.Temperature
		,source.Humidity
		,source.Amount
		,source.UHML
		,source.UI
		,source.Strength
		,source.Elongation
		,source.SFI
		,source.Maturity
		,source.Grade
		,source.Moist
		,source.Mic
		,source.Rd
		,source.Plusb
		,source.ColorGrade
		,source.TrashCount
		,source.TrashArea
		,source.TrashID
		,source.SCI
		,source.Nep
		,source.UV
		,1
		,source.EstatusVenta);		
END
go
Alter Procedure Sp_ConsultaClasesVenta
@IdPaquete int
as
select pe.idpaquete
	  ,pl.Descripcion as Planta
	  ,cc.Grade
	  ,pe.Descripcion
	  ,count(cc.BaleID) as Pacas
from PaqueteEncabezado pe inner join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado and pe.IdPlanta = cc.IdPlantaOrigen
                          inner join plantas pl on pe.IdPlanta = pl.IdPlanta
where pe.idpaquete = @IdPaquete
group by pe.idpaquete,pl.Descripcion,cc.Grade,pe.Descripcion
go
alter Procedure Sp_InsertaVentaPacas
 @IdVenta int output
,@IdContratoAlgodon int 
,@IdComprador int
,@IdPlanta int
,@IdModalidadVenta int 
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
,@IdEstatusVenta int
as
begin 
set nocount on
merge VentaPacas as target
using (select @IdVenta
			 ,@IdContratoAlgodon
			 ,@IdComprador
			 ,@IdPlanta
			 ,@IdModalidadVenta
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
			 ,@IdEstatusVenta )
as source(IdVenta
		 ,IdContratoAlgodon
		 ,IdComprador
		 ,IdPlanta
		 ,IdModalidadVenta
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
		 ,IdEstatusVenta)
on (target.IdVenta = source.IdVenta)
when matched then
update set IdContratoAlgodon = source.IdContratoAlgodon
		  ,IdComprador = source.IdComprador
		  ,IdPlanta = source.IdPlanta
		  ,IdModalidadVenta = source.IdModalidadVenta
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
		  ,IdEstatusVenta = source.IdEstatusVenta
		 when not matched then
 INSERT (   [IdContratoAlgodon]
		   ,[IdComprador]
           ,[IdPlanta]
           ,[IdModalidadVenta]
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
           ,[IdEstatusVenta])
     VALUES
           (source.IdContratoAlgodon
           ,source.IdComprador
           ,source.IdPlanta
           ,source.IdModalidadVenta
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
           ,source.IdEstatusVenta);
	set @IdVenta = SCOPE_IDENTITY()
end
   return @IdVenta
go
Alter Procedure Sp_ConsultaVentaPacas
@IdVenta int
as
SELECT [IdVenta]
      ,[IdContratoAlgodon]
      ,[IdComprador]
      ,[IdPlanta]
      ,[IdModalidadVenta]
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
      ,[Subtotal]
      ,[CastigoDls]
      ,[AnticipoDls]
      ,[TotalDlls]
      ,[TotalPesosMx]
      ,[IdEstatusVenta]
  FROM [dbo].[VentaPacas]
  WHERE [IdVenta] = @IdVenta
  go
alter procedure sp_ActualizaEstatusVentaPaca
@IdComprador			 int ,
@BaleID					 int ,
@IdLiquidacion			 int,
@IdVentaEnc				 int,
@PrecioDls				 float,
@PrecioClase			 float,
@TipoCambio				 float,
@PrecioMxn				 float,
@Kilos					 float,
@Quintales				 float,
@CastigoResistenciaFibra float,
@CastigoMicros			 float,
@CastigoLargoFibra		 float,
@CastigoUI				 float,
@CastigoBarkLevel1		 float,
@CastigoBarkLevel2		 float,
@CastigoPrepLevel1		 float,
@CastigoPrepLevel2		 float,
@CastigoOtherLevel1		 float,
@CastigoOtherLevel2		 float,
@CastigoPlasticLevel1	 float,
@CastigoPlasticLevel2	 float,
@EstatusVentaUpdate		 int,
@EstatusVentaBusqueda	 int
as
update cc
set cc.estatusVenta = @EstatusVentaUpdate ,
	cc.IdVentaEnc =							case when @IdVentaEnc = 0			   then NULL ELSE @IdVentaEnc				 END,
	cc.PrecioDls =					  ROUND(case when @PrecioDls = 0			   then null ELSE @PrecioDls				 END,4,0),
	cc.PrecioClase =				  ROUND(case when @PrecioClase = 0			   then NULL ELSE @PrecioClase				 END,4,0),
	cc.TipoCambio =					  ROUND(case when @TipoCambio = 0			   then NULL ELSE @TipoCambio				 END,4,0),
	cc.PrecioMxn =					  ROUND(case when @PrecioMxn = 0			   then NULL ELSE @TipoCambio				 END,4,0),
	cc.CastigoResistenciaFibraVenta = ROUND(case when @CastigoResistenciaFibra = 0 then NULL ELSE @CastigoResistenciaFibra	 END,4,0),
	cc.castigoMicVenta =			  ROUND(case when @CastigoMicros = 0		   then NULL ELSE @CastigoMicros			 END,4,0),
	cc.CastigoLargoFibraVenta =		  ROUND(case when @CastigoLargoFibra = 0	   then NULL ELSE @CastigoLargoFibra		 END,4,0),
	cc.CastigoUIVenta =				  ROUND(case when @CastigoUI = 0			   then NULL ELSE @CastigoUI				 END,4,0),
	cc.CastigoBarkLevel1Venta =		  ROUND(case when @CastigoBarkLevel1 = 0 	   then NULL ELSE @CastigoBarkLevel1		 END,4,0),
	cc.CastigoBarkLevel2Venta =		  ROUND(case when @CastigoBarkLevel2 = 0	   then NULL ELSE @CastigoBarkLevel2		 END,4,0),
	cc.CastigoPrepLevel1Venta =		  ROUND(case when @CastigoPrepLevel1 = 0	   then NULL ELSE @CastigoPrepLevel1		 END,4,0),
	cc.CastigoPrepLevel2Venta =		  ROUND(case when @CastigoPrepLevel2 = 0	   then NULL ELSE @CastigoPrepLevel2		 END,4,0),
	cc.CastigoOtherLevel1Venta =	  ROUND(case when @CastigoOtherLevel1 = 0	   then NULL ELSE @CastigoOtherLevel1		 END,4,0),
	cc.CastigoOtherLevel2Venta =	  ROUND(case when @CastigoOtherLevel2 = 0	   then NULL ELSE @CastigoOtherLevel2		 END,4,0),
	cc.CastigoPlasticLevel1Venta =	  ROUND(case when @CastigoPlasticLevel1 = 0    then NULL ELSE @CastigoPlasticLevel1		 END,4,0),
	cc.CastigoPlasticLevel2Venta =	  ROUND(case when @CastigoPlasticLevel2 = 0	   then NULL ELSE @CastigoPlasticLevel2		 END,4,0),
	cc.Kilos =								@kilos,
	cc.Quintales =					  ROUND(@Quintales,4,0)
from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
where cc.FlagTerminado = 1 and cc.estatusVenta = @EstatusVentaBusqueda and pd.FolioCIA = @BaleID and LR.IdLiquidacion = @IdLiquidacion
go
alter procedure sp_ConContComp
@IdComprador int
as
SELECT a.IdContratoAlgodon,
	   a.IdComprador,
	   a.Pacas,
	   isnull(a.PacasVendidas, 0) as PacasVendidas,
	   isnull(a.PacasDisponibles, 0) as PacasDisponibles,
	   a.PrecioQuintal,
	   a.IdUnidadPeso,
	   a.ValorConversion,
	   a.Puntos,
	   a.FechaLiquidacion,
	   a.Temporada,
	   a.IdModalidadVenta,
	   a.PrecioSM,
	   a.PrecioMP,
	   a.preciom,
	   a.PrecioSLMP,
	   a.PrecioSLM,
	   a.PrecioLMP,
	   a.PrecioLM,
	   a.PrecioSGO,
	   a.PrecioGO,
	   a.PrecioO,
	   a.FechaCreacion as Fecha
FROM ContratoVenta a
where a.IdEstatus = 1
and a.IdComprador = @IdComprador
go
Alter proc sp_ConsultaDisponibilidadPacasVentas
as
select (select count(isnull(BaleID,0)) 
		from  CalculoClasificacion  
		where isnull(EstatusVenta,0) = 1) as 'Disponibles',
		 
	   (select isnull(SUM(Kilos),0) 
	    from CalculoClasificacion  
		where  isnull(EstatusVenta,0) = 2) as 'Kilos Comprados',

	  (select count(isnull(BaleID,0)) 
	   from  CalculoClasificacion  
	   where  isnull(EstatusVenta,0) = 2) as 'Vendidas',

	  (select count(isnull(BaleID,0)) 
	   from CalculoClasificacion  
	   where isnull(EstatusVenta,0) = 3) as 'Devolucion',

	  (select count(isnull(BaleID,0)) 
	   from CalculoClasificacion  
	   where isnull(EstatusVenta,0) = 0) as 'Sin Clasificar'
go
Alter Procedure Sp_ActualizaEstatusPacaVenta
@BaleID int,
@LotID int,
@IdVentaEnc int,
@EstatusVentaUpdate int
as
update CalculoClasificacion
set EstatusVenta = @EstatusVentaUpdate
where BaleID = @BaleID and IdVentaEnc = @IdVentaEnc and LotID = @LotID
go
Alter Procedure Sp_ActualizaCantidadPacasVentas
@IdContrato int,
@PacasVendidas int,
@PacasDisponibles int
as
update ContratoVenta
set PacasVendidas = @PacasVendidas,
	PacasDisponibles = @PacasDisponibles
where IdContratoAlgodon = @IdContrato 
go
alter procedure sp_ConsultaPacasVentasFiltro
--declare
@Seleccionar bit =0 ,
@PacaIni int,
@PacaFin int,
@Clase varchar(4)
as
if @Clase <> '' and @PacaIni > 0 and @PacaFin > 0
begin 
select pd.FolioCIA,
	   cc.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   cc.BaleID,
	   pd.Kilos,
	   cc.Grade,
	   isnull(cc.quintales,0) as quintales,
	   isnull(cc.PrecioClase,0) as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.TipoCambio,0) as TipoCambio,
	   isnull(cc.PrecioMxn,0) as PrecioMxn,
	   cc.UI as Uniformidad,
	   cc.Mic as Micros,
	   cc.Strength as Resistencia,
	   cc.UHML as Largo,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
						   left join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID 
						   left join liquidacionesporromaneaje LR on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		where cc.FlagTerminado =1 and cc.EstatusVenta = 1 and
			  cc.BaleID between @PacaIni and @PacaFin and cc.Grade = @Clase
end
else if @Clase = '' and @PacaIni > 0 and @PacaFin > 0
begin
select pd.FolioCIA,
	   cc.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   cc.BaleID,
	   pd.Kilos,
	   cc.Grade,
	   isnull(cc.quintales,0) as quintales,
	   isnull(cc.PrecioClase,0) as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.TipoCambio,0) as TipoCambio,
	   isnull(cc.PrecioMxn,0) as PrecioMxn,
	   cc.UI as Uniformidad,
	   cc.Mic as Micros,
	   cc.Strength as Resistencia,
	   cc.UHML as Largo,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
								 left join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID 
								 left join liquidacionesporromaneaje LR on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo 
								 inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		where cc.FlagTerminado =1 and cc.EstatusVenta = 1 and
			  cc.BaleID between @PacaIni and @PacaFin 
end
else if @Clase <> '' and @PacaIni = 0 and @PacaFin = 0
begin
select pd.FolioCIA,
	   cc.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   cc.BaleID,
	   pd.Kilos,
	   cc.Grade,
	   isnull(cc.quintales,0) as quintales,
	   isnull(cc.PrecioClase,0) as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.TipoCambio,0) as TipoCambio,
	   isnull(cc.PrecioMxn,0) as PrecioMxn,
	   cc.UI as Uniformidad,
	   cc.Mic as Micros,
	   cc.Strength as Resistencia,
	   cc.UHML as Largo,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
								 left join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID 
								 left join liquidacionesporromaneaje LR on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo 
								 inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		where cc.FlagTerminado =1 and cc.EstatusVenta = 1 and cc.Grade = @Clase
end
else if @Clase = '' and @PacaIni = 0 and @PacaFin = 0
begin
select pd.FolioCIA,
	   cc.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   cc.BaleID,
	   pd.Kilos,
	   cc.Grade,
	   isnull(cc.quintales,0) as quintales,
	   isnull(cc.PrecioClase,0) as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.TipoCambio,0) as TipoCambio,
	   isnull(cc.PrecioMxn,0) as PrecioMxn,
	   cc.UI as Uniformidad,
	   cc.Mic as Micros,
	   cc.Strength as Resistencia,
	   cc.UHML as Largo,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
						   left join CalculoClasificacion cc on pd.FolioCIA = cc.BaleID 
						   left join liquidacionesporromaneaje LR on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		where cc.FlagTerminado =1 and cc.EstatusVenta = 1
end
go
alter procedure sp_ConPacaVendida
--declare
@IdVentaEnc int ,
@Seleccionar bit = 0 
as
select pd.FolioCIA,
	   cc.IdOrdenTrabajo,
	   LR.IdLiquidacion,
	   pl.Descripcion,
	   cc.BaleID,
	   cc.Kilos,
	   cc.Grade,
	   cc.quintales,
	   cc.PrecioClase,
	   cc.PrecioDls,
	   cc.TipoCambio,
	   cc.PrecioMxn,
	   ISNULL(cc.CastigoUIVenta,0) as CastigoUIVenta,
	   ISNULL(cc.castigoMicVenta,0) as castigoMicVenta,
	   ISNULL(cc.CastigoResistenciaFibraVenta,0) as CastigoResistenciaFibraVenta,
	   ISNULL(cc.CastigoLargoFibraVenta,0) as CastigoLargoFibraVenta,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
		where cc.FlagTerminado =1 and cc.EstatusVenta  = 2 and cc.IdVentaEnc = @IdVentaEnc
		order by cc.IdOrdenTrabajo
go
alter procedure sp_ConLiqProdVendida
--DECLARE
@IdVenta int ,
@Seleccionar bit = 0 
as
select LR.IdLiquidacion,
	   cc.IdOrdenTrabajo,
	   LR.TotalHueso,
	   count(cc.BaleID)as PacasCantidad,
	   count(case when cc.EstatusVenta = 1 then cc.BaleID end)  as PacasDisponibles,
	   count(case when cc.EstatusVenta = 2 then cc.BaleID end)  as PacasVendidas,
	   sum(isnull(CC.Kilos,0)) as PesoPluma,
	   lr.TotalSemilla,
	   @Seleccionar as Seleccionar 
from liquidacionesporromaneaje LR right join CalculoClasificacion CC
on LR.IdOrdenTrabajo = CC.IdOrdenTrabajo
where cc.FlagTerminado = 1 and cc.IdVentaEnc = @IdVenta
		group by LR.IdLiquidacion, cc.IdOrdenTrabajo,lr.TotalHueso, lr.TotalSemilla
		having   count(case when cc.EstatusVenta = 2 then cc.BaleID end) > 0
go
alter procedure sp_InsertarContratoVenta
@IdContratoAlgodon int output, 
@IdComprador int,
@Pacas int,
@PacasVendidas int,
@PacasDisponibles int,
@PrecioQuintal float,
@IdUnidadPeso int,
@ValorConversion float,
@Puntos float,
@FechaLiquidacion datetime,
@Presidente varchar(100),
@IdModalidadVenta int,
@Temporada varchar(20),
@PrecioSM float,
@PrecioMP float,
@PrecioM float,
@PrecioSLMP float,
@PrecioSLM float,
@PrecioLMP float,
@PrecioLM float,
@PrecioSGO float,
@PrecioGO float,
@PrecioO float,
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion datetime
as
begin
set nocount on
merge [dbo].[ContratoVenta] as target
using (select @IdContratoAlgodon
			 ,@IdComprador
			 ,@Pacas
			 ,@PacasVendidas
			 ,@PacasDisponibles 
			 ,@PrecioQuintal
			 ,@IdUnidadPeso 
			 ,@ValorConversion 
			 ,@Puntos
			 ,@FechaLiquidacion
			 ,@Presidente
			 ,@IdModalidadVenta
			 ,@Temporada
			 ,@PrecioSM
			 ,@PrecioMP
			 ,@PrecioM
			 ,@PrecioSLMP
			 ,@PrecioSLM
			 ,@PrecioLMP
			 ,@PrecioLM
			 ,@PrecioSGO
			 ,@PrecioGO
			 ,@PrecioO
			 ,@IdEstatus
			 ,@IdUsuarioCreacion
			 ,@FechaCreacion
			 ,@IdUsuarioActualizacion
			 ,@FechaActualizacion) as source 
			 (IdContratoAlgodon
			 ,IdComprador
			 ,Pacas
			 ,PacasVendidas
			 ,PacasDisponibles 
			 ,PrecioQuintal
			 ,IdUnidadPeso 
			 ,ValorConversion 
			 ,Puntos
			 ,FechaLiquidacion
			 ,Presidente
			 ,IdModalidadVenta
			 ,Temporada
			 ,PrecioSM
			 ,PrecioMP
			 ,PrecioM
			 ,PrecioSLMP
			 ,PrecioSLM
			 ,PrecioLMP
			 ,PrecioLM
			 ,PrecioSGO
			 ,PrecioGO
			 ,PrecioO
			 ,IdEstatus
			 ,IdUsuarioCreacion
			 ,FechaCreacion
			 ,IdUsuarioActualizacion
			 ,FechaActualizacion)
ON (target.IdContratoAlgodon = source.IdContratoAlgodon)
WHEN MATCHED THEN
UPDATE SET 
IdComprador = source.IdComprador,
Pacas = source.Pacas,
PacasVendidas = source.PacasVendidas,
PacasDisponibles  = source.PacasDisponibles,
PrecioQuintal = source.PrecioQuintal,
IdUnidadPeso  = source.IdUnidadPeso,
ValorConversion  = source.ValorConversion,
Puntos = source.Puntos,
FechaLiquidacion = source.FechaLiquidacion,
Presidente = source.Presidente,
IdModalidadVenta = source.IdModalidadVenta,
Temporada = source.Temporada,
PrecioSM = source.PrecioSM,
PrecioMP = source.PrecioMP,
PrecioM = source.PrecioM,
PrecioSLMP = source.PrecioSLMP,
PrecioSLM = source.PrecioSLM,
PrecioLMP = source.PrecioLMP,
PrecioLM = source.PrecioLM,
PrecioSGO = source.PrecioSGO,
PrecioGO = source.PrecioGO,
PrecioO = source.PrecioO,
IdEstatus = source.IdEstatus,
IdUsuarioActualizacion = source.IdUsuarioActualizacion,
FechaActualizacion = source.FechaActualizacion
WHEN NOT MATCHED THEN
INSERT (IdComprador
	   ,Pacas
	   ,PacasVendidas
	   ,PacasDisponibles 
	   ,PrecioQuintal
	   ,IdUnidadPeso 
	   ,ValorConversion 
	   ,Puntos
	   ,FechaLiquidacion
	   ,Presidente
	   ,IdModalidadVenta
	   ,Temporada
	   ,PrecioSM
	   ,PrecioMP
	   ,PrecioM
	   ,PrecioSLMP
	   ,PrecioSLM
	   ,PrecioLMP
	   ,PrecioLM
	   ,PrecioSGO
	   ,PrecioGO
	   ,PrecioO
	   ,IdEstatus
	   ,IdUsuarioCreacion
	   ,FechaCreacion
	   ,IdUsuarioActualizacion
	   ,FechaActualizacion)
VALUES (source.IdComprador
	   ,source.Pacas
	   ,source.PacasVendidas
	   ,source.PacasDisponibles 
	   ,source.PrecioQuintal
	   ,source.IdUnidadPeso 
	   ,source.ValorConversion 
	   ,source.Puntos
	   ,source.FechaLiquidacion
	   ,source.Presidente
	   ,source.IdModalidadVenta
	   ,source.Temporada
	   ,source.PrecioSM
	   ,source.PrecioMP
	   ,source.PrecioM
	   ,source.PrecioSLMP
	   ,source.PrecioSLM
	   ,source.PrecioLMP
	   ,source.PrecioLM
	   ,source.PrecioSGO
	   ,source.PrecioGO
	   ,source.PrecioO
	   ,source.IdEstatus
	   ,source.IdUsuarioCreacion
	   ,source.FechaCreacion
	   ,source.IdUsuarioActualizacion
	   ,source.FechaActualizacion);
SET @IdContratoAlgodon = SCOPE_IDENTITY()
END
RETURN @IdContratoAlgodon
go
alter procedure sp_ConsultaContratosVentaDetalle
--declare
@IdContratoAlgodon int
as
select a.IdContratoAlgodon,
	   b.IdComprador,
       b.Nombre,	   
	   a.Pacas,	 
	   a.PacasVendidas,
	   a.PacasDisponibles,
	   a.PrecioQuintal,
	   a.IdUnidadPeso,
	   a.ValorConversion,
	   a.Puntos,
	   a.FechaLiquidacion,
	   a.Presidente,
	   a.IdModalidadVenta,
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
from   [dbo].[ContratoVenta] a,
       [dbo].[Compradores] b
where  a.IdComprador = b.IdComprador and a.IdContratoAlgodon = @IdContratoAlgodon
and    a.IdEstatus = 1
go
alter procedure sp_ConPacVentDet
--declare
@Seleccionar bit = 0 
as
select pd.FolioCIA,
	   cc.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   cc.BaleID,
	   pd.Kilos,
	   cc.Grade,
	   isnull(cc.quintales,0) as quintales,
	   isnull(cc.PrecioClase,0) as PrecioClase,
	   isnull(cc.PrecioDls,0) as PrecioDls,
	   isnull(cc.TipoCambio,0) as TipoCambio,
	   isnull(cc.PrecioMxn,0) as PrecioMxn,
	   cc.UI as Uniformidad,
	   cc.Mic as Micros,
	   cc.Strength as Resistencia,
	   cc.UHML as Largo,
	   isnull(cc.CastigoBarkLevel1Venta,0) as CastigoBarkLevel1Venta, 
       isnull(cc.CastigoBarkLevel2Venta,0) as CastigoBarkLevel2Venta,
       isnull(cc.CastigoPrepLevel1Venta,0) as CastigoPrepLevel1Venta,
       isnull(cc.CastigoPrepLevel2Venta,0) as CastigoPrepLevel2Venta,
       isnull(cc.CastigoOtherLevel1Venta,0) as CastigoOtherLevel1Venta,
       isnull(cc.CastigoOtherLevel2Venta,0) as CastigoOtherLevel2Venta,
       isnull(cc.CastigoPlasticLevel1Venta,0) as CastigoPlasticLevel1Venta,
       isnull(cc.CastigoPlasticLevel2Venta,0) as CastigoPlasticLevel2Venta,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join CalculoClasificacion cc 
		on pd.FolioCIA = cc.BaleID left join liquidacionesporromaneaje LR 
		on cc.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
		where cc.FlagTerminado =1 and cc.EstatusVenta  = 1 and lr.IdLiquidacion is not null
		order by cc.IdOrdenTrabajo, cc.BaleID
go
Alter Procedure Sp_ReporteVentaPacaDetalle
@IdVenta int
as 
Select Comp.IdComprador
		,Comp.Nombre
		,VePa.IdVenta
		,CaCl.IdPlantaOrigen
		,CaCl.baleid
		,CaCl.Quintales
		,CaCl.kilos
		,CaCl.grade
		,CaCl.Mic
		,CaCl.Strength
		,CaCl.UHML 
		,CaCl.UI
		,UnVe.Descripcion
	    ,CoVe.ValorConversion
from CalculoClasificacion CaCl inner join VentaPacas VePa on CaCl.IdVentaEnc = VePa.IdVenta
							   inner join ContratoVenta CoVe on VePa.IdContratoAlgodon = CoVe.IdContratoAlgodon and VePa.IdComprador = CoVe.IdComprador
							   inner join Compradores Comp on CoVe.IdComprador = Comp.IdComprador
							   inner join ClasesClasificacion ClCl on CaCl.Grade = ClCl.ClaveCorta
							   inner join UnidadPesoVenta UnVe on CoVe.IdUnidadPeso = UnVe.IdUnidadPeso
where VePa.IdVenta = @IdVenta
Order By CaCl.BaleID asc
go
Alter Procedure Sp_ReporteVentaResumen
@IdVenta int 
as 
Select VePa.IdVenta
	  ,Comp.Nombre
	  ,Cacl.Grade
	  ,count(Cacl.BaleID) as Cantidad
	  ,sum(Cacl.Kilos) as Kilos
	  ,Sum(Cacl.Quintales) as Quintales
	  ,Cacl.PrecioClase
	  ,isnull(sum(Cacl.PrecioDls),0) as PrecioDls
	  ,isnull(sum(Cacl.CastigoUIVenta),0) as CastigoUIVenta 
	  ,isnull(sum(Cacl.castigoMicVenta),0) as castigoMicVenta
	  ,isnull(sum(Cacl.CastigoResistenciaFibraVenta),0) as CastigoResistenciaFibraVenta
	  ,isnull(sum(Cacl.CastigoLargoFibraVenta),0) as CastigoLargoFibraVenta
      ,isnull(sum(Cacl.CastigoBarkLevel1Venta),0) as CastigoBarkLevel1Venta
      ,isnull(sum(Cacl.CastigoBarkLevel2Venta),0) as CastigoBarkLevel2Venta
      ,isnull(sum(Cacl.CastigoPrepLevel1Venta),0) as CastigoPrepLevel1Venta
      ,isnull(sum(Cacl.CastigoPrepLevel2Venta),0) as CastigoPrepLevel2Venta
      ,isnull(sum(Cacl.CastigoOtherLevel1Venta),0) as CastigoOtherLevel1Venta
      ,isnull(sum(Cacl.CastigoOtherLevel2Venta),0) as CastigoOtherLevel2Venta
      ,isnull(sum(Cacl.CastigoPlasticLevel1Venta),0) as CastigoPlasticLevel1Venta
      ,isnull(sum(Cacl.CastigoPlasticLevel2Venta),0) as CastigoPlasticLevel2Venta
	  ,CoVe.PrecioQuintal
	  ,CoVe.IdUnidadPeso
	  ,UnVe.Descripcion
	  ,CoVe.ValorConversion
	  ,CoVe.Puntos
	  ,CoVe.PrecioSM
	  ,CoVe.PrecioMP
	  ,CoVe.PrecioM
	  ,CoVe.PrecioSLMP
	  ,CoVe.PrecioLMP
	  ,CoVe.PrecioLM
	  ,CoVe.PrecioSGO
	  ,CoVe.PrecioGO
	  ,CoVe.PrecioO
	  ,VePa.Fecha
	  ,ClCl.IdClasificacion
from CalculoClasificacion CaCl inner join VentaPacas VePa on CaCl.IdVentaEnc = VePa.IdVenta
							   inner join ContratoVenta CoVe on VePa.IdContratoAlgodon = CoVe.IdContratoAlgodon and VePa.IdComprador = CoVe.IdComprador
							   inner join Compradores Comp on CoVe.IdComprador = Comp.IdComprador
							   inner join ClasesClasificacion ClCl on CaCl.Grade = ClCl.ClaveCorta
							   inner join UnidadPesoVenta UnVe on CoVe.IdUnidadPeso = UnVe.IdUnidadPeso
where VePa.IdVenta = @IdVenta
Group by VePa.IdVenta
		,Comp.Nombre
		,CaCl.Grade
		,CaCl.PrecioClase
		,CoVe.PrecioQuintal
		,CoVe.IdUnidadPeso
		,UnVe.Descripcion
		,CoVe.ValorConversion
		,CoVe.Puntos
		,CoVe.PrecioSM
		,CoVe.PrecioMP
		,CoVe.PrecioM
		,CoVe.PrecioSLMP
		,CoVe.PrecioSLM
		,CoVe.PrecioLMP
		,CoVe.PrecioLM
		,CoVe.PrecioSGO
		,CoVe.PrecioGO
		,CoVe.PrecioO
		,VePa.Fecha
		,ClCl.IdClasificacion
order by ClCl.IdClasificacion			
go
Alter Procedure Sp_ConsultaPaqueteHviEncabezado
@LotID int
as
select LotID
	  ,CantidadPacas
	  ,IdPlanta 
from HVIEncabezado
where LotID = @LotID		
go
Alter Procedure Sp_ConsultaPacaMatExtDet
@LotID int,
@BaleID int
as
select isnull(Pmat.IdPaquete,0) as IdPaquete
	  ,Hvid.IdOrdenTrabajo
	  ,Hvid.LotId
	  ,Hvid.BaleId
	  ,isnull(Pmat.BarkLevel1,0) as BarkLevel1
	  ,isnull(Hvid.CastigoBarkLevel1Compra,0) as CastigoBarkLevel1Compra
	  ,isnull(Pmat.PrepLevel1,0) as PrepLevel1
	  ,isnull(Hvid.CastigoPrepLevel1Compra,0) as CastigoPrepLevel1Compra
	  ,isnull(Pmat.OtherLevel1,0) as OtherLevel1
	  ,isnull(Hvid.CastigoOtherLevel1Compra,0) as CastigoOtherLevel1Compra
	  ,isnull(Pmat.PlasticLevel1,0) as PlasticLevel1
	  ,isnull(Hvid.CastigoPlasticLevel1Compra,0) as CastigoPlasticLevel1Compra
	  ,isnull(Pmat.BarkLevel2,0) as BarkLevel2
	  ,isnull(Hvid.CastigoBarkLevel2Compra,0) as CastigoBarkLevel2Compra
	  ,isnull(Pmat.PrepLevel2,0) as PrepLevel2
	  ,isnull(Hvid.CastigoPrepLevel2Compra,0) as CastigoPrepLevel2Compra
	  ,isnull(Pmat.OtherLevel2,0) as OtherLevel2
	  ,isnull(Hvid.CastigoOtherLevel2Compra,0) as CastigoOtherLevel2Compra
	  ,isnull(Pmat.PlasticLevel2,0) as PlasticLevel2
	  ,isnull(Hvid.CastigoPlasticLevel2Compra,0) as CastigoPlasticLevel2Compra
from PaqueteMatExt Pmat right join HviDetalle Hvid on Pmat.LotId = Hvid.LotID and Pmat.IdOrdenTrabajo = Hvid.IdOrdenTrabajo and Pmat.BaleId = Hvid.BaleID
where Hvid.LotID = @LotID and Hvid.BaleID = @BaleID
go
alter Procedure Sp_ActualizaIdOrdenTrabajoPaqueteHVI
@IdPlanta int,
@BaleId int
as
update hvi
set hvi.IdOrdenTrabajo = pd.IdOrdenTrabajo,
	hvi.Kilos = pd.kilos,
	hvi.Quintales = round((pd.kilos /46.02),4,0),
	hvi.Grade = cc.clavecorta,
	FlagTerminado = 1
from hvidetalle hvi inner join producciondetalle pd on hvi.idplantaorigen = pd.IdPlantaOrigen and hvi.BaleID = pd.FolioCIA
					left join GradosClasificacion Gc on hvi.ColorGrade = Gc.GradoColor and hvi.TrashID = Gc.TrashId
					left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
where hvi.IdPlantaOrigen = @IdPlanta and hvi.Baleid = @BaleId
go
Alter procedure sp_InsertarPaquetesHVIDet
@IdHviDet int,
@IdHviEnc int,
@IdPlantaOrigen int,
@LotID int,
@BaleID int,
@BaleGroup varchar(5),
@Operator varchar(25),
@Date datetime,
@Temperature float,
@Humidity float,
@Amount int, 
@UHML float,
@UI float,
@Strength float,
@Elongation float,
@SFI float,
@Maturity float,
@Grade varchar(6),
@Moist float,
@Mic float,
@Rd float,
@Plusb float,
@ColorGrade varchar(4),
@TrashCount int,
@TrashArea float,
@TrashID int,
@SCI int,
@Nep int,
@UV float
as 
begin 
set nocount on
merge [dbo].[HVIDetalle] as target
using (select @IdHviDet
			 ,@IdHviEnc
			 ,@IdPlantaOrigen
			 ,@LotID
			 ,@BaleID
			 ,@BaleGroup
			 ,@Operator
			 ,@Date
			 ,@Temperature
			 ,@Humidity
			 ,@Amount
			 ,@UHML
			 ,@UI
			 ,@Strength
			 ,@Elongation
			 ,@SFI
			 ,@Maturity
			 ,@Grade
			 ,@Moist
			 ,@Mic
			 ,@Rd
			 ,@Plusb
			 ,@ColorGrade
			 ,@TrashCount
			 ,@TrashArea
			 ,@TrashID
			 ,@SCI
			 ,@Nep
			 ,@UV) 
			 AS SOURCE (
			 IdHviDet
			,IdHviEnc
			,IdPlantaOrigen
			,LotID
			,BaleID
			,BaleGroup
			,Operator
			,[Date]
			,Temperature
			,Humidity
			,Amount
			,UHML
			,UI
			,Strength
			,Elongation
			,SFI
			,Maturity
			,Grade
			,Moist
			,Mic
			,Rd
			,Plusb
			,ColorGrade
			,TrashCount
			,TrashArea
			,TrashID
			,SCI
			,Nep
			,UV)
ON ((target.LotID = source.LotID and
	 target.BaleID = source.BaleID and
	 target.IdPlantaOrigen <> source.IdPlantaOrigen and 
	 target.[Date] <> source.[Date]) or 

	(target.LotID = source.LotID and
	 target.BaleID = source.BaleID and
	 target.IdPlantaOrigen = source.IdPlantaOrigen and 
	 target.[Date] <> source.[Date]) or

	 (target.LotID = source.LotID and
	 target.BaleID = source.BaleID and
	 target.IdPlantaOrigen <> source.IdPlantaOrigen and 
	 target.[Date] <> source.[Date]) or 

	 (target.LotID = source.LotID and
	 target.BaleID = source.BaleID and
	 target.IdPlantaOrigen = source.IdPlantaOrigen and 
	 target.[Date] = source.[Date]))
WHEN MATCHED THEN
UPDATE SET 
		   IdPlantaOrigen = source.IdPlantaOrigen,
		   LotID = source.LotID,
		   BaleID = source.BaleID,
		   BaleGroup = source.BaleGroup,
		   Operator = source.Operator,
		   [Date] = source.[Date],
		   Temperature = source.Temperature,
		   Humidity = source.Humidity,
		   Amount = source.Amount,
		   UHML = source.UHML,
		   UI = source.UI,
		   Strength = source.Strength,
		   Elongation = source.Elongation,
		   SFI = source.SFI,
		   Maturity = source.Maturity,
		   Grade = source.Grade,
		   Moist = source.Moist,
		   Mic = source.Mic,
		   Rd = source.Rd,
		   Plusb = source.Plusb,
		   ColorGrade = source.ColorGrade,
		   TrashCount = source.TrashCount,
		   TrashArea = source.TrashArea,
		   TrashID = source.TrashID,
		   SCI = source.SCI,
		   Nep = source.Nep,
		   UV = source.UV
WHEN NOT MATCHED THEN
INSERT (IdHviEnc
	   ,IdPlantaOrigen
	   ,LotID
	   ,BaleID
	   ,BaleGroup
	   ,Operator
	   ,[Date]
	   ,Temperature
	   ,Humidity
	   ,Amount
	   ,UHML
	   ,UI
	   ,Strength
	   ,Elongation
	   ,SFI
	   ,Maturity
	   ,Grade
	   ,Moist
	   ,Mic
	   ,Rd
	   ,Plusb
	   ,ColorGrade
	   ,TrashCount
	   ,TrashArea
	   ,TrashID
	   ,SCI
	   ,Nep
	   ,UV
	   ,EstatusCompra)
        VALUES (
		source.IdHviEnc
	   ,source.IdPlantaOrigen
	   ,source.LotID
	   ,source.BaleID
	   ,source.BaleGroup
	   ,source.Operator
	   ,source.[Date]
	   ,source.Temperature
	   ,source.Humidity
	   ,source.Amount
	   ,source.UHML
	   ,source.UI
	   ,source.Strength
	   ,source.Elongation
	   ,source.SFI
	   ,source.Maturity
	   ,source.Grade
	   ,source.Moist
	   ,source.Mic
	   ,source.Rd
	   ,source.Plusb
	   ,source.ColorGrade
	   ,source.TrashCount
	   ,source.TrashArea
	   ,source.TrashID
	   ,source.SCI
	   ,source.Nep
	   ,source.UV
	   ,1);		
END
go
Alter Procedure Sp_InsertaPacaMatExt
 @IdPaquete int
,@IdOrdenTrabajo int
,@LotID int
,@BaleID int
,@BarkLevel1 float
,@PrepLevel1 float
,@OtherLevel1 float
,@PlasticLevel1 float
,@BarkLevel2 float
,@PrepLevel2 float
,@OtherLevel2 float
,@PlasticLevel2 float
as
begin 
set nocount on 
merge [dbo].[PaqueteMatExt] as target
using (select @IdOrdenTrabajo
			 ,@LotID
			 ,@BaleID
			 ,@BarkLevel1
			 ,@PrepLevel1
			 ,@OtherLevel1
			 ,@PlasticLevel1
			 ,@BarkLevel2
			 ,@PrepLevel2
			 ,@OtherLevel2
			 ,@PlasticLevel2)
			 AS SOURCE (
			  IdOrdenTrabajo
			 ,LotID
			 ,BaleID
			 ,BarkLevel1
			 ,PrepLevel1
			 ,OtherLevel1
			 ,PlasticLevel1
			 ,BarkLevel2
			 ,PrepLevel2
			 ,OtherLevel2
			 ,PlasticLevel2)
ON (Target.LotID = source.LotID and
	Target.BaleID = source.BaleID)
WHEN MATCHED THEN
UPDATE SET	
			BarkLevel1 = source.BarkLevel1
		   ,PrepLevel1 = source.PrepLevel1
		   ,OtherLevel1 = source.OtherLevel1
		   ,PlasticLevel1 = source.PlasticLevel1
		   ,BarkLevel2 = source.BarkLevel2
		   ,PrepLevel2 = source.PrepLevel2
		   ,OtherLevel2 = source.OtherLevel2
		   ,PlasticLevel2 = source.PlasticLevel2
WHEN NOT MATCHED THEN
INSERT (  IdOrdenTrabajo
			 ,LotID
			 ,BaleID
			 ,BarkLevel1
			 ,PrepLevel1
			 ,OtherLevel1
			 ,PlasticLevel1
			 ,BarkLevel2
			 ,PrepLevel2
			 ,OtherLevel2
			 ,PlasticLevel2)
			 VALUES (
			  source.IdOrdenTrabajo
			 ,source.LotID
			 ,source.BaleID
			 ,source.BarkLevel1
			 ,source.PrepLevel1
			 ,source.OtherLevel1
			 ,source.PlasticLevel1
			 ,source.BarkLevel2
			 ,source.PrepLevel2
			 ,source.OtherLevel2
			 ,source.PlasticLevel2);
END
go
Alter Procedure Sp_ReporteVentaHVI
--declare
@IdVenta int 
as
select   b.IdPaquete
        ,b.IdPlanta
	    ,isnull(b.IdComprador,0) as IdComprador
		,isnull(d.Nombre,'') as Nombre
	    ,b.Descripcion
	    ,b.CantidadPacas
		,a.[BaleID]
		,a.[BaleGroup]
		,a.[Operator]
		,a.[Date]
		,a.[Temperature]
		,a.[Humidity]
		,a.[Amount]
		,a.[UHML]
		,a.[UI]
		,a.[Strength]
		,a.[Elongation]
		,a.[SFI]
		,a.[Maturity]
		,a.[Grade]
		,a.[Moist]
		,a.[Mic]
		,a.[Rd]
		,a.[Plusb]
		,a.[ColorGrade]
		,a.[TrashCount]
		,a.[TrashArea]
		,a.[TrashID]
		,a.[SCI]
		,a.[Nep]
		,a.[UV]
		,a.IdOrdenTrabajo
		,a.Kilos
		,a.FlagTerminado
		,(select top 1 subcon.colorgrade from (Select colorgrade,count(colorgrade) as ConteoCGR
		  From CalculoClasificacion 
		  where IdVentaEnc = @IdVenta
		  Group By colorgrade) SubCon
		  order by conteoCGR desc) as TrCntRep
		,(Select top 1 TrashID From CalculoClasificacion where IdVentaEnc = @IdVenta  Group By TrashID Having Count(*) > 1) as TrIDRep
		, a.IdVentaEnc AS IdVenta
from CalculoClasificacion a inner join PaqueteEncabezado b 
						 on a.IdPaqueteEncabezado = b.IdPaquete and a.IdPlantaOrigen = b.IdPlanta
						 inner join ClasesClasificacion c 
						 on b.IdClase = c.idClasificacion
							left join Compradores d 
						 on b.idComprador = d.IdComprador
where a.IdVentaEnc = @IdVenta
order by a.[BaleID]
go
Alter Procedure Sp_ConsultaPacaMatExt
--declare
@LotID int 
as
select isnull(Pmat.IdPaquete,0) as IdPaquete
	  ,Hvid.IdOrdenTrabajo
	  ,Hvid.LotId
	  ,Hvid.BaleId
	  ,isnull(Pmat.BarkLevel1,0) as BarkLevel1
	  ,isnull(Hvid.CastigoBarkLevel1Compra,0) as CastigoBarkLevel1Compra
	  ,isnull(Pmat.PrepLevel1,0) as PrepLevel1
	  ,isnull(Hvid.CastigoPrepLevel1Compra,0) as CastigoPrepLevel1Compra
	  ,isnull(Pmat.OtherLevel1,0) as OtherLevel1
	  ,isnull(Hvid.CastigoOtherLevel1Compra,0) as CastigoOtherLevel1Compra
	  ,isnull(Pmat.PlasticLevel1,0) as PlasticLevel1
	  ,isnull(Hvid.CastigoPlasticLevel1Compra,0) as CastigoPlasticLevel1Compra
	  ,isnull(Pmat.BarkLevel2,0) as BarkLevel2
	  ,isnull(Hvid.CastigoBarkLevel2Compra,0) as CastigoBarkLevel2Compra
	  ,isnull(Pmat.PrepLevel2,0) as PrepLevel2
	  ,isnull(Hvid.CastigoPrepLevel2Compra,0) as CastigoPrepLevel2Compra
	  ,isnull(Pmat.OtherLevel2,0) as OtherLevel2
	  ,isnull(Hvid.CastigoOtherLevel2Compra,0) as CastigoOtherLevel2Compra
	  ,isnull(Pmat.PlasticLevel2,0) as PlasticLevel2
	  ,isnull(Hvid.CastigoPlasticLevel2Compra,0) as CastigoPlasticLevel2Compra
from PaqueteMatExt Pmat inner join HviDetalle Hvid on Pmat.LotId = Hvid.LotID and Pmat.IdOrdenTrabajo = Hvid.IdOrdenTrabajo and Pmat.BaleId = Hvid.BaleID
where Hvid.LotID = @LotID
go
alter procedure sp_ConsultaContratosDetalle
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
	   a.IdEstatus
from [dbo].[ContratoCompra] a inner join  [dbo].[Clientes] b on a.IdProductor = b.IdCliente
							  left join  [dbo].[Asociaciones] c on b.IdCuentaDe = c.IdAsociacion
	
where a.IdContratoAlgodon = @IdContratoAlgodon
and   a.IdEstatus = 1
