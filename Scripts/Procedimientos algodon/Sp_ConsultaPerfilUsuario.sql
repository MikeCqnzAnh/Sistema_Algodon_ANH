create procedure Sp_ConsultaPerfilUsuario
@IdUsuario int,
@IdTipoUsuario int
as
select pu.IdUsuario,pu.IdTipoUsuario,pu.IdNodo,pu.IdPadre, pu.IdEstatus 
from MenuRoles mr inner join PerfilUsuario pu 
on mr.IdMenuRoles = pu.IdNodo and mr.IdPadre = pu.IdPadre
where pu.IdTipoUsuario = @IdTipoUsuario and pu.IdUsuario = @IdUsuario