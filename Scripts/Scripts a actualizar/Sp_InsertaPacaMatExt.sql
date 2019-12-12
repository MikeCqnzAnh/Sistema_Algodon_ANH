Create Procedure Sp_InsertaPacaMatExt
 @IdPaquete int
,@IdOrdenTrabajo int
,@LotID int
,@BaleID int
,@BarkLevel1 float
,@PrepLevel1 float
,@OtherLevel1 float
,@PlasticLevel1 float
,@BarkLevel2 float
,@PrepLevel2 float
,@OtherLevel2 float
,@PlasticLevel2 float
as
begin 
set nocount on 
merge [dbo].[PaqueteMatExt] as target
using (select @IdOrdenTrabajo
			 ,@LotID
			 ,@BaleID
			 ,@BarkLevel1
			 ,@PrepLevel1
			 ,@OtherLevel1
			 ,@PlasticLevel1
			 ,@BarkLevel2
			 ,@PrepLevel2
			 ,@OtherLevel2
			 ,@PlasticLevel2)
			 AS SOURCE (
			  IdOrdenTrabajo
			 ,LotID
			 ,BaleID
			 ,BarkLevel1
			 ,PrepLevel1
			 ,OtherLevel1
			 ,PlasticLevel1
			 ,BarkLevel2
			 ,PrepLevel2
			 ,OtherLevel2
			 ,PlasticLevel2)
ON (Target.LotID = source.LotID and
	Target.BaleID = source.BaleID)
WHEN MATCHED THEN
UPDATE SET	
			BarkLevel1 = source.BarkLevel1
		   ,PrepLevel1 = source.PrepLevel1
		   ,OtherLevel1 = source.OtherLevel1
		   ,PlasticLevel1 = source.PlasticLevel1
		   ,BarkLevel2 = source.BarkLevel2
		   ,PrepLevel2 = source.PrepLevel2
		   ,OtherLevel2 = source.OtherLevel2
		   ,PlasticLevel2 = source.PlasticLevel2
WHEN NOT MATCHED THEN
INSERT (  IdOrdenTrabajo
			 ,LotID
			 ,BaleID
			 ,BarkLevel1
			 ,PrepLevel1
			 ,OtherLevel1
			 ,PlasticLevel1
			 ,BarkLevel2
			 ,PrepLevel2
			 ,OtherLevel2
			 ,PlasticLevel2)
			 VALUES (
			  source.IdOrdenTrabajo
			 ,source.LotID
			 ,source.BaleID
			 ,source.BarkLevel1
			 ,source.PrepLevel1
			 ,source.OtherLevel1
			 ,source.PlasticLevel1
			 ,source.BarkLevel2
			 ,source.PrepLevel2
			 ,source.OtherLevel2
			 ,source.PlasticLevel2);
END
