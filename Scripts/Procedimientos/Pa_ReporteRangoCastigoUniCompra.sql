alter Procedure Pa_ReporteRangoCastigoUniCompra
@IDCompra int ,
@IdModoEncabezado int
as
select ud.Rango1
	  ,ud.Rango2
	  ,ud.castigo
	  ,(select count(hd.baleid) 
		from HviDetalle hd
		where Cast(Round(hd.UI,2,1) as decimal(18,2)) between ud.Rango1 and ud.Rango2 and hd.IdCompraEnc = @IDCompra) as CantidadPacas 
	  ,(select isnull(sum(hd.CastigoUICompra),0)
		from HviDetalle hd
		where Cast(Round(hd.UI,2,1) as decimal(18,2)) between ud.Rango1 and ud.Rango2 and hd.IdCompraEnc = @IDCompra) as Costo
from UniformidadDetalle ud
where ud.IdModoEncabezado = @IdModoEncabezado
order by ud.Rango1