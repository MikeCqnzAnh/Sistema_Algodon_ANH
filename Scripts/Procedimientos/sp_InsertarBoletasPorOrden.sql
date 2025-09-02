Create procedure sp_InsertarBoletasPorOrden
@IdBoleta int output,
@IdOrdenTrabajo int,
@IdPlanta int,
@FechaOrden datetime,
@Bruto float,
@Tara float,
@Total float,
@IdProductor int,
@IdBodega int,
@NoTransporte int,
@FlagCancelada bit,
@FlagRevisada bit,
@IdEstatus int,
@IdUSuarioCreacion int,
@IdUsuarioActualizacion int
as 
begin 
set nocount on
merge [dbo].[OrdenTrabajoDetalle] as target
using (select  @IdBoleta,@IdOrdenTrabajo,@IdPlanta,@FechaOrden,@Bruto,@Tara,@Total,@IdProductor,@IdBodega,@NoTransporte,@FlagCancelada,@FlagRevisada,@IdEstatus,@IdUSuarioCreacion,@IdUsuarioActualizacion) AS 
SOURCE (IdBoleta,IdOrdenTrabajo,IdPlanta,FechaOrden,Bruto,Tara,Total,IdProductor,IdBodega,NoTransporte,FlagCancelada,FlagRevisada,IdEstatus,IdUSuarioCreacion,IdUsuarioActualizacion)
ON (target.IdBoleta = SOURCE.IdBoleta)
WHEN MATCHED THEN
UPDATE SET
IdOrdenTrabajo = source.IdOrdenTrabajo,
IdPlanta = source.IdPlanta,
FechaOrden = source.FechaOrden,
IdProductor = source.IdProductor,
IdBodega = source.IdBodega,
IdEstatus = source.IdEstatus,
IdUsuarioActualizacion = source.IdUsuarioActualizacion
WHEN NOT MATCHED THEN
INSERT (IdOrdenTrabajo
	   ,IdPlanta
	   ,FechaOrden
	   ,Bruto
	   ,Tara
	   ,Total
	   ,IdProductor
	   ,IdBodega
	   ,NoTransporte
	   ,FlagCancelada
	   ,FlagRevisada
	   ,IdEstatus
	   ,IdUSuarioCreacion
	   ,IdUsuarioActualizacion)
        VALUES (source.IdOrdenTrabajo
			   ,source.IdPlanta
			   ,source.FechaOrden
			   ,source.Bruto
			   ,source.Tara
			   ,source.Total
			   ,source.IdProductor
			   ,source.IdBodega
			   ,source.NoTransporte
			   ,source.FlagCancelada
			   ,source.FlagRevisada
			   ,source.IdEstatus
			   ,source.IdUSuarioCreacion
			   ,source.IdUsuarioActualizacion);
		SET @IdBoleta = SCOPE_IDENTITY()
		END
RETURN @IdBoleta