Create Procedure Sp_ReporteRomaneajeEnc
@IdOrdenTrabajo as int,
@CheckStatus as bit
as
Declare @Modulos VARCHAR(100)
SELECT @Modulos = COALESCE(@Modulos + ', ', '') + CONVERT(varchar(100), IdBoleta)  FROM OrdenTrabajoDetalle a, OrdenTrabajo b where a.IdOrdenTrabajo = b.IdOrdenTrabajo and a.IdOrdenTrabajo = @IdOrdenTrabajo
select 
IdOrdenTrabajo,
cl.IdCliente,
cl.Nombre,
Fecha,
@Modulos as Modulos,
Comentarios,
TotalHueso,
TotalPluma,
PorcentajePluma,
TotalBorregos,
TotalPlumaBorregos,
TotalMerma,
PorcentajeMerma,
TotalPacas,
TotalSemilla,
PorcentajeSemilla,
@CheckStatus as CheckStatus
from LiquidacionesPorRomaneaje lr inner join Clientes cl on 
	 lr.IdCliente = cl.IdCliente
where lr.IdOrdenTrabajo = @IdOrdenTrabajo