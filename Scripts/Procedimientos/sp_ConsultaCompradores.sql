CREATE PROCEDURE sp_ConsultaCompradores
--declare
@Nombre varchar(100)
AS
IF @Nombre = ''
BEGIN
SELECT a.IdComprador,
	   a.Nombre	   
FROM [dbo].[Compradores] a
WHERE a.IdEstatus = 1
END
ELSE
BEGIN
SELECT a.IdComprador,
	   a.Nombre	
FROM [dbo].[Compradores] a   
WHERE a.IdEstatus = 1
and   a.Nombre like '%'+@Nombre+'%'
END