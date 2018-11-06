Create procedure sp_ConsultaBasicaClientes
--declare
@IdTipoPersona int --= 3
AS
IF @IdTipoPersona = 3
select
      a.IdCliente,
	  a.Nombre,
	  b.Descripcion as TipoPersona
from dbo.Clientes a,
     dbo.TipoPersona b
where a.IdEstatus = 1
and   a.IdTipoPersona = b.IdTipoPersona
ELSE
 select
      a.IdCliente,
	  a.Nombre,
	  b.Descripcion as TipoPersona
from dbo.Clientes a,
     dbo.TipoPersona b
where a.IdEstatus = 1
and   a.IdTipoPersona = b.IdTipoPersona
and   a.IdTipoPersona = @IdTipoPersona