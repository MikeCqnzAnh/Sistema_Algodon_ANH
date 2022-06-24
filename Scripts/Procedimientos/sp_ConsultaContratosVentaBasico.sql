Create procedure sp_ConsultaContratosVentaBasico
as
select a.IdContratoAlgodon,
       a.IdComprador,
	   b.Nombre,
	   a.Pacas,
	   a.PacasVendidas,
	   a.PacasDisponibles,
	   a.PrecioQuintal,
	   a.FechaCreacion
from [dbo].[ContratoVenta] a,
     [dbo].[Compradores] b
where a.IdComprador = b.IdComprador
and   a.IdEstatus = 1