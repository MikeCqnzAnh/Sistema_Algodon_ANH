create procedure pa_consultausuarioprensa
as
select IdUsuario,Nombre 
from Usuarios
where estatus=1 and Tipo=6