Create Procedure pa_consultacontratoventa
@nombre varchar(100)
as
select cv.IdContratoAlgodon,
	   cv.IdComprador,
	   co.Nombre,
	   cv.Pacas,
	   cv.PacasVendidas,
	   cv.PacasDisponibles,
	   cv.PrecioQuintal,
	   cv.IdUnidadPeso,
	   cv.ValorConversion,
	   cv.Puntos,
	   cv.FechaLiquidacion,
	   cv.IdModalidadVenta,
	   cv.Temporada,
	   cv.PrecioSM,
	   cv.PrecioMP,
	   cv.PrecioM,
	   cv.PrecioSLMP,
	   cv.PrecioSLM,
	   cv.PrecioLMP,
	   cv.PrecioLM,
	   cv.PrecioSGO,
	   cv.PrecioGO,
	   cv.PrecioO
from ContratoVenta cv inner join Compradores co on cv.IdComprador = co.IdComprador
where co.Nombre like '%'+@nombre+'%'