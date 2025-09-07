create procedure pa_reporteproductor
@idproductor int
as
select IdCliente as idproductor,
	    Nombre 
from Clientes
where IdCliente = @idproductor