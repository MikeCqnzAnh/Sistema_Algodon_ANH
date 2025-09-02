Create Procedure Pa_ActualizaEstatusRevision
@IdProduccion int,
@EstatusRevision bit
as
update Produccion
set EstatusRevisado = @EstatusRevision
where IdProduccion = @IdProduccion