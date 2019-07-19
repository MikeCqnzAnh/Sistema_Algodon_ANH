Create Procedure Sp_ConsultaRolesPredefinidos
@IdTipoUsuario int
as
select IdNodo,IdPadre,IdEstatus
from PerfilUsuario 
where IdTipoUsuario = @IdTipoUsuario
order by IdPerfilUsuario