Create Procedure Sp_ReporteCompraPacasProductor
as
select copa.IdCompra
	  ,copa.IdContratoAlgodon
	  ,copa.IdProductor
	  ,clie.Nombre
	  ,count(hvid.baleid) as TotalPacas
	  ,copa.PrecioQuintal 
	  ,copa.CastigoMicros
	  ,copa.CastigoLargoFibra
	  ,copa.CastigoResistenciaFibra
	  ,copa.Subtotal
	  ,copa.TotalDlls
from comprapacas copa inner join clientes clie on copa.idproductor = clie.IdCliente
					  inner join hvidetalle Hvid on copa.IdCompra = Hvid.IdCompraEnc
where copa.TotalDlls = 0
group by copa.IdCompra
		,copa.idcontratoalgodon
		,copa.IdProductor
		,clie.nombre
		,copa.precioquintal
		,copa.CastigoMicros
		,copa.CastigoLargoFibra
		,copa.CastigoResistenciaFibra
		,copa.Subtotal
		,copa.TotalDlls
order by copa.IdCompra