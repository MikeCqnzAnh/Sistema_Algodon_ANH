alter Procedure Pa_InsertaFacturaDetalle
@IdFacturaDetalle int,
@IdFacturaEncabezado int,
@ClaveProdServ int,
--@NoIdentificacion varchar(100),
@Cantidad decimal(18,5),
@ClaveUnidad varchar(3),
@Unidad varchar(15),
@Descripcion varchar(1000),
@ValorUnitario decimal(18,5),
--@SubTotal decimal,
@Importe decimal(18,5),
@FechaCreacion datetime,
@FechaActualizacion datetime
as begin
set nocount on 
merge FacturasDetalle as target
using ( select @IdFacturaDetalle,
			   @IdFacturaEncabezado ,
			   @ClaveProdServ ,
			   --@NoIdentificacion ,
			   @Cantidad ,
			   @ClaveUnidad ,
			   @Unidad ,
			   @Descripcion ,
			   @ValorUnitario ,
			   --@SubTotal ,
			   @Importe ,
			   @FechaCreacion ,
			   @FechaActualizacion)
	AS SOURCE (IdFacturaDetalle,
			   IdFacturaEncabezado ,
			   ClaveProdServ ,
			   --NoIdentificacion ,
			   Cantidad ,
			   ClaveUnidad ,
			   Unidad ,
			   Descripcion ,
			   ValorUnitario ,
			   --SubTotal ,
			   Importe ,
			   FechaCreacion ,
			   FechaActualizacion)
ON (target.IdFacturaDetalle = SOURCE.IdFacturaDetalle)
WHEN MATCHED THEN
UPDATE SET IdFacturaencabezado = SOURCE.IdFacturaencabezado,
		   ClaveProdServ = SOURCE.ClaveProdServ,
		   --NoIdentificacion = SOURCE.NoIdentificacion,
		   Cantidad = SOURCE.Cantidad,
		   ClaveUnidad = SOURCE.ClaveUnidad,
		   Unidad = SOURCE.Unidad,
		   Descripcion = SOURCE.Descripcion,
		   ValorUnitario = SOURCE.ValorUnitario,
		   --SubTotal = SOURCE.SubTotal,
		   Importe = SOURCE.Importe,
		   FechaActualizacion = SOURCE.FechaActualizacion
WHEN NOT MATCHED THEN
INSERT (IdFacturaEncabezado ,
		ClaveProdServ ,
		--NoIdentificacion ,
		Cantidad ,
		ClaveUnidad ,
		Unidad ,
		Descripcion ,
		ValorUnitario ,
		--SubTotal ,
		Importe ,
		FechaCreacion ,
		FechaActualizacion)
		VALUES (SOURCE.IdFacturaEncabezado ,
			    SOURCE.ClaveProdServ ,
			    --SOURCE.NoIdentificacion ,
			    SOURCE.Cantidad ,
			    SOURCE.ClaveUnidad ,
			    SOURCE.Unidad ,
			    SOURCE.Descripcion ,
			    SOURCE.ValorUnitario ,
			    --SOURCE.SubTotal ,
			    SOURCE.Importe ,
			    SOURCE.FechaCreacion ,
			    SOURCE.FechaActualizacion);
		SET @IdFacturaDetalle = SCOPE_IDENTITY()
		END