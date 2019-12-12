create procedure sp_CreaBdd(@NOMBREBDD VARCHAR(11))
as
BEGIN 
Exec('Create Database' + @NOMBREBDD) 
END 
GO