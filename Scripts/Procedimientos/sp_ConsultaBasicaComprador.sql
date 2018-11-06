create procedure sp_ConsultaBasicaComprador
as
select a.IdComprador,
	   a.Nombre,
	   a.Telefono,
	   a.Correo
from [dbo].[Compradores] a
where a.IdEstatus = 1