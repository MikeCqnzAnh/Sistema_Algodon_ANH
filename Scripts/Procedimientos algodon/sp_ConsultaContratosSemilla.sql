create procedure sp_ConsultaContratosSemilla
as
select a.IdContratoSemilla,
       a.Folio,
	   b.Nombre as Comprador,
	   a.Cantidad
from [dbo].[ContratoSemilla] a,
     [dbo].[Compradores] b
where a.IdEstatus = 1
and   a.IdComprador = b.IdComprador