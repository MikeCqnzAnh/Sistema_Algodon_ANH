CREATE proc sp_ConsultaProcedimiento
@NombreProcedimiento varchar(8000)
as
SELECT SPECIFIC_NAME as NombreProcedimiento
FROM INFORMATION_SCHEMA.ROUTINES 
WHERE ROUTINE_TYPE='PROCEDURE' and SPECIFIC_NAME like '%'+@NombreProcedimiento+'%' 
ORDER BY SPECIFIC_NAME