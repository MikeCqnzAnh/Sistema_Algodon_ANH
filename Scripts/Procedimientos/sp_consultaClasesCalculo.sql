create proc sp_consultaClasesCalculo
@NumPaca int
as
if @NumPaca = 0
	begin
		select hd.BaleID,hd.Mic,hd.ColorGrade,hd.TrashID,Cc.ClaveCorta as Clase,Pd.LargoFibra,Pd.ResistenciaFibra , 0 as SCI, 0 as FlagTerminado, Hd.IdHviDet,Pd.IdOrdenTrabajo
		from [dbo].[HVIDetalle] Hd inner join ProduccionDetalle Pd on Hd.BaleID = Pd.FolioCIA
						   inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
						   inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
  		where Pd.FolioCIA = @NumPaca
		order by BaleID asc
	end
else if exists (select baleid from CalculoClasificacion where BaleId = @NumPaca)
	begin
		select BaleID,Mic,ColorGrade,TrashId,Clase,UHML as 'LargoFibra',Strength as 'ResistenciaFibra',SCI, FlagTerminado, IdHviDetalle as 'IdHviDet' , IdOrdenTrabajo
		from CalculoClasificacion 
		where  BaleId = @NumPaca
		order by BaleID asc
	end
else
	begin
		select hd.BaleID,hd.Mic,hd.ColorGrade,hd.TrashID,Cc.ClaveCorta as Clase,Pd.LargoFibra,Pd.ResistenciaFibra , 0 as SCI, 0 as FlagTerminado, Hd.IdHviDet,Pd.IdOrdenTrabajo
		from [dbo].[HVIDetalle] Hd inner join ProduccionDetalle Pd on Hd.BaleID = Pd.FolioCIA
						   inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
						   inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where Pd.FolioCIA = @NumPaca
		order by BaleID asc
end