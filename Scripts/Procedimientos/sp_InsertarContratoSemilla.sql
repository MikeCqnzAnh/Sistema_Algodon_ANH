alter procedure sp_InsertarContratoSemilla
@IdContratoSemilla int output, 
@Folio varchar(25),
@Fecha datetime,
@IdComprador int,
@Cantidad float,
@PrecioTonelada float,
@Testigo1 varchar(30),
@Testigo2 varchar(30),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion datetime
as
begin
set nocount on
merge [dbo].[ContratoSemilla] as target
using (select @IdContratoSemilla,@Folio,@Fecha,@IdComprador,@Cantidad,@PrecioTonelada,@Testigo1,@Testigo2,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion,@IdUsuarioActualizacion,@FechaActualizacion) as 
source (IdContratoSemilla,Folio,Fecha,IdComprador,Cantidad,PrecioTonelada,Testigo1,Testigo2,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
ON (target.IdContratoSemilla = source.IdContratoSemilla)
WHEN MATCHED THEN
UPDATE SET 
Folio = source.Folio,
Fecha = source.Fecha,
IdComprador = source.IdComprador,
Cantidad = source.Cantidad,
PrecioTonelada = source.PrecioTonelada,
Testigo1 = source.Testigo1,
Testigo2 = source.Testigo2,
IdUsuarioActualizacion = source.IdUsuarioActualizacion,
FechaActualizacion = source.FechaActualizacion
WHEN NOT MATCHED THEN
INSERT (Folio,Fecha,IdComprador,Cantidad,PrecioTonelada,Testigo1,Testigo2,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
VALUES (source.Folio,source.Fecha,source.IdComprador,source.Cantidad,source.PrecioTonelada,source.Testigo1,source.Testigo2,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion,source.IdUsuarioActualizacion,source.FechaActualizacion);
SET @IdContratoSemilla = SCOPE_IDENTITY()
END
RETURN @IdContratoSemilla