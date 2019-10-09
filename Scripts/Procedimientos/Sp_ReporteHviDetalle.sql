Create Procedure Sp_ReporteHviDetalle
@IdPaquete int
as
select   b.IdPaquete
        ,b.IdPlanta
	    ,b.IdComprador
		,d.Nombre
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
		,(Select top 1 colorgrade From CalculoClasificacion where IdPaqueteEncabezado = 1 Group By colorgrade Having Count(*) > 1) as TrCntRep
		,(Select top 1 TrashID From CalculoClasificacion where IdPaqueteEncabezado = 1 Group By TrashID Having Count(*) > 1) as TrIDRep
from CalculoClasificacion a inner join PaqueteEncabezado b 
						 on a.IdPaqueteEncabezado = b.IdPaquete
						 inner join ClasesClasificacion c 
						 on b.IdClase = c.idClasificacion
							inner join Compradores d 
						 on b.idComprador = d.IdComprador
where b.IdPaquete = @IdPaquete

