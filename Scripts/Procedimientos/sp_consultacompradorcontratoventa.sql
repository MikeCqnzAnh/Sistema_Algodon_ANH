CREATE Procedure Sp_ConsultaCompradorContratoVenta
@Nombre varchar(100)
as
select IdComprador,Nombre 
from Compradores 
where IdComprador in (select IdComprador from ContratoVenta) and nombre like '%'+@Nombre+'%'
order by Nombre