create procedure sp_InsertarBoletasPorOrden
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
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion datetime
as 
begin 
set nocount on
merge [dbo].[OrdenTrabajoDetalle] as target
using (select  @IdBoleta,@IdOrdenTrabajo,@IdPlanta,@FechaOrden,@Bruto,@Tara,@Total,@IdProductor,@IdBodega,@NoTransporte,@FlagCancelada,@FlagRevisada,@IdEstatus,@IdUSuarioCreacion,@FechaCreacion,@IdUsuarioActualizacion,@FechaActualizacion) AS 
SOURCE (IdBoleta,IdOrdenTrabajo,IdPlanta,FechaOrden,Bruto,Tara,Total,IdProductor,IdBodega,NoTransporte,FlagCancelada,FlagRevisada,IdEstatus,IdUSuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
ON (target.IdBoleta = SOURCE.IdBoleta)
WHEN MATCHED THEN
UPDATE SET
IdOrdenTrabajo = source.IdOrdenTrabajo,
IdPlanta = source.IdPlanta,
FechaOrden = source.FechaOrden,
Bruto = source.Bruto,
Tara = source.Tara,
Total = source.Total,
IdProductor = source.IdProductor,
IdBodega = source.IdBodega,
NoTransporte = source.NoTransporte,
FlagCancelada = source.FlagCancelada,
FlagRevisada = source.FlagRevisada,
IdEstatus = source.IdEstatus,
IdUsuarioActualizacion = source.IdUsuarioActualizacion,
FechaActualizacion = source.FechaActualizacion
WHEN NOT MATCHED THEN
INSERT (IdOrdenTrabajo,IdPlanta,FechaOrden,Bruto,Tara,Total,IdProductor,IdBodega,NoTransporte,FlagCancelada,FlagRevisada,IdEstatus,IdUSuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
        VALUES (source.IdOrdenTrabajo,source.IdPlanta,source.FechaOrden,source.Bruto,source.Tara,source.Total,source.IdProductor,source.IdBodega,source.NoTransporte,source.FlagCancelada,source.FlagRevisada,source.IdEstatus,source.IdUSuarioCreacion,source.
FechaCreacion,source.IdUsuarioActualizacion,source.FechaActualizacion);
		SET @IdBoleta = SCOPE_IDENTITY()
		END
RETURN @IdBoleta