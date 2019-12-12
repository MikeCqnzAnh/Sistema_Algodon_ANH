Create Procedure Sp_ConsultaProductorContratoCompra
as
select IdCliente as IdProductor,Nombre 
from Clientes 
where IdCliente in (select idproductor from ContratoCompra)