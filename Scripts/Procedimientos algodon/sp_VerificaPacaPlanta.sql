CREATE proc sp_VerificaPacaPlanta 
--declare
@FolioCIA int ,
@IdPlantaOrigen int
as
if exists (select BaleID from HVIDetalle where IdPlanta = @IdPlantaOrigen and BaleID = @FolioCIA)
	begin
		Select 1 ExistePacaPlanta,IdPlanta from HVIDetalle where IdPlanta = @IdPlantaOrigen and BaleID = @FolioCIA 
	end
else
	begin
		select 0 ExistePacaPlanta, 0 as IdPlanta
	end
