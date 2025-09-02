alter Procedure Pa_ReporteRangoCastigoResCompra
@IDCompra int,
@IdModoEncabezado int
as
select rd.Rango1
	  ,rd.Rango2
	  ,rd.Castigo
	  ,(select count(hd.baleid) 
		from HviDetalle hd
		where Cast(Round(hd.Strength,2,1) as decimal(18,2)) between rd.Rango1 and  rd.Rango2 and hd.IdCompraEnc = @IDCompra) as CantidadPacas 
	  ,(select isnull(sum(hd.CastigoResistenciaFibraCompra) ,0)
		from HviDetalle hd
		where Cast(Round(hd.Strength,2,1) as decimal(18,2)) between rd.Rango1 and  rd.Rango2 and hd.IdCompraEnc = @IDCompra) as Costo
from ResistenciaDetalle rd
where rd.IdModoEncabezado = @IdModoEncabezado
order by rd.Rango1