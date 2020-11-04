alter Procedure Sp_InsertaEmbarqueDetalle
@IdEmbarqueEncabezado int,
@IdComprador int,
@IdVentaEnc int,
@IdPlanta int,
@BaleID bigint,
@Kilos int,
@NoContenedor varchar(13),
@NoLote varchar(12),
@PlacaCaja varchar(13),
@EstatusEmbarque int,
@EstatusSalida int
as
update CalculoClasificacion
set IdEmbarqueEncabezado = @IdEmbarqueEncabezado
   ,IdComprador = @IdComprador
   ,NoContenedor = @NoContenedor
   ,NoLote = @NoLote
   ,PlacaCaja = @PlacaCaja
   ,EstatusEmbarque = @EstatusEmbarque
   ,EstatusSalida = @EstatusSalida
where BaleID = @BaleID and IdVentaEnc = @IdVentaEnc
