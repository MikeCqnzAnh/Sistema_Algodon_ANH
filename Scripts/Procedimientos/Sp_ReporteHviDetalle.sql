Create Procedure Sp_ReporteHviDetalle
--declare
@IdPaquete int,
@IdPlantaOrigen int 
as
select   b.IdPaquete
        ,b.IdPlanta
	    ,isnull(b.IdComprador,0) as IdComprador
		,isnull(d.Nombre,'') as Nombre
	    ,b.Descripcion
	    ,b.CantidadPacas
		,a.[BaleID]
		,a.[BaleGroup]
		,a.[Operator]
		,a.[Date]
		,a.[Temperature]
		,a.[Humidity]
		,a.[Amount]
		,a.[UHML]
		,a.[UI]
		,a.[Strength]
		,a.[Elongation]
		,a.[SFI]
		,a.[Maturity]
		,a.[Grade]
		,a.[Moist]
		,a.[Mic]
		,a.[Rd]
		,a.[Plusb]
		,a.[ColorGrade]
		,a.[TrashCount]
		,a.[TrashArea]
		,a.[TrashID]
		,a.[SCI]
		,a.[Nep]
		,a.[UV]
		,a.FlagTerminado
		,a.IdHviDetalle
		,a.IdOrdenTrabajo
		,(Select top 1 colorgrade From CalculoClasificacion where IdPaquete = @IdPaquete and IdPlantaOrigen  = @IdplantaOrigen Group By colorgrade Having Count(*) > 1) as TrCntRep
		,(Select top 1 TrashID From CalculoClasificacion where IdPaquete = @IdPaquete and IdPlantaOrigen  = @IdplantaOrigen  Group By TrashID Having Count(*) > 1) as TrIDRep
from CalculoClasificacion a inner join PaqueteEncabezado b 
						 on a.IdPaqueteEncabezado = b.IdPaquete and a.IdPlantaOrigen = b.IdPlanta
						 inner join ClasesClasificacion c 
						 on b.IdClase = c.idClasificacion
							left join Compradores d 
						 on b.idComprador = d.IdComprador
where b.IdPaquete = @IdPaquete and b.IdPlanta = @IdPlantaOrigen
order by a.[BaleID]