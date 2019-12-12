CREATE procedure sp_RepClientes
as
select a.IdCliente as ID,
       a.Nombre as Cliente,
	   c.Descripcion as TipoPersona
from [dbo].[Clientes] a,
   	 [dbo].[TipoPersona] c
where a.IdEstatus = 1
and   a.IdTipoPersona = c.IdTipoPersona
