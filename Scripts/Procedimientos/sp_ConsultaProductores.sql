CREATE PROCEDURE sp_ConsultaProductores
@Nombre varchar(100)
AS
IF @Nombre = ''
BEGIN
SELECT a.IdCliente,
	   a.Nombre
FROM [dbo].[Clientes] a
WHERE a.IdEstatus = 1
order by a.Nombre
END
ELSE
BEGIN
SELECT a.IdCliente,
	   a.Nombre
FROM [dbo].[Clientes] a
WHERE a.IdEstatus = 1
and   a.Nombre like '%'+@Nombre+'%'
order by a.Nombre
END


