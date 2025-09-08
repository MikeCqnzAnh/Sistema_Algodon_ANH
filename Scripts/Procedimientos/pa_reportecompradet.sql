create procedure pa_reportecompradet
@idcompra int
as
select sum(PrecioDlscompra) as PrecioDls,
	   precioclasecompra as PrecioClase,
	   cc.IdClasificacion,
	   pd.Grade,
	   sum(kiloscompra) as kilos,
	   sum(librascompra) as libras,
	   sum(quintalescompra) as quintales,
	   sum(CastigoMicCpa) as CastigoMicros,
	   sum(CastigoLargoFibraCpa) as CastigoUhml,
	   sum(CastigoResistenciaFibraCpa) as CastigoStrength,
	   sum(CastigoUICompra) as CastigoUI,
	   count(baleid) as cantidadpacas
from ProduccionDetalle  pd inner join ClasesClasificacion cc on pd.Grade = cc.ClaveCorta
where IdCompraenc = @idcompra
group by cc.IdClasificacion, pd.Grade,pd.PrecioClasecompra
order by cc.IdClasificacion