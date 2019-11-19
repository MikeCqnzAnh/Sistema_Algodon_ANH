CREATE Procedure Sp_ReporteRomaneajeDet
--declare
@IdOrdenTrabajo as int ,
@CheckStatus as bit 
as
select pd.IdOrdenTrabajo
	  ,pd.IdPlantaOrigen
	  ,pd.FolioCIA as EtiquetaPaca
	  ,pd.kilos 
	  ,HD.Temperature
	  ,HD.Humidity
	  ,HD.Amount
	  ,HD.UHML
	  ,HD.UI
	  ,HD.Strength
	  ,HD.Elongation
	  ,HD.SFI
	  ,HD.Maturity
	  ,isnull(CC.CLAVECORTA,'S/C') AS Grade
	  ,HD.Moist
	  ,HD.Mic
	  ,HD.Rd
	  ,HD.Plusb
	  ,HD.ColorGrade
	  ,HD.TrashCount
	  ,HD.TrashArea
	  ,HD.TrashID
	  ,HD.SCI
	  ,HD.Nep
	  ,HD.UV
	  ,@CheckStatus as CheckStatus
FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlanta = PD.IdPlantaOrigen
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
where pd.IdOrdenTrabajo = @IdOrdenTrabajo
order by hd.BaleID
		