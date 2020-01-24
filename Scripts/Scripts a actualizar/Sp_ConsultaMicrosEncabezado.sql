Create Procedure Sp_ConsultaMicrosEncabezado
as
select IdModoEncabezado,
	   Descripcion,
	   ModoComercializacion,
	   IdEstatus
from MicrosEncabezado