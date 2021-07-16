Create procedure Pa_ActualizaPacasEmbarque
@IdEmbarqueEncabezado int,
@IdComprador int,
@IdPlanta int,
@BaleID bigint,
@NoLote varchar(15),
@EstatusEmbarque int
as
if @EstatusEmbarque = 1
begin
update CalculoClasificacion
set IdEmbarqueEncabezado = @IdEmbarqueEncabezado,
	IdComprador = @IdComprador,
	NoLote = @NoLote,
	EstatusEmbarque = @EstatusEmbarque
where BaleID = @BaleID and IdPlantaOrigen = @IdPlanta
end
else if @EstatusEmbarque = 0
begin
update CalculoClasificacion
set IdEmbarqueEncabezado = null,
	IdComprador = null,
	NoLote = null,
	EstatusEmbarque = null
where BaleID = @BaleID and IdPlantaOrigen = @IdPlanta
end