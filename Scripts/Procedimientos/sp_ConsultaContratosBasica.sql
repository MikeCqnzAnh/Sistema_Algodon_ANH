create procedure sp_ConsultaContratosBasica
as
select a.IdContratoAlgodon,
       a.IdProductor,
	   b.Nombre,
	   a.IdUnidadPeso,
	   c.Descripcion as UnidadPeso,
	   a.Pacas,
	   a.PacasCompradas,
	   a.PacasDisponibles,
	   a.PrecioQuintal as Precio,
	   a.Puntos,
	   a.FechaCreacion
from [dbo].[ContratoCompra] a inner join [dbo].[Clientes] b on a.IdProductor = b.IdCliente
							  inner join UnidadPesoVenta c on a.IdUnidadPeso = c.IdUnidadPeso
where  a.IdEstatus = 1 