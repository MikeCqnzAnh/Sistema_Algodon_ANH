Create Procedure Sp_EliminaPacasSeleccionadas
@FolioCIA int,
@IdOrdenTrabajo int 
as
delete  from producciondetalle 
where FolioCIA = @FolioCIA and IdOrdenTrabajo = @IdOrdenTrabajo