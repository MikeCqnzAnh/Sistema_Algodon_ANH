create procedure sp_ConsultaPaquetesHVIDet
--declare
@IdPaquete int
as
select a.IdHviEnc,
	   a.IdPlanta,
	   a.LotID,
       a.BaleID,
	   a.BaleGroup,
	   a.Operator,
	   a.[Date],
	   a.Temperature,
	   a.Humidity,
	   a.Amount,
	   a.UHML,
	   a.UI,
	   a.Strength,
	   a.Elongation,
	   a.SFI,
	   a.Maturity,
	   a.Grade,
	   a.Moist,
	   a.Mic,
	   a.Rd,
	   a.Plusb,
	   a.ColorGrade,
	   a.TrashCount,
	   a.TrashArea,
	   a.TrashID,
	   a.SCI,
	   a.Nep,
	   a.UV
from dbo.HVIDetalle a
where a.LotID = @IdPaquete 