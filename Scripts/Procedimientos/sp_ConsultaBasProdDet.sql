Create procedure sp_ConsultaBasProdDet
--declare
@IdProduccion int ,
@IdPlantaOrigen int ,
@Sel bit = 0
as
select @Sel as Sel,
	   [IdProduccionDetalle],
       [IdProduccion],
	   [IdOrdenTrabajo],
	   IdPlantaOrigen,
	   [FolioCIA],
       [Tipo],
       [Kilos],
       [Fecha]
from [dbo].[ProduccionDetalle] a
where a.IdEstatus = 1
and   a.IdProduccion = @IdProduccion
and   a.IdPlantaOrigen = @IdPlantaOrigen
order by a.FolioCIA desc