alter Procedure Sp_ConsultaMicrosEncabezado
as
select IdModoEncabezado,
	   Descripcion,
	   case 
			when ModoComercializacion = 1 then 'COMPRAS' 
			WHEN ModoComercializacion = 2 then 'VENTAS'
	   END AS TipoComercializacion,
	   ModoComercializacion,
	   IdEstatus
from MicrosEncabezado