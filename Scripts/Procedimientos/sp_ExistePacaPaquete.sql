create proc sp_ExistePacaPaquete
@FolioCIA int 
as 
if exists (select  BaleID from CalculoClasificacion where BaleID = @FolioCIA)
	begin
		Select 1 ExistePaca
	end
else
	begin
		select 0 ExistePaca
	end