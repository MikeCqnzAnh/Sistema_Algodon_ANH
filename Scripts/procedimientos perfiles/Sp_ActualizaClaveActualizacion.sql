Create Procedure Sp_ActualizaClaveActualizacion
as
update [dbo].[Usuarios]
set ClaveAutorizacion = ROUND(((9999 - 1000) * RAND() + 1000), 0) 
WHERE tipo IN (1,4,9)