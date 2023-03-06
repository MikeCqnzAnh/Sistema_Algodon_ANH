create proc sp_ListaTablas
as
SELECT CAST(table_name as varchar(max)) as NombreTabla  FROM INFORMATION_SCHEMA.TABLES where TABLE_NAME<>'sysdiagrams' order by TABLE_NAME