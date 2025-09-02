Create procedure Sp_ConsultaPacasSinClaseLiq
@Idordentrabajo int
as
SELECT COUNT(FolioCIA) AS Contar 
from producciondetalle 
where foliocia not in (select baleid from HviDetalle where IdOrdenTrabajo = @Idordentrabajo) and IdOrdenTrabajo = @Idordentrabajo