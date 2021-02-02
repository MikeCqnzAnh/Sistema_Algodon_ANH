alter procedure sp_ReporteVentapaqueteExcel
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
	  ,cast(Kilos as numeric(32,2)) as Kilos
from CalculoClasificacion
where IdVentaEnc = @idventa 
order by idpaqueteencabezado, BaleID