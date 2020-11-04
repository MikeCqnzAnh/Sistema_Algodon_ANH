alter Procedure Sp_ConsultaLotIDporPaca
@BaleID bigint
as
select lotid,BaleID 
from HviDetalle 
where BaleID = @BaleID