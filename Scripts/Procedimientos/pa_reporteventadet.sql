CREATE procedure pa_reporteventadet
@idventa int
as
select sum(PrecioDlsventa) as PrecioDls,
	   precioclaseventa as PrecioClase,
	   cc.IdClasificacion,
	   pd.Grade,
	   sum(kilosventa) as kilos,
	   sum(librasventa) as libras,
	   sum(quintalesventa) as quintales,
	   sum(CastigoMicvta) as CastigoMicros,
	   sum(CastigoLargoFibravta) as CastigoUhml,
	   sum(CastigoResistenciaFibravta) as CastigoStrength,
	   sum(CastigoUIventa) as CastigoUI,
	   count(baleid) as cantidadpacas
from ProduccionDetalle  pd inner join ClasesClasificacion cc on pd.Grade = cc.ClaveCorta
where IdVentaEnc = @idventa
group by cc.IdClasificacion, pd.Grade,pd.PrecioClaseventa
order by cc.IdClasificacion