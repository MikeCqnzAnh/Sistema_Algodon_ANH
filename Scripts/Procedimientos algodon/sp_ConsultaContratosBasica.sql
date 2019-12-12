create procedure sp_ConsultaContratosBasica
as
select a.IdContratoAlgodon,
       a.IdProductor,
	   b.Nombre,
	   a.FechaCreacion,
	   a.Presidente
from [dbo].[ContratoCompra] a,
     [dbo].[Clientes] b
where a.IdProductor = b.IdCliente
and   a.IdEstatus = 1    