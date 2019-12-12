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
