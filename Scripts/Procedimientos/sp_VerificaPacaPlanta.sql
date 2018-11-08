create proc sp_VerificaPacaPlanta 
@FolioCIA int 
as
select pd.FolioCIA,pl.Descripcion,pd.IdPlantaOrigen
from ProduccionDetalle PD inner join Plantas PL 
on pd.IdPlantaOrigen = pl.IdPlanta
where FolioCIA = @FolioCIA