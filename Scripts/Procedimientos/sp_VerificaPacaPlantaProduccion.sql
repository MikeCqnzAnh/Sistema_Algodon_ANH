CREATE proc sp_VerificaPacaPlantaProduccion 
--declare
@FolioCIA bigint 
as
if exists (select Foliocia from ProduccionDetalle where  Foliocia = @FolioCIA)
	begin
		Select 1 ExistePacaPlanta,pd.IdPlantaOrigen,pl.Descripcion as Planta from ProduccionDetalle pd inner join Plantas pl on pd.IdPlantaOrigen = pl.IdPlanta where  pd.Foliocia = @FolioCIA 
	end
else
	begin
		select 0 ExistePacaPlanta, 0 as IdPlantaOrigen, '' as Planta
	end
			 