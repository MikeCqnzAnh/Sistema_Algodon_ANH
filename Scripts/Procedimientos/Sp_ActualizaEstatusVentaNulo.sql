Create Procedure Sp_ActualizaEstatusVentaNulo
@BaleID int,
@LotID int,
@IdPlanta int,
@IdCompraEnc int
as
update CalculoClasificacion
set EstatusVenta = null 
where BaleID = @BaleID and IdCompraEnc = @IdCompraEnc and LotID = @LotID and IdPlantaOrigen = @IdPlanta