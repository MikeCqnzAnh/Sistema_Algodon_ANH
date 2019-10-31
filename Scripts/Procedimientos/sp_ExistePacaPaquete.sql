create proc sp_ExistePacaPaquete
@FolioCIA int ,
@IdPlanta int 
as 
if exists (select  BaleID from CalculoClasificacion where BaleID = @FolioCIA and IdPlantaOrigen = @IdPlanta)
	begin
		Select 1 as ExistePaca, LotID from CalculoClasificacion where BaleID = @FolioCIA and IdPlantaOrigen = @IdPlanta
	end
else
	begin
		select 0 ExistePaca, 0 as LotID
	end