CREATE procedure sp_ConsultaPacasBaleID
--declare
@BaleID int,
@IdPlanta int,
@LotID int,
@Clase varchar(5) = ''
as
select
       a.BaleID,
       a.Mic,
	   a.ColorGrade,
	   a.TrashID,
	   a.SCI,
	   @Clase as Clase,
	   a.UHML,
	   a.Strength,
	   a.SCI,
	   a.IdHviDet
from [dbo].[HVIDetalle] a    
where a.BaleID = @BaleID and a.IdPlanta = @IdPlanta and a.LotID = @LotID