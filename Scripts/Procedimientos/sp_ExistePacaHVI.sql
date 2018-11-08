create proc sp_ExistePacaHVI
@FolioCIA int 
as 
if exists (select  BaleID from HVIDetalle where BaleID = @FolioCIA)
	begin
		Select 1 ExistePaca
	end
else
	begin
		select 0 ExistePaca
	end