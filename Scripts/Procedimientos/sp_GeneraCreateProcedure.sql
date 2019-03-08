create proc sp_GeneraCreateProcedure
@NombreProcedimiento varchar(40)
as
SELECT definition as Rutina
FROM sys.sql_modules
WHERE OBJECT_NAME(OBJECT_ID) = @NombreProcedimiento