alter Procedure Pa_ReporteRangoCastigoLarActualizacion
@IdVenta int,
@IdModoEncabezado int,
@mod decimal(18,2) = 0,
@sel as bit = 0
as
select lfe.Rango1
	  ,lfe.rango2
	  ,lfd.castigo
	  ,(select count(cc.baleid)
		from CalculoClasificacion cc
		where cc.idventaenc =@IdVenta and convert(decimal(18,2),UHML) between lfe.Rango1 and lfe.Rango2) as NoPacas
	  ,@mod as RanMod
	  ,@sel as Sel
from LargosFibraEquivalenteDetalle lfe inner join largosfibradetalle lfd on lfe.IdModoEncabezado = lfd.IdModoEncabezado 
where lfe.idmodoencabezado = @IdModoEncabezado 
and lfe.lenghtnds between lfd.rango1 and lfd.rango2
order by lfe.rango1 desc