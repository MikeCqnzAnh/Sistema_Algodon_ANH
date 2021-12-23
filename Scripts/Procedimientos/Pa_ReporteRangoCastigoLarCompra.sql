alter Procedure Pa_ReporteRangoCastigoLarCompra
@IDCompra int,
@IdModoEncabezado int
as
select lfe.Rango1
	  ,lfe.rango2
	  ,lfd.castigo
	  ,(select count(hd.baleid)
		from HviDetalle hd
		where hd.idcompraenc =@IDCompra and Cast(Round(hd.UHML,2,1) as decimal(18,2)) between lfe.Rango1 and lfe.Rango2) as CantidadPacas
	  ,(select isnull(sum(hd.CastigoLargoFibraCompra),0)
		from HviDetalle hd
		where hd.idcompraenc =@IDCompra and Cast(Round(hd.UHML,2,1) as decimal(18,2)) between lfe.Rango1 and lfe.Rango2) as Costo
from LargosFibraEquivalenteDetalle lfe inner join largosfibradetalle lfd on lfe.IdModoEncabezado = lfd.IdModoEncabezado 
where lfe.idmodoencabezado = @IdModoEncabezado 
and lfe.lenghtnds between lfd.rango1 and lfd.rango2
order by lfe.rango1
