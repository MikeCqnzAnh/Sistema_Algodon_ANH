Create Procedure Pa_ConsultaLotesInventario
@IdComprador int
as
select isnull(cc.nolote,'SIN LOTE' ) AS NoLote
from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc 
--where vp.idcomprador = @IdComprador
group by cc.nolote
order by cc.nolote
