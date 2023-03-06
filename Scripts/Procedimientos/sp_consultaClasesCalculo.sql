alter proc sp_consultaClasesCalculo
--DECLARE
@NumPaca bigint ,
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
			,0 as EstatusVenta
			,0 as IdVentaEnc
			,Pd.IdOrdenTrabajo
		from [dbo].[HVIDetalle] Hd inner join ProduccionDetalle Pd on Hd.BaleID = Pd.FolioCIA
						   inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
						   inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
  		where Pd.FolioCIA = @NumPaca and hd.IdPlantaOrigen = @IdPlanta
		order by BaleID asc
	end
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
			,0 as EstatusVenta
			,0 as IdVentaEnc
			,Pd.IdOrdenTrabajo
		from [dbo].[HVIDetalle] Hd inner join ProduccionDetalle Pd on Hd.BaleID = Pd.FolioCIA
						   inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
						   inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where Pd.FolioCIA = @NumPaca and hd.IdPlantaOrigen = @IdPlanta 
		order by BaleID asc
end