create procedure sp_ConsultaBasicaClientes
@IdCliente int,
@nombre varchar(100)
as
if @nombre <> '' and @IdCliente = 0
begin
Select cl.idCliente,
	   cl.Nombre,
	   tp.Descripcion as TipoPersona	   
from clientes cl inner join TipoPersona tp
on cl.IdTipoPersona = tp.IdTipoPersona
where Nombre like '%'+@Nombre+'%'
end
else if @IdCliente > 0 and @nombre = ''
begin
Select cl.idCliente,
	   cl.Nombre,
	   tp.Descripcion as TipoPersona	   
from clientes cl inner join TipoPersona tp
on cl.IdTipoPersona = tp.IdTipoPersona
where IdCliente = @IdCliente
end
else
begin
Select cl.idCliente,
	   cl.Nombre,
	   tp.Descripcion as TipoPersona	   
from clientes cl inner join TipoPersona tp
on cl.IdTipoPersona = tp.IdTipoPersona
end