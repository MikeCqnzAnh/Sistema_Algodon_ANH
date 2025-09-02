CREATE Procedure Sp_ActualizaIdOrdenTrabajoPaqueteHVI
@IdPlanta int,
@BaleId bigint
as
update pd
set pd.IdOrdenTrabajo = pd.IdOrdenTrabajo,
	pd.Kilos = pd.kilos,
	pd.Quintales = round((pd.kilos /46.02),4,0),
	pd.Libras =  round((pd.kilos * 2.2046),4,0),
	pd.Grade = cc.clavecorta,
	FlagTerminadoCompra = 1
from ProduccionDetalle pd left join GradosClasificacion gc on pd.colorgrade = gc.GradoColor and pd.trashid = gc.TrashId
						  left join ClasesClasificacion cc on gc.IdClase = cc.IdClasificacion
where pd.IdPlantaOrigen = @IdPlanta and pd.Baleid = @BaleId