Create Procedure Sp_ActualizaEstatusPaca
@BaleID int,
@LotID int,
@IdPlanta int,
@IdCompraEnc int,
@EstatusVentaUpdate int
as
update CalculoClasificacion
set EstatusVenta = @EstatusVentaUpdate
where BaleID = @BaleID and IdCompraEnc = @IdCompraEnc and LotID = @LotID and IdPlantaOrigen = @IdPlanta