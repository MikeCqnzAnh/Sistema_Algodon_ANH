create proc sp_InsertaModosCompraDetalle
@IdModoDetalle int,
@IdModoEncabezado int,
@IdClasificacion int,
@Diferencial int
as
begin
set nocount on
merge [dbo].[ModosCompraDetalle] as target
using (select @IdModoDetalle,@IdModoEncabezado,@IdClasificacion,@Diferencial) as source (IdModoDetalle,IdModoEncabezado,IdClasificacion,Diferencial)
ON (target.IdModoDetalle = source.IdModoDetalle)
WHEN MATCHED THEN
UPDATE SET IdModoEncabezado = source.IdModoEncabezado,
		   IdClasificacion = source.IdClasificacion,
		   Diferencial = source.Diferencial
WHEN NOT MATCHED THEN
INSERT (IdModoEncabezado,IdClasificacion,Diferencial)
VALUES (source.IdModoEncabezado,source.IdClasificacion,source.Diferencial);
END