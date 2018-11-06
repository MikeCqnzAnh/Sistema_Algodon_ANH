create procedure sp_ConsultaProductorId
@IdProductor int
as
SELECT a.IdCliente,
	   a.Nombre
FROM [dbo].[Clientes] a
WHERE a.IdEstatus = 1
and   a.IdCliente like @IdProductor