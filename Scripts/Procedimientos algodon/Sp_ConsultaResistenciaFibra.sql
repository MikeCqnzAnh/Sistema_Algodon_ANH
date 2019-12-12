create proc Sp_ConsultaResistenciaFibra
as
select idresistenciafibra,
	   Rango1,
	   Rango2,
	   Castigo
from resistenciafibra
where idestatus = 1