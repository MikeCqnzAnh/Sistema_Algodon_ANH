create proc sp_ExistePacaProduccion 
@FolioCIA as int 
as 
if exists (select  foliocia from ProduccionDetalle where FolioCIA = @FolioCIA)
	begin
		Select 1 ExistePaca
	end
else
	begin
		select 0 ExistePaca
	end