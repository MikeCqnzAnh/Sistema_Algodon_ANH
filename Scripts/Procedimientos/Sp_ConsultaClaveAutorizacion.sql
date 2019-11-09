Create Procedure Sp_ConsultaClaveAutorizacion
as
SELECT top 1 ClaveAutorizacion 
FROM Usuarios 
WHERE Tipo = 1