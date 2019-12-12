Create Procedure Sp_ReporteVentaHVI
--declare
@IdVenta int 
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
		,a.IdOrdenTrabajo
		,a.Kilos
		,a.FlagTerminado
		,(select top 1 subcon.colorgrade from (Select colorgrade,count(colorgrade) as ConteoCGR
		  From CalculoClasificacion 
		  where IdVentaEnc = @IdVenta
		  Group By colorgrade) SubCon
		  order by conteoCGR desc) as TrCntRep
		,(Select top 1 TrashID From CalculoClasificacion where IdVentaEnc = @IdVenta  Group By TrashID Having Count(*) > 1) as TrIDRep
		, a.IdVentaEnc AS IdVenta
from CalculoClasificacion a inner join PaqueteEncabezado b 
						 on a.IdPaqueteEncabezado = b.IdPaquete and a.IdPlantaOrigen = b.IdPlanta
						 inner join ClasesClasificacion c 
						 on b.IdClase = c.idClasificacion
							left join Compradores d 
						 on b.idComprador = d.IdComprador
where a.IdVentaEnc = @IdVenta
order by a.[BaleID]


