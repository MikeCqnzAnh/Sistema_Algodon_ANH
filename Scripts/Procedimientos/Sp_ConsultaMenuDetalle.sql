Create Procedure Sp_ConsultaMenuDetalle
@IdMenuEncabezado  int
as 
Select IdMenuDetalle , Nombre 
from MenuDetalle 
where IdMenuEncabezado = @IdMenuEncabezado