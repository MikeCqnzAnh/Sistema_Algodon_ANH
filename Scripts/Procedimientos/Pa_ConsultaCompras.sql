alter procedure Pa_ConsultaCompras
as
select cp.IdCompra
	  ,cp.IdContratoAlgodon
	  ,cl.Nombre
	  ,pl.Descripcion as Planta
	  ,cp.TotalPacas
	  ,cp.Subtotal
	  ,cp.CastigoDls 
	  ,cp.TotalDlls
	  ,cp.Fecha
from CompraPacas cp inner join Clientes cl on cp.IdProductor = cl.IdCliente
					inner join Plantas pl on cp.IdPlanta = pl.IdPlanta
where (select count(baleid) from HviDetalle where IdCompraEnc = cp.IdCompra) > 0
order by cp.IdCompra

					