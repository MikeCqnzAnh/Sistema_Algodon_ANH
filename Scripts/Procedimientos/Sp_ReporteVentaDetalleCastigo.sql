Create Procedure Sp_ReporteVentaDetalleCastigo
@IdVenta int
as
select IdVentaEnc
	  ,IdplantaOrigen
	  ,Pl.Descripcion as Planta
	  ,co.Nombre
	  ,BaleID
	  ,Grade
	  ,ColorGrade
	  ,vp.IdUnidadPeso
	  ,vp.ValorConversion
	  ,Kilos
	  ,Quintales as UnidadComercial
	  ,UI
	  ,isnull(CastigoUIVenta,0) as CastigoUI
	  ,Mic
	  ,isnull(castigomicventa,0) as CastigoMic
	  ,UHML
	  ,isnull(castigolargofibraventa,0) as CastigoFib
	  ,strength
	  ,isnull(castigoresistenciafibraventa,0) as CastigoRes
	  ,PrecioClase
	  ,PrecioDls
from ventapacas vp inner join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc 
				   inner join compradores co on vp.idcomprador = co.idcomprador
				   inner join Plantas pl on cc.idplantaorigen = pl.idplanta
where idventaenc = @IdVenta 
order by baleid