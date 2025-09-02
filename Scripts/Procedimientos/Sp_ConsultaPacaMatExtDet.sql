alter Procedure Sp_ConsultaPacaMatExtDet
@LotID int,
@BaleID bigint
as
select isnull(Pmat.IdPaquete,0) as IdPaquete
	  ,Hvid.IdOrdenTrabajo
	  ,Hvid.LotId
	  ,Hvid.BaleId
	  ,isnull(Pmat.BarkLevel1,0) as BarkLevel1
	  ,isnull(Hvid.CastigoBarkLevel1Compra,0) as CastigoBarkLevel1Compra
	  ,isnull(Pmat.PrepLevel1,0) as PrepLevel1
	  ,isnull(Hvid.CastigoPrepLevel1Compra,0) as CastigoPrepLevel1Compra
	  ,isnull(Pmat.OtherLevel1,0) as OtherLevel1
	  ,isnull(Hvid.CastigoOtherLevel1Compra,0) as CastigoOtherLevel1Compra
	  ,isnull(Pmat.PlasticLevel1,0) as PlasticLevel1
	  ,isnull(Hvid.CastigoPlasticLevel1Compra,0) as CastigoPlasticLevel1Compra
	  ,isnull(Pmat.BarkLevel2,0) as BarkLevel2
	  ,isnull(Hvid.CastigoBarkLevel2Compra,0) as CastigoBarkLevel2Compra
	  ,isnull(Pmat.PrepLevel2,0) as PrepLevel2
	  ,isnull(Hvid.CastigoPrepLevel2Compra,0) as CastigoPrepLevel2Compra
	  ,isnull(Pmat.OtherLevel2,0) as OtherLevel2
	  ,isnull(Hvid.CastigoOtherLevel2Compra,0) as CastigoOtherLevel2Compra
	  ,isnull(Pmat.PlasticLevel2,0) as PlasticLevel2
	  ,isnull(Hvid.CastigoPlasticLevel2Compra,0) as CastigoPlasticLevel2Compra
from PaqueteMatExt Pmat right join HviDetalle Hvid on Pmat.LotId = Hvid.LotID and Pmat.IdOrdenTrabajo = Hvid.IdOrdenTrabajo and Pmat.BaleId = Hvid.BaleID
where Hvid.LotID = @LotID and Hvid.BaleID = @BaleID
