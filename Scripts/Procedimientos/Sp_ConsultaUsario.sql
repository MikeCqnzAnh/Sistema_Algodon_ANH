Create Procedure Sp_ConsultaUsuario
@Usuario varchar(15)
as
if exists (select Usuario from Usuarios where Usuario = @Usuario)
begin
 select 1 as Validacion,us.IdUsuario,us.Usuario,us.Clave,us.Tipo,tu.Descripcion from Usuarios Us inner join TipoUsuario Tu on us.Tipo = IdTipo where usuario = @Usuario
end
else 
begin
 select 0 as Validacion,'' as IdUsuario,'' as Usuario,'' as Clave,'' as Tipo, '' as Descripcion
end