CREATE Procedure Sp_ActualizaEstatusPacaVenta
@BaleID int,
@LotID int,
@IdVentaEnc int,
@EstatusVentaUpdate int
as
update CalculoClasificacion
set EstatusVenta = @EstatusVentaUpdate
where BaleID = @BaleID and IdVentaEnc = @IdVentaEnc and LotID = @LotID 