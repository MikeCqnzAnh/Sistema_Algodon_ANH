create procedure sp_InsertarClasificacionPacas
@IdCalculoClasificacion int,
@IdPaqueteEncabezado int,
@IdOrdenTrabajo int,
@IdPlantaOrigen int,
@Kilos decimal(10,2),
@LotID int,
@BaleID bigint ,
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
				FlagTerminado = 1 
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
