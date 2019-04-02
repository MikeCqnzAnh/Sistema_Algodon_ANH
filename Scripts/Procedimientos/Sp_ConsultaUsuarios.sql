Create Procedure Sp_ConsultaUsuarios
as
select us.IdUsuario,
	   us.Nombre,
	   us.Usuario,
	   us.Tipo,
	   Tu.Descripcion
from Usuarios Us inner join TipoUsuario Tu on Us.Tipo = Tu.IdTipo