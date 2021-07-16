Create Procedure Pa_ConsultaFacturaEnc
@IdIntegracion int
as
select IdIntegracionCompra,
	   Emisor,
	   RFC,
	   UUID,
	   Fecha,
	   TotalToneladas,
	   TotalPacas,
	   subtotal,
	   moneda,
	   tipocambio,
	   sello,
	   ruta,
	   FechaCreacion,
	   FechaActualizacion
from FacturasEncabezado
where IdIntegracionCompra = @IdIntegracion