Create Procedure Sp_ReporteCompraPacaDetalle
@IdCompra int
as
select  Clie.IdCliente
	   ,Clie.Nombre
	   ,CoPa.IdCompra
	   ,hvid.idplantaorigen
	   ,hvid.baleid
	   ,hvid.Quintales
	   ,hvid.kilos
	   ,hvid.grade
	   ,hvid.Mic
	   ,hvid.Strength
	   ,hvid.UHML 
from HviDetalle hvid inner join CompraPacas CoPa on hvid.IdCompraEnc = CoPa.IdCompra
					 inner join Clientes Clie on Clie.IdCliente = CoPa.IdProductor
where CoPa.IdCompra = @IdCompra
Order by hvid.BaleID asc