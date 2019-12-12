Create procedure Sp_ConsultaMenuRoles
as
Select IdMenuroles,Descripcion,IdPadre,IdEstatus
from MenuRoles
