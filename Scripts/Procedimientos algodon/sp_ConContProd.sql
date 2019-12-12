create procedure sp_ConContProd
@IdProductor int
as
select a.IdContratoAlgodon,
       a.Pacas,
	   a.SuperficieComprometida,
	   a.PrecioQuintal,
	   a.FechaCreacion as Fecha
from [dbo].[ContratoCompra] a
where a.IdEstatus = 1
and a.IdProductor = @IdProductor
