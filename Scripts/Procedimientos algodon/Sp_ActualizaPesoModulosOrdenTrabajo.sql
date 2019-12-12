create procedure Sp_ActualizaPesoModulosOrdenTrabajo
@idOrdenTrabajo int
as
declare 
@SumaPesosPorOrden as float = (select Sum(Total) as NetoModulo from ordentrabajodetalle where idordentrabajo = @idOrdenTrabajo)

update OrdenTrabajo
set PesoModulos = @SumaPesosPorOrden
where idordentrabajo = @idOrdenTrabajo
