Create Procedure Pa_ConsultaFactura
@UUID varchar(36) 
as
select IdFactura,
		Emisor,
		RFC,
		UUID,
		Fecha,
		subtotal,
		total,
		moneda,
		tipocambio,
		sello,
		ruta,
		FechaCreacion,
		FechaActualizacion
from FacturasEncabezado
where UUID = @UUID