CREATE procedure pa_consultaromaneajecompradet
@idcompra int,
@CheckStatus bit 
as
select idordentrabajo
	  ,idplantaorigen
	  ,BaleID
	  ,Kilos
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
	  ,@CheckStatus as CheckStatus
from hvidetalle
where IdCompraEnc = @idcompra