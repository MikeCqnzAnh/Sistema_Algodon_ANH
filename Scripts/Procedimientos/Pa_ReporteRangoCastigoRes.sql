create Procedure Pa_ReporteRangoCastigoRes
@IdVenta int,
@IdModoEncabezado int
as
select rd.Rango1
	  ,rd.Rango2
	  ,rd.Castigo
	  ,(select count(cc.baleid) 
		from CalculoClasificacion cc
		where Cast(Round(cc.Strength,2,1) as decimal(18,2)) between rd.Rango1 and  rd.Rango2 and cc.IdVentaEnc = @IdVenta) as CantidadPacas 
from ResistenciaDetalle rd
where rd.IdModoEncabezado = @IdModoEncabezado
order by rd.Rango1