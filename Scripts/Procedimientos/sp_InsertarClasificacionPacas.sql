create procedure [dbo].[sp_InsertarClasificacionPacas]
@IdCalculoClasificacion int,
@IdPaqueteEncabezado int,
@IdHviDetalle int,
@IdOrdenTrabajo int,
@BaleId int,
@Mic float,
@ColorGrade varchar(4),
@TrashId int,
@Clase varchar(4),
@UHML float,
@Strength float,
@SCI int,
@FlagTerminado bit
as 
begin 
set nocount on
merge [dbo].[CalculoClasificacion] as target
using (select @IdCalculoClasificacion,@IdPaqueteEncabezado,@IdHviDetalle,@IdOrdenTrabajo,@BaleId,@Mic,@ColorGrade,@TrashId,@Clase,@UHML,@Strength,@SCI,@FlagTerminado) AS SOURCE (IdCalculoClasificacion,IdPaqueteEncabezado,IdHviDetalle,IdOrdenTrabajo,BaleId,Mic,ColorGrade,TrashId,Clase,UHML,Strength,SCI,FlagTerminado)
ON (target.BaleId = SOURCE.BaleId)
WHEN MATCHED THEN
UPDATE SET Mic = Source.Mic,
		   ColorGrade = source.ColorGrade,
		   clase = source.clase,
		   TrashId = source.TrashId,
		   UHML = source.UHML,
		   Strength = source.Strength,
		   sci = source.sci,
		   flagterminado= source.flagterminado
WHEN NOT MATCHED THEN
INSERT (IdPaqueteEncabezado,IdHviDetalle,IdOrdenTrabajo,BaleId,Mic,ColorGrade,TrashId,Clase,UHML,Strength,SCI,flagterminado)
        VALUES (source.IdPaqueteEncabezado,source.IdHviDetalle,source.IdOrdenTrabajo,source.BaleId,source.Mic,source.ColorGrade,source.TrashId,source.Clase,source.UHML,source.Strength,source.SCI,source.flagterminado);		
END