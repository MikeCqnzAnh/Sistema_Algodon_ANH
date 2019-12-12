Create Procedure Sp_ConsultaPaqueteHviEncabezado
@LotID int
as
select LotID
	  ,CantidadPacas
	  ,IdPlanta 
from HVIEncabezado
where LotID = @LotID