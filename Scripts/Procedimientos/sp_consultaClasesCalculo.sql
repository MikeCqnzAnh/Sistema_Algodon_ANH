CREATE proc sp_consultaClasesCalculo
--DECLARE
@NumPaca int ,
@IdPlanta int,
@LotID int
as
if @NumPaca = 0
	begin
		select
			 hd.[IdPlanta] as IdPlantaOrigen
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
			,Hd.IdHviDet as 'IdHviDetalle'
			,Pd.IdOrdenTrabajo
		from [dbo].[HVIDetalle] Hd inner join ProduccionDetalle Pd on Hd.BaleID = Pd.FolioCIA
						   inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
						   inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
  		where Pd.FolioCIA = @NumPaca and hd.IdPlanta = @IdPlanta and hd.LotID = @LotID
		order by BaleID asc
	end
else if exists (select baleid from CalculoClasificacion where BaleId = @NumPaca and IdPlantaOrigen = @IdPlanta and LotID = @LotID)
	begin
		select 
		     [IdPlantaOrigen]
			,[LotID]
			,[BaleID]
			,[BaleGroup]
			,[Operator]
			,[Date]
			,[Temperature]
			,[Humidity]
			,[Amount]
			,[UHML]
			,[UI]
			,[Strength]
			,[Elongation]
			,[SFI]
			,[Maturity]
			,[Grade]
			,[Moist]
			,[Mic]
			,[Rd]
			,[Plusb]
			,[ColorGrade]
			,[TrashCount]
			,[TrashArea]
			,[TrashID]
			,[SCI]
			,[Nep]
			,[UV]
			,FlagTerminado
			,IdHviDetalle 
			,IdOrdenTrabajo
		from CalculoClasificacion 
		where  BaleId = @NumPaca and IdPlantaOrigen = @IdPlanta and LotID = @LotID
		order by BaleID asc
	end
else
	begin
		select
		     Hd.[IdPlanta]  as IdPlantaOrigen
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
			,Hd.IdHviDet AS 'IdHviDetalle'
			,Pd.IdOrdenTrabajo
		from [dbo].[HVIDetalle] Hd inner join ProduccionDetalle Pd on Hd.BaleID = Pd.FolioCIA
						   inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
						   inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where Pd.FolioCIA = @NumPaca and hd.IdPlanta = @IdPlanta and hd.LotID = @LotID
		order by BaleID asc
end