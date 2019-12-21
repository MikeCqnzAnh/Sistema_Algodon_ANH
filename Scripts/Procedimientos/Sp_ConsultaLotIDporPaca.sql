Create Procedure Sp_ConsultaLotIDporPaca
@BaleID int
as
select lotid,BaleID 
from HviDetalle 
where BaleID = @BaleID