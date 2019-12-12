create procedure sp_ConsultaContratosVentaBasico
as
select a.IdContratoAlgodon,
       a.IdComprador,
	   b.Nombre,
	   a.FechaCreacion
from [dbo].[ContratoVenta] a,
     [dbo].[Compradores] b
where a.IdComprador = b.IdComprador
and   a.IdEstatus = 1    