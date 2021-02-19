alter procedure Pa_ConsultaCompras
@IdCompra int,
@Nombre varchar(35)
as
if @IdCompra > 0 
begin
select cp.IdCompra
	  ,cp.IdContratoAlgodon
	  ,cl.IdCliente
	  ,cl.Nombre
	  ,cl.Rfc
	  ,pl.Descripcion as Planta
	  ,cp.PrecioQuintal
	  ,cp.TotalPacas
	  ,(select sum(Kilos) from HviDetalle where IdCompraEnc = cp.IdCompra) as Kilos
	  ,cp.Subtotal
	  ,cp.CastigoDls 
	  ,cp.TotalDlls
	  ,cp.Fecha
from CompraPacas cp inner join Clientes cl on cp.IdProductor = cl.IdCliente
					inner join Plantas pl on cp.IdPlanta = pl.IdPlanta
where (select count(baleid) from HviDetalle where IdCompraEnc = cp.IdCompra) > 0 and cp.IdCompra = @IdCompra
order by cp.IdCompra
end
else if @Nombre <> ''
begin
select cp.IdCompra
	  ,cp.IdContratoAlgodon
	  ,cl.IdCliente
	  ,cl.Nombre
	  ,cl.Rfc
	  ,pl.Descripcion as Planta
	  ,cp.PrecioQuintal
	  ,cp.TotalPacas
	  ,(select sum(Kilos) from HviDetalle where IdCompraEnc = cp.IdCompra) as Kilos
	  ,cp.Subtotal
	  ,cp.CastigoDls 
	  ,cp.TotalDlls
	  ,cp.Fecha
from CompraPacas cp inner join Clientes cl on cp.IdProductor = cl.IdCliente
					inner join Plantas pl on cp.IdPlanta = pl.IdPlanta
where (select count(baleid) from HviDetalle where IdCompraEnc = cp.IdCompra) > 0 and cl.Nombre like '%'+@Nombre+'%'
order by cp.IdCompra
end
else 
begin
select cp.IdCompra
	  ,cp.IdContratoAlgodon
	  ,cl.IdCliente
	  ,cl.Nombre
	  ,cl.Rfc
	  ,pl.Descripcion as Planta
	  ,cp.PrecioQuintal
	  ,cp.TotalPacas
	  ,(select sum(Kilos) from HviDetalle where IdCompraEnc = cp.IdCompra) as Kilos
	  ,cp.Subtotal
	  ,cp.CastigoDls 
	  ,cp.TotalDlls
	  ,cp.Fecha
from CompraPacas cp inner join Clientes cl on cp.IdProductor = cl.IdCliente
					inner join Plantas pl on cp.IdPlanta = pl.IdPlanta
where (select count(baleid) from HviDetalle where IdCompraEnc = cp.IdCompra) > 0
order by cp.IdCompra
end				