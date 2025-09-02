alter proc sp_ExistePacaProduccion 
@FolioCIA as bigint ,
@IdPlantaOrigen as int
as 
if exists (select  foliocia from ProduccionDetalle where FolioCIA = @FolioCIA and IdPlantaOrigen = @IdPlantaOrigen)
	begin
		Select 1 ExistePaca
	end
else
	begin
		select 0 ExistePaca
	end