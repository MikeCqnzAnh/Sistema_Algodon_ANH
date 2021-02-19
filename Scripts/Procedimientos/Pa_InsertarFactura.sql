alter procedure Pa_InsertarFactura
@IdFactura int output,
@IdIntegracionCompra int,
@Emisor varchar(max),
@RFC varchar(13),
@UUID varchar(36),
@Fecha datetime,
@TotalToneladas decimal,
@TotalPacas decimal,
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
			  @IdIntegracionCompra,
			  @Emisor,
			  @RFC,
			  @UUID,
			  @Fecha,
		      @TotalToneladas,
			  @TotalPacas,
			  @subtotal,
			  @total,
			  @moneda,
			  @tipocambio,
			  @sello,
			  @ruta,
			  @FechaCreacion,
			  @FechaActualizacion) 
	AS SOURCE (IdFactura,
			  IdIntegracionCompra,
			  Emisor,
			  RFC,
			  UUID,
			  Fecha,
			  TotalToneladas,
			  TotalPacas,
			  subtotal,
			  total,
			  moneda,
			  tipocambio,
			  sello,
			  ruta,
			  FechaCreacion,
			  FechaActualizacion)
ON (target.UUID = SOURCE.UUID)
WHEN MATCHED THEN
UPDATE SET IdIntegracionCompra = SOURCE.IdIntegracionCompra, 
		   Emisor = SOURCE.Emisor,
		   RFC = SOURCE.RFC,
		   UUID = SOURCE.UUID,
		   Fecha = SOURCE.Fecha,
		   TotalToneladas = SOURCE.TotalToneladas,
		   TotalPacas = SOURCE.TotalPacas,
		   subtotal = SOURCE.subtotal,
		   total = SOURCE.total,
		   moneda = SOURCE.moneda,
		   tipocambio = SOURCE.tipocambio,
		   sello = SOURCE.sello,
		   ruta = SOURCE.ruta,
		   FechaCreacion = SOURCE.FechaCreacion,
		   FechaActualizacion = SOURCE.FechaActualizacion 
WHEN NOT MATCHED THEN
INSERT (IdIntegracionCompra,
		Emisor,
		RFC,
		UUID,
		Fecha,
		TotalToneladas,
		TotalPacas,
		subtotal,
		total,
		moneda,
		tipocambio,
		sello,
		ruta,
		FechaCreacion,
		FechaActualizacion)
        VALUES (source.IdIntegracionCompra
			   ,source.Emisor
			   ,source.RFC
			   ,source.UUID
			   ,source.Fecha
			   ,source.TotalToneladas
			   ,source.TotalPacas
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