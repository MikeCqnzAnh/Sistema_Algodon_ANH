alter Procedure Sp_ActualizaSalidaPacas
@IdSalidaPaca int,
@IdEmbarqueEncabezado int,
@NoLote varchar(12),
@EstatusSalida int
as
Update CalculoClasificacion
set IdSalidaEncabezado = @IdSalidaPaca,
	EstatusSalida = @EstatusSalida
where IdEmbarqueEncabezado = @IdEmbarqueEncabezado and Nolote = @NoLote
