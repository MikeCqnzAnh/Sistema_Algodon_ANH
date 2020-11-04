alter Procedure Sp_ActualizaEstatusCierraPacaVenta
@BaleID bigint,
@IdVentaEnc int,
@EstatusVentaUpdate int
as
update CalculoClasificacion
set EstatusVenta = @EstatusVentaUpdate
where BaleID = @BaleID and IdVentaEnc = @IdVentaEnc 