CREATE procedure sp_ConsultaContratosVentaBasico
as
select a.IdContratoAlgodon,
       a.IdComprador,
	   b.Nombre,
	   a.IdUnidadPeso,	 
	   c.Descripcion as UnidadPeso,  
	   a.Pacas,
	   a.PacasVendidas,
	   a.PacasDisponibles,
	   a.PrecioQuintal as Precio,
	   a.Puntos,
	   a.FechaCreacion
from [dbo].[ContratoVenta] a inner join [dbo].[Compradores] b on a.IdComprador = b.IdComprador							 
							 inner join UnidadPesoVenta c on a.IdUnidadPeso = c.IdUnidadPeso 
where a.IdEstatus = 1