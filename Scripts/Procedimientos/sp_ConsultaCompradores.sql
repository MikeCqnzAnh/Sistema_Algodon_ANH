CREATE PROCEDURE sp_ConsultaCompradores
--declare
@Nombre varchar(100)
AS
if @Nombre = ''
	begin
		select IdComprador,
			   Nombre 
		from Compradores
		where IdEstatus = 1
	end
else
	begin
		select IdComprador,
			   Nombre 
		from Compradores
		where IdEstatus = 1
		and   Nombre like '%'+@Nombre+'%'
	end