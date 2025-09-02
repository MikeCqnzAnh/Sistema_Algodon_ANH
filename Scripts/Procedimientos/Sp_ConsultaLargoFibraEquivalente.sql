Create Procedure Sp_ConsultaLargoFibraEquivalente
@IdLargoFibraEncabezado int
as
select IdLargoFibraDetalle,
	   IdModoEncabezado,
	   ModoComercializacion,
	   Rango1,
	   Rango2,
	   LenghtNDS
from LargosFibraEquivalenteDetalle
where IdModoEncabezado = @IdLargoFibraEncabezado