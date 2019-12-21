Alter procedure sp_ConsultaBasicaComprador
as
select a.IdComprador,
	   a.Nombre,
	   a.Rfc,
	   a.Curp,
	   a.Domicilio,
	   a.IdEstado,
	   a.IdMunicipio,
	   a.Telefono,
	   a.Correo,
	   a.IdEstatus
from [dbo].[Compradores] a
where a.IdEstatus = 1