select copa.idcompra
	  ,clie.idcliente 
	  ,clie.Nombre
	  ,copa.Fecha
	  ,copa.TotalPacas
	  ,copa.PrecioQuintal
	  ,copa.Subtotal
	  ,copa.CastigoMicros
	  ,copa.castigoLargofibra
	  ,copa.CastigoResistenciaFibra
	  ,copa.CastigoDls
	  ,copa.TotalDlls
from comprapacas copa inner join Clientes clie on copa.IdProductor = clie.IdCliente
where copa.idcompra = @IdCompra
order by copa.idcompra