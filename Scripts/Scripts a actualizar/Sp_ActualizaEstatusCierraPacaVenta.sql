Create Procedure Sp_ActualizaEstatusCierraPacaVenta
@BaleID int,
@IdVentaEnc int,
@EstatusVentaUpdate int
as
update CalculoClasificacion
set EstatusVenta = @EstatusVentaUpdate
where BaleID = @BaleID and IdVentaEnc = @IdVentaEnc 
