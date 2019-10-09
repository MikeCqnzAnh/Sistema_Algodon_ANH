Create Procedure Sp_ActualizaEstatusPaca
@BaleID int,
@IdCompraEnc int,
@EstatusVentaUpdate int
as
update CalculoClasificacion
set EstatusVenta = @EstatusVentaUpdate
where BaleID = @BaleID and IdCompraEnc = @IdCompraEnc