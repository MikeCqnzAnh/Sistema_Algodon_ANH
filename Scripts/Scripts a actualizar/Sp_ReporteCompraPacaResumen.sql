Create Procedure Sp_ReporteCompraPacaResumen
--declare
@IdCompra int 
as
select copa.IdCompra
	  ,Nombre
	  ,grade
	  ,count(BaleID) as Cantidad
	  ,sum(Kilos) as Kilos
	  ,Sum(Quintales) as Quintales
	  ,PrecioClase
	  ,isnull(sum(PrecioDls),0) as PrecioDls
	  ,isnull(sum(CastigoUICompra),0) as CastigoUICompra 
	  ,isnull(sum(castigoMicCompra),0) as castigoMicCompra
	  ,isnull(sum(CastigoResistenciaFibraCompra),0) as CastigoResistenciaFibraCompra
	  ,isnull(sum(CastigoLargoFibraCompra),0) as CastigoLargoFibraCompra
	  ,CoCo.PrecioQuintal
	  ,CoCo.Puntos
	  ,CoCo.PrecioSM
	  ,CoCo.PrecioMP
	  ,CoCo.PrecioM
	  ,CoCo.PrecioSLMP
	  ,CoCo.PrecioLMP
	  ,CoCo.PrecioLM
	  ,CoCo.PrecioSGO
	  ,CoCo.PrecioGO
	  ,CoCo.PrecioO
	  ,CoPa.Fecha
	  ,ClCl.IdClasificacion
from HviDetalle Hvid inner join CompraPacas CoPa on Hvid.IdCompraEnc = CoPa.IdCompra
					 inner join ContratoCompra CoCo on CoPa.IdContratoAlgodon = CoCo.IdContratoAlgodon and CoPa.IdProductor = CoCo.IdProductor
					 inner join Clientes Clie on CoCo.IdProductor = Clie.IdCliente
					 inner join ClasesClasificacion ClCl on Hvid.Grade = ClCl.ClaveCorta
where CoPa.IdCompra = @IdCompra
group by copa.IdCompra
		,Grade
	    ,PrecioClase
		,clie.Nombre
		,CoCo.PrecioQuintal
		,CoCo.Puntos
		,CoCo.PrecioSM
		,CoCo.PrecioMP
		,CoCo.PrecioM
		,CoCo.PrecioSLMP
		,CoCo.PrecioSLM
		,CoCo.PrecioLMP
		,CoCo.PrecioLM
		,CoCo.PrecioSGO
		,CoCo.PrecioGO
		,CoCo.PrecioO
		,CoPa.Fecha
		,ClCl.IdClasificacion
order by ClCl.IdClasificacion