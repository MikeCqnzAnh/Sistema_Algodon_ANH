create procedure sp_InsertarPaquetesHVIDet
@IdHviDet int,
@IdHviEnc int,
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
@Grade float,
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
using (select @IdHviDet,@IdHviEnc,@LotID,@BaleID,@BaleGroup,@Operator,@Date,@Temperature,@Humidity,@Amount,@UHML,@UI,@Strength,@Elongation,@SFI,@Maturity,@Grade,@Moist,@Mic,@Rd,@Plusb,@ColorGrade,@TrashCount,@TrashArea,@TrashID,@SCI,@Nep,@UV) AS SOURCE (IdHviDet,IdHviEnc,LotID,BaleID,BaleGroup,Operator,[Date],Temperature,Humidity,Amount,UHML,UI,Strength,Elongation,SFI,Maturity,Grade,Moist,Mic,Rd,Plusb,ColorGrade,TrashCount,TrashArea,TrashID,SCI,Nep,UV)
ON (target.IdHviDet = SOURCE.IdHviDet)
WHEN MATCHED THEN
UPDATE SET 
		   IdHviEnc = source.IdHviEnc
WHEN NOT MATCHED THEN
INSERT (IdHviEnc,LotID,BaleID,BaleGroup,Operator,[Date],Temperature,Humidity,Amount,UHML,UI,Strength,Elongation,SFI,Maturity,Grade,Moist,Mic,Rd,Plusb,ColorGrade,TrashCount,TrashArea,TrashID,SCI,Nep,UV)
        VALUES (source.IdHviEnc,source.LotID,source.BaleID,source.BaleGroup,source.Operator,source.[Date],source.Temperature,source.Humidity,source.Amount,source.UHML,source.UI,source.Strength,source.Elongation,source.SFI,source.Maturity,source.Grade,source.Moist,source.Mic,source.Rd,source.Plusb,source.ColorGrade,source.TrashCount,source.TrashArea,source.TrashID,source.SCI,source.Nep,source.UV);		
END