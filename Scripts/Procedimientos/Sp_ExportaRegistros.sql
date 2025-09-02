CREATE Procedure Sp_ExportaRegistros
--declare
@InstanciaOrigen varchar(100) ,
@BaseDeDatosOrigen varchar(30),
@BaseDeDatosDestino Varchar(30),
@NombreTabla varchar(30),
@CadenaCampos varchar(max)
as
EXEC('SET IDENTITY_INSERT ['+@BaseDeDatosDestino+'].[dbo].['+@NombreTabla+'] ON

insert into ['+@BaseDeDatosDestino+'].[DBO].['+@NombreTabla+'] ('+@CadenaCampos+')
SELECT '+@CadenaCampos+' FROM ['+@InstanciaOrigen+'].['+@BaseDeDatosOrigen+'].[DBO].['+@NombreTabla+']

SET IDENTITY_INSERT ['+@BaseDeDatosDestino+'].[DBO].['+@NombreTabla+'] OFF')
