Create Procedure Sp_ReporteRomaneajeDet
@IdOrdenTrabajo as int
as
select pd.IdOrdenTrabajo
	  ,pd.IdPlantaOrigen
	  ,pd.FolioCIA as EtiquetaPaca
	  ,pd.kilos 
	  ,cc.Temperature
	  ,cc.Humidity
	  ,cc.Amount
	  ,cc.UHML
	  ,cc.UI
	  ,cc.Strength
	  ,cc.Elongation
	  ,cc.SFI
	  ,cc.Maturity
	  ,cc.Grade
	  ,cc.Moist
	  ,cc.Mic
	  ,cc.Rd
	  ,cc.Plusb
	  ,cc.ColorGrade
	  ,cc.TrashCount
	  ,cc.TrashArea
	  ,cc.TrashID
	  ,cc.SCI
	  ,cc.Nep
	  ,cc.UV
from  ProduccionDetalle pd inner join CalculoClasificacion cc on pd.IdOrdenTrabajo = cc.IdOrdenTrabajo and pd.FolioCIA = cc.BaleID
where pd.IdOrdenTrabajo = @IdOrdenTrabajo