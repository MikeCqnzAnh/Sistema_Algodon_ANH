create procedure sp_ConsultaLargoFibra
as 
select IdLargoFibra
	  ,Rango1	
	  ,Rango2
	  ,Colorgrade
	  ,Castigo
from largosDeFibra
where idestatus = 1