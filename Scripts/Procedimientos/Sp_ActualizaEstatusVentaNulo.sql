Create Procedure Sp_ActualizaEstatusVentaNulo
@BaleID int,
@IdCompraEnc int
as
update CalculoClasificacion
set EstatusVenta = null 
where BaleID = @BaleID and IdCompraEnc = @IdCompraEnc