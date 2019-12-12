alter Procedure Sp_ActualizaIdOrdenTrabajoPaqueteHVI
@IdPlanta int,
@BaleId int
as
update hvi
set hvi.IdOrdenTrabajo = pd.IdOrdenTrabajo,
	hvi.Kilos = pd.kilos,
	hvi.Quintales = round((pd.kilos /46.02),4,0),
	hvi.Grade = cc.clavecorta,
	FlagTerminado = 1
from hvidetalle hvi inner join producciondetalle pd on hvi.idplantaorigen = pd.IdPlantaOrigen and hvi.BaleID = pd.FolioCIA
					left join GradosClasificacion Gc on hvi.ColorGrade = Gc.GradoColor and hvi.TrashID = Gc.TrashId
					left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
where hvi.IdPlantaOrigen = @IdPlanta and hvi.Baleid = @BaleId