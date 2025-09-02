Create procedure Pa_LlenaComboLotes
@EstatusSalida int ,
@IdEmbarqueEnc int ,
@IdSalidaEnc int
as
if @EstatusSalida = 0
	begin
		select distinct ed.IdEmbarqueDet,ed.NoLote 
		from EmbarqueDet ed inner join CalculoClasificacion cc on ed.IdEmbarqueEnc = cc.IdEmbarqueEncabezado and ed.NoLote = cc.NoLote
		where cc.EstatusSalida is null and ed.IdEmbarqueEnc = @IdEmbarqueEnc
	end
else if @estatusSalida = 1
	begin
		select distinct ed.IdEmbarqueDet,ed.NoLote 
		from EmbarqueDet ed inner join CalculoClasificacion cc on ed.IdEmbarqueEnc = cc.IdEmbarqueEncabezado and ed.NoLote = cc.NoLote
		where cc.EstatusSalida = @estatusSalida and ed.IdEmbarqueEnc = @IdEmbarqueEnc and cc.IdSalidaEncabezado = @IdSalidaEnc
	end