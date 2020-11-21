alter Procedure Sp_ReporteRomaneajeEnc
@IdOrdenTrabajo as int,
@CheckStatus as bit
as
Declare @Modulos VARCHAR(max)
SELECT @Modulos = COALESCE(@Modulos + ', ', '') + CONVERT(varchar(100), IdBoleta)  FROM OrdenTrabajoDetalle a, OrdenTrabajo b where a.IdOrdenTrabajo = b.IdOrdenTrabajo and a.IdOrdenTrabajo = @IdOrdenTrabajo
select 
lr.IdOrdenTrabajo,
cl.IdCliente,
cl.Nombre,
pd.fechacreacion as fecha,
@Modulos as Modulos,
lr.Comentarios,
lr.TotalHueso,
lr.TotalPluma,
lr.PorcentajePluma,
lr.TotalBorregos,
lr.TotalPlumaBorregos,
lr.TotalMerma,
lr.PorcentajeMerma,
lr.TotalPacas,
lr.TotalSemilla,
lr.PorcentajeSemilla,
@CheckStatus as CheckStatus,
lr.Idliquidacion
from LiquidacionesPorRomaneaje lr inner join produccion pd on lr.idordentrabajo = pd.IdOrdenTrabajo and lr.idcliente = pd.IdCliente 
								  inner join Clientes cl on lr.IdCliente = cl.IdCliente
where lr.IdOrdenTrabajo = @IdOrdenTrabajo