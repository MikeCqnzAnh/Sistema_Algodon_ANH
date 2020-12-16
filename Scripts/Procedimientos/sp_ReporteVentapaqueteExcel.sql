create procedure sp_ReporteVentapaqueteExcel
@idventa int
as
select BaleID
	  ,Grade+'-'+cast(IdPaqueteEncabezado as varchar) as LotID
	  ,SCI
	  ,Moist
	  ,Mic
	  ,Maturity
	  ,UHML
	  ,UI
	  ,SFI
	  ,Strength
	  ,Elongation
	  ,Rd
	  ,Plusb
	  ,ColorGrade
	  ,TrashCount
	  ,TrashArea
	  ,TrashID
	  ,Amount
	  ,Kilos 
from CalculoClasificacion
where IdVentaEnc = @idventa 
order by idpaqueteencabezado, BaleID