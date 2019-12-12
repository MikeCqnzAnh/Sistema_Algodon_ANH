create proc Sp_ActualizaPesoEncabezadoOrdenTrabajo
@idordentrabajo as int
as
declare @Neto as float
update OrdenTrabajo
set @Neto = (select sum (Total) as Neto from OrdenTrabajoDetalle where IdOrdenTrabajo = @idordentrabajo)
where  IdOrdenTrabajo = @idordentrabajo

