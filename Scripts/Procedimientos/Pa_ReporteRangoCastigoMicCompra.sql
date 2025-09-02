alter Procedure Pa_ReporteRangoCastigoMicCompra
@IDCompra int,
@IdModoEncabezado int
as
select md.Rango1
	  ,md.Rango2
	  ,md.Castigo
	  ,(select count(hd.baleid) 
		from HviDetalle hd
		where Cast(Round(hd.Mic,2,1) as decimal(18,2)) between md.Rango1 and md.Rango2 and hd.IdCompraEnc = @IDCompra) as CantidadPacas 
	  ,(select isnull(sum(hd.castigoMicCompra) ,0)
		from HviDetalle hd
		where Cast(Round(hd.Mic,2,1) as decimal(18,2)) between md.Rango1 and md.Rango2 and hd.IdCompraEnc = @IDCompra) as Costo
from MicrosDetalle md 
where md.IdModoEncabezado = @IdModoEncabezado
order by md.Rango1