create Procedure Pa_ReporteRangoCastigoUniActualizacion
@IdVenta int,
@IdModoEncabezado int,
@mod decimal(18,2) = 0,
@sel as bit = 0
as
select ud.Rango1
	  ,ud.Rango2
	  ,ud.castigo	  
	  ,(select count(cc.baleid) 
		from CalculoClasificacion cc
		where Cast(Round(cc.UI,2,1) as decimal(18,2)) between ud.Rango1 and ud.Rango2 and cc.IdVentaEnc = @IdVenta) as NoPacas 
	  ,@mod as RanMod
	  ,@sel as Sel
from UniformidadDetalle ud
where ud.IdModoEncabezado = @IdModoEncabezado
order by ud.Rango1 desc