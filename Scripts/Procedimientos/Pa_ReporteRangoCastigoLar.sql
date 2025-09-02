alter Procedure Pa_ReporteRangoCastigoLar
@IdVenta int ,
@IdModoEncabezado int
as
select lfe.Rango1
	  ,lfe.rango2
	  ,lfd.castigo
	  ,(select count(cc.baleid)
		from CalculoClasificacion cc
		where cc.idventaenc =@IdVenta and Cast(Round(cc.UHML,2,1) as decimal(18,2)) between lfe.Rango1 and lfe.Rango2) as CantidadPacas
from LargosFibraEquivalenteDetalle lfe inner join largosfibradetalle lfd on lfe.IdModoEncabezado = lfd.IdModoEncabezado 
where lfe.idmodoencabezado = @IdModoEncabezado 
and lfe.lenghtnds between lfd.rango1 and lfd.rango2
order by lfe.rango1
