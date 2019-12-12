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
		,UnVe.Descripcion
	    ,CoVe.ValorConversion
from CalculoClasificacion CaCl inner join VentaPacas VePa on CaCl.IdVentaEnc = VePa.IdVenta
							   inner join ContratoVenta CoVe on VePa.IdContratoAlgodon = CoVe.IdContratoAlgodon and VePa.IdComprador = CoVe.IdComprador
							   inner join Compradores Comp on CoVe.IdComprador = Comp.IdComprador
							   inner join ClasesClasificacion ClCl on CaCl.Grade = ClCl.ClaveCorta
							   inner join UnidadPesoVenta UnVe on CoVe.IdUnidadPeso = UnVe.IdUnidadPeso
where VePa.IdVenta = @IdVenta
Order By CaCl.BaleID asc