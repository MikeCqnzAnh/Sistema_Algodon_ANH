Alter Procedure Sp_ConsultaProductorContratoCompra
@Nombre varchar(100)
as
select IdCliente as IdProductor,Nombre 
from Clientes 
where IdCliente in (select idproductor from ContratoCompra) and nombre like '%'+@Nombre+'%'
order by Nombre