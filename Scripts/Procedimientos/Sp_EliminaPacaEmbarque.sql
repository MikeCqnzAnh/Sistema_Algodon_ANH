alter Procedure Sp_EliminaPacaEmbarque
@IdVentaEnc int,
@BaleID bigint
as
update CalculoClasificacion
set IdEmbarqueEncabezado = null
   ,IdComprador = null
   ,NoContenedor = null
   ,NoLote = null
   ,PlacaCaja = null
   ,EstatusEmbarque = null
   ,EstatusSalida = null
where BaleID = @BaleID and IdVentaEnc = @IdVentaEnc
