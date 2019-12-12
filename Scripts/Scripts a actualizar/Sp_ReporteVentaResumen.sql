Create Procedure Sp_ReporteVentaResumen
@IdVenta int 
as 
Select VePa.IdVenta
	  ,Comp.Nombre
	  ,Cacl.Grade
	  ,count(Cacl.BaleID) as Cantidad
	  ,sum(Cacl.Kilos) as Kilos
	  ,Sum(Cacl.Quintales) as Quintales
	  ,Cacl.PrecioClase
	  ,isnull(sum(Cacl.PrecioDls),0) as PrecioDls
	  ,isnull(sum(Cacl.CastigoUIVenta),0) as CastigoUIVenta 
	  ,isnull(sum(Cacl.castigoMicVenta),0) as castigoMicVenta
	  ,isnull(sum(Cacl.CastigoResistenciaFibraVenta),0) as CastigoResistenciaFibraVenta
	  ,isnull(sum(Cacl.CastigoLargoFibraVenta),0) as CastigoLargoFibraVenta
      ,isnull(sum(Cacl.CastigoBarkLevel1Venta),0) as CastigoBarkLevel1Venta
      ,isnull(sum(Cacl.CastigoBarkLevel2Venta),0) as CastigoBarkLevel2Venta
      ,isnull(sum(Cacl.CastigoPrepLevel1Venta),0) as CastigoPrepLevel1Venta
      ,isnull(sum(Cacl.CastigoPrepLevel2Venta),0) as CastigoPrepLevel2Venta
      ,isnull(sum(Cacl.CastigoOtherLevel1Venta),0) as CastigoOtherLevel1Venta
      ,isnull(sum(Cacl.CastigoOtherLevel2Venta),0) as CastigoOtherLevel2Venta
      ,isnull(sum(Cacl.CastigoPlasticLevel1Venta),0) as CastigoPlasticLevel1Venta
      ,isnull(sum(Cacl.CastigoPlasticLevel2Venta),0) as CastigoPlasticLevel2Venta
	  ,CoVe.PrecioQuintal
	  ,CoVe.IdUnidadPeso
	  ,UnVe.Descripcion
	  ,CoVe.ValorConversion
	  ,CoVe.Puntos
	  ,CoVe.PrecioSM
	  ,CoVe.PrecioMP
	  ,CoVe.PrecioM
	  ,CoVe.PrecioSLMP
	  ,CoVe.PrecioLMP
	  ,CoVe.PrecioLM
	  ,CoVe.PrecioSGO
	  ,CoVe.PrecioGO
	  ,CoVe.PrecioO
	  ,VePa.Fecha
	  ,ClCl.IdClasificacion
from CalculoClasificacion CaCl inner join VentaPacas VePa on CaCl.IdVentaEnc = VePa.IdVenta
							   inner join ContratoVenta CoVe on VePa.IdContratoAlgodon = CoVe.IdContratoAlgodon and VePa.IdComprador = CoVe.IdComprador
							   inner join Compradores Comp on CoVe.IdComprador = Comp.IdComprador
							   inner join ClasesClasificacion ClCl on CaCl.Grade = ClCl.ClaveCorta
							   inner join UnidadPesoVenta UnVe on CoVe.IdUnidadPeso = UnVe.IdUnidadPeso
where VePa.IdVenta = @IdVenta
Group by VePa.IdVenta
		,Comp.Nombre
		,CaCl.Grade
		,CaCl.PrecioClase
		,CoVe.PrecioQuintal
		,CoVe.IdUnidadPeso
		,UnVe.Descripcion
		,CoVe.ValorConversion
		,CoVe.Puntos
		,CoVe.PrecioSM
		,CoVe.PrecioMP
		,CoVe.PrecioM
		,CoVe.PrecioSLMP
		,CoVe.PrecioSLM
		,CoVe.PrecioLMP
		,CoVe.PrecioLM
		,CoVe.PrecioSGO
		,CoVe.PrecioGO
		,CoVe.PrecioO
		,VePa.Fecha
		,ClCl.IdClasificacion
order by ClCl.IdClasificacion					