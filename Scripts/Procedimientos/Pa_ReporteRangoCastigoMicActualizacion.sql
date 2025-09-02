create Procedure Pa_ReporteRangoCastigoMicActualizacion
@IdVenta int,
@IdModoEncabezado int,
@mod decimal(18,2) = 0,
@sel as bit = 0
as
select md.Rango1
	  ,md.Rango2
	  ,md.Castigo
	  ,(select count(cc.baleid) 
		from CalculoClasificacion cc
		where Cast(Round(cc.Mic,2,1) as decimal(18,2)) between md.Rango1 and md.Rango2 and cc.IdVentaEnc = @IdVenta) as NoPacas 
	  ,@mod as RanMod
	  ,@sel as Sel
from MicrosDetalle md 
where md.IdModoEncabezado = @IdModoEncabezado
order by md.Rango1 desc