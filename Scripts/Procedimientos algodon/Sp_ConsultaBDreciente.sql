create proc Sp_ConsultaBDreciente
as
select database_id, name from sys.databases where database_id in (SELECT  max(database_id) as database_id 
FROM sys.databases
where name like '%Algodon%' )