create procedure sp_ConsultaProductoresTotal
as
SELECT a.IdCliente,
	   a.Nombre	   
FROM [dbo].[Clientes] a     
WHERE a.IdEstatus = 1