Create Procedure Sp_ReporteVentaPacaDetalle
@IdVenta int
as 
Select Comp.IdComprador
		,Comp.Nombre
		,VePa.IdVenta
		,CaCl.IdPlantaOrigen
		,CaCl.baleid
		,CaCl.Quintales
		,CaCl.kilos
		,CaCl.grade
		,CaCl.Mic
		,CaCl.Strength
		,CaCl.UHML 
		,CaCl.UI
from CalculoClasificacion CaCl inner join VentaPacas VePa on CaCl.IdVentaEnc = VePa.IdVenta
							   inner join Compradores Comp on VePa.IdComprador = Comp.IdComprador
where VePa.IdVenta = @IdVenta
Order By CaCl.BaleID asc