alter proc sp_consultaClasesCalculo
--DECLARE
@NumPaca int ,
@IdPlanta int,
@IdPaquete int
as
if @NumPaca = 0
	begin
		select
		     hd.[IdPlantaOrigen]
			,isnull(hd.[Kilos],0) as Kilos
			,Hd.[LotID]
			,hd.[BaleID]
			,hd.[BaleGroup]
			,hd.[Operator]
			,hd.[Date]
			,hd.[Temperature]
			,hd.[Humidity]
			,hd.[Amount]
			,hd.[UHML]
			,hd.[UI]
			,hd.[Strength]
			,hd.[Elongation]
			,hd.[SFI]
			,hd.[Maturity]
			,Cc.ClaveCorta as Grade
			,hd.[Moist]
			,hd.[Mic]
			,hd.[Rd]
			,hd.[Plusb]
			,hd.[ColorGrade]
			,hd.[TrashCount]
			,hd.[TrashArea]
			,hd.[TrashID]
			,hd.[SCI]
			,hd.[Nep]
			,hd.[UV]
			,0 as FlagTerminado
			,Pd.IdOrdenTrabajo
		from [dbo].[HVIDetalle] Hd inner join ProduccionDetalle Pd on Hd.BaleID = Pd.FolioCIA and hd.IdOrdenTrabajo = pd.IdOrdenTrabajo and hd.IdPlantaOrigen = pd.IdPlantaOrigen
						   inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
						   inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
  		where Pd.FolioCIA = @NumPaca and hd.IdPlantaOrigen = @IdPlanta
		order by BaleID asc
	end
--else if exists (select baleid from CalculoClasificacion where BaleId = @NumPaca and IdPlantaOrigen = @IdPlanta and IdPaqueteEncabezado = @IdPaquete)
--	begin
--		select 
--		     [IdPlantaOrigen]
--			,[LotID]
--			,[BaleID]
--			,[BaleGroup]
--			,[Operator]
--			,[Date]
--			,[Temperature]
--			,[Humidity]
--			,[Amount]
--			,[UHML]
--			,[UI]
--			,[Strength]
--			,[Elongation]
--			,[SFI]
--			,[Maturity]
--			,[Grade]
--			,[Moist]
--			,[Mic]
--			,[Rd]
--			,[Plusb]
--			,[ColorGrade]
--			,[TrashCount]
--			,[TrashArea]
--			,[TrashID]
--			,[SCI]
--			,[Nep]
--			,[UV]
--			,FlagTerminado
--			,IdHviDetalle 
--			,IdOrdenTrabajo
--		from CalculoClasificacion 
--		where  BaleId = @NumPaca and IdPlantaOrigen = @IdPlanta and IdPaqueteEncabezado = @IdPaquete
--	end
else
	begin
		select
		     Hd.[IdPlantaOrigen]
			,isnull(hd.[Kilos],0) as Kilos
			,hd.[LotID]
			,hd.[BaleID]
			,hd.[BaleGroup]
			,hd.[Operator]
			,hd.[Date]
			,hd.[Temperature]
			,hd.[Humidity]
			,hd.[Amount]
			,hd.[UHML]
			,hd.[UI]
			,hd.[Strength]
			,hd.[Elongation]
			,hd.[SFI]
			,hd.[Maturity]
			,Cc.ClaveCorta as Grade
			,hd.[Moist]
			,hd.[Mic]
			,hd.[Rd]
			,hd.[Plusb]
			,hd.[ColorGrade]
			,hd.[TrashCount]
			,hd.[TrashArea]
			,hd.[TrashID]
			,hd.[SCI]
			,hd.[Nep]
			,hd.[UV]
			,0 as FlagTerminado
			,Pd.IdOrdenTrabajo
		from [dbo].[HVIDetalle] Hd inner join ProduccionDetalle Pd on Hd.BaleID = Pd.FolioCIA and hd.IdOrdenTrabajo = pd.IdOrdenTrabajo and hd.IdPlantaOrigen = pd.IdPlantaOrigen
						   inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
						   inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where Pd.FolioCIA = @NumPaca and hd.IdPlantaOrigen = @IdPlanta 
			order by BaleID asc
end
