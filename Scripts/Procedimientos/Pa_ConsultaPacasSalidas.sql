Create Procedure Pa_ConsultaPacasSalidas
@IdSalidaEncabezado int,
@Seleccionar bit = 0
as 
select cc.IdPaqueteEncabezado,
	   cc.IdVentaEnc,
	   cc.IdPlantaOrigen,
	   pl.Descripcion, 
	   cc.BaleID,
	   cc.NoLote,
	   cc.Kilos,
	   @seleccionar as Seleccionar
from CalculoClasificacion cc inner join Plantas pl on cc.IdPlantaOrigen = pl.IdPlanta
where IdSalidaEncabezado = @IdSalidaEncabezado 