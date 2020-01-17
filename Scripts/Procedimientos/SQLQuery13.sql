--CREATE Procedure Sp_ActualizaIdOrdenTrabajoPaqueteHVI
--@IdPlanta int,
--@BaleId int
--as
update CaCl
set CaCl.Grade = cc.clavecorta
from CalculoClasificacion CaCl inner join producciondetalle pd on CaCl.idplantaorigen = pd.IdPlantaOrigen and CaCl.BaleID = pd.FolioCIA
					left join GradosClasificacion Gc on CaCl.ColorGrade = Gc.GradoColor and CaCl.TrashID = Gc.TrashId
					left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
where CaCl.IdPaqueteEncabezado in (152,154,155,157,205,194,199,209,211,215,151,188,189,190,191,192,194,196,293)
