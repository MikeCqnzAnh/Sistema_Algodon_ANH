CREATE procedure Pa_Insertaloteenc
@idlote int output,
@idcomprador int,
@nolote nvarchar(10),
@ubicacion nvarchar(30),
@observaciones nvarchar(100),
@totalpacas int,
@totalkilos decimal(12,4),
@fechacreacion datetime,
@fechaactualizacion datetime,
@idestatus int
as 
begin 
set nocount on
merge lotesenc as target
using (select  @idlote
			  ,@idcomprador
			  ,@nolote
			  ,@ubicacion
			  ,@observaciones
			  ,@totalpacas
			  ,@totalkilos
			  ,@fechacreacion
			  ,@fechaactualizacion
			  ,@idestatus) 
	AS SOURCE (idlote
			  ,idcomprador
			  ,nolote
			  ,ubicacion
			  ,observaciones
			  ,totalpacas
			  ,totalkilos
			  ,fechacreacion
			  ,fechaactualizacion 
			  ,idestatus)
ON (target.idlote = SOURCE.idlote)
WHEN MATCHED THEN
UPDATE SET idcomprador = SOURCE.idcomprador, 
		   nolote = SOURCE.nolote,
		   ubicacion = SOURCE.ubicacion,
		   observaciones = SOURCE.observaciones,
		   totalpacas = SOURCE.totalpacas,
		   totalkilos = SOURCE.totalkilos,
		   fechaactualizacion = SOURCE.fechaactualizacion,
		   idestatus = source.idestatus
WHEN NOT MATCHED THEN
INSERT (idcomprador ,
		nolote ,
		ubicacion ,
		observaciones ,
		totalpacas ,
		totalkilos,
		fechacreacion ,
		fechaactualizacion ,
		idestatus)
        VALUES (SOURCE.idcomprador ,
		SOURCE.nolote ,
		SOURCE.ubicacion ,
		SOURCE.observaciones ,
		SOURCE.totalpacas ,
		SOURCE.totalkilos,
		SOURCE.fechacreacion ,
		SOURCE.fechaactualizacion,
		SOURCE.idestatus);
		SET @idlote = SCOPE_IDENTITY()
		END
return @idlote

