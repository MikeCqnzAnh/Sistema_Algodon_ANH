create procedure Pa_InsertarFactura
@IdFactura int output,
@IdCompra varchar(40),
@Emisor varchar(max),
@RFC varchar(13),
@UUID varchar(36),
@Fecha datetime,
@subtotal decimal,
@total decimal,
@moneda varchar(3),
@tipocambio decimal,
@sello varchar(345),
@ruta varchar(max),
@FechaCreacion datetime,
@FechaActualizacion datetime
as 
begin 
set nocount on
merge FacturasEncabezado as target
using (select @IdFactura,
			  @IdCompra,
			  @Emisor,
			  @RFC,
			  @UUID,
			  @Fecha,
			  @subtotal,
			  @total,
			  @moneda,
			  @tipocambio,
			  @sello,
			  @ruta,
			  @FechaCreacion,
			  @FechaActualizacion) 
	AS SOURCE (IdFactura,
			  IdCompra,
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
			  FechaActualizacion)
ON (target.IdFactura = SOURCE.IdFactura)
WHEN MATCHED THEN
UPDATE SET IdCompra = SOURCE.IdCompra,
		   Emisor = SOURCE.Emisor,
		   RFC = SOURCE.RFC,
		   UUID = SOURCE.UUID,
		   Fecha = SOURCE.Fecha,
		   subtotal = SOURCE.subtotal,
		   total = SOURCE.total,
		   moneda = SOURCE.moneda,
		   tipocambio = SOURCE.tipocambio,
		   sello = SOURCE.sello,
		   ruta = SOURCE.ruta,
		   FechaCreacion = SOURCE.FechaCreacion,
		   FechaActualizacion = SOURCE.FechaActualizacion 
WHEN NOT MATCHED THEN
INSERT (IdCompra,
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
		FechaActualizacion)
        VALUES (source.IdCompra
			   ,source.Emisor
			   ,source.RFC
			   ,source.UUID
			   ,source.Fecha
			   ,source.subtotal
			   ,source.total
			   ,source.moneda
			   ,source.tipocambio
			   ,source.sello
			   ,source.ruta
			   ,source.FechaCreacion
			   ,source.FechaActualizacion);
		SET @IdFactura = SCOPE_IDENTITY()
		END
RETURN @IdFactura