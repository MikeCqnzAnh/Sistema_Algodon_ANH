alter Procedure Sp_EliminaPacasSeleccionadas
@FolioCIA bigint,
@IdOrdenTrabajo int 
as
delete  from producciondetalle 
where FolioCIA = @FolioCIA and IdOrdenTrabajo = @IdOrdenTrabajo