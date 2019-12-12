ALTER PROCEDURE sp_ConsultaProductores
--declare
@Nombre varchar(100)
AS
IF @Nombre = ''
BEGIN
SELECT a.IdCliente,
	   a.Nombre,
	   b.Descripcion as Asociacion
FROM [dbo].[Clientes] a,
     [dbo].[Asociaciones] b
WHERE a.IdEstatus = 1
and   a.IdCuentaDe = b.IdAsociacion
END
ELSE
BEGIN
SELECT a.IdCliente,
	   a.Nombre,
	   b.Descripcion as Asociacion
FROM [dbo].[Clientes] a,
     [dbo].[Asociaciones] b
WHERE a.IdEstatus = 1
and   a.IdCuentaDe = b.IdAsociacion
and   a.Nombre like '%'+@Nombre+'%'
END


