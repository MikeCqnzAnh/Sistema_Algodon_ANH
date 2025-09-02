alter proc sp_VerificaPacaPlanta 
--declare
@FolioCIA bigint ,
@IdPlantaOrigen int
as
if exists (select BaleID from HVIDetalle where IdPlantaOrigen = @IdPlantaOrigen and BaleID = @FolioCIA)
	begin
		Select 1 ExistePacaPlanta,IdPlantaOrigen from HVIDetalle where IdPlantaOrigen = @IdPlantaOrigen and BaleID = @FolioCIA 
	end
else
	begin
		select 0 ExistePacaPlanta, 0 as IdPlantaOrigen
	end
			 