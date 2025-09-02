alter Procedure Sp_ConsultaLargosFibraEncabezado
as
select IdModoEncabezado,
	   Descripcion,
	   case 
			when ModoComercializacion = 1 then 'COMPRAS' 
			WHEN ModoComercializacion = 2 then 'VENTAS'
	   END AS TipoComercializacion,
	   ModoComercializacion,
	   IdEstatus,
	   case 
			when idestatus = 1 then 'Activo'
			when IdEstatus = 0 then 'Inactivo'
			end as Estatus
from LargosFibraEncabezado