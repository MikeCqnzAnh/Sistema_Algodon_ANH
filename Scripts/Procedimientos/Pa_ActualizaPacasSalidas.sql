Create Procedure Pa_ActualizaPacasSalidas
@IdSalidaEncabezado int,
@IdEmbarqueEncabezado int,
@IdComprador int,
@IdPlanta int, 
@BaleID bigint,
@NoLote varchar(15),
@NoContenedor varchar(12),
@EstatusSalida int
as
if @IdSalidaEncabezado > 0
begin
update CalculoClasificacion
set IdSalidaEncabezado = @IdSalidaEncabezado,
	EstatusSalida = @EstatusSalida
where BaleID = @BaleID and IdPlantaOrigen = @IdPlanta and IdEmbarqueEncabezado = @IdEmbarqueEncabezado
end
else if @IdSalidaEncabezado = 0
begin
update CalculoClasificacion
set IdSalidaEncabezado = null,
	EstatusSalida = null
where BaleID = @BaleID and IdPlantaOrigen = @IdPlanta
end