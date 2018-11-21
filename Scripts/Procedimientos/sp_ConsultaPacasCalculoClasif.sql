CREATE procedure sp_ConsultaPacasCalculoClasif
@IdPaquete int 
as
select 	 a.[BaleID]
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
from [dbo].[CalculoClasificacion] a
where a.IdPaqueteEncabezado = @IdPaquete
order by a.BaleId asc