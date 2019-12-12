create proc sp_LlenarComboClientes
as
select IdCliente
	  ,Nombre
	  ,IdTipoPersona 
from   Clientes 
order by Nombre