Create proc sp_exportaCatalogos
@BDORIGEN VARCHAR(11),
@BDDESTINO VARCHAR(11)
AS
exec('insert into ['+@BDDESTINO+'].dbo.usuarios
select Nombre, usuario, clave, tipo, claveautorizacion from ['+@BDORIGEN+'].dbo.usuarios')

exec('insert into ['+@BDDESTINO+'].dbo.tipousuario
select Descripcion from ['+@BDORIGEN+'].dbo.tipousuario')