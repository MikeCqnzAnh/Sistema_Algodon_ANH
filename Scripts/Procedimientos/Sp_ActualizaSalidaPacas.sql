Create Procedure Sp_ActualizaSalidaPacas
@IdSalidaPaca int,
@IdEmbarqueEncabezado int,
@NoContenedor varchar(12),
@EstatusSalida int
as
Update EmbarqueDetalle
set IdSalidaEncabezado = @IdSalidaPaca,
	EstatusSalida = @EstatusSalida
where IdEmbarqueEncabezado = @IdEmbarqueEncabezado and NoContenedor = @NoContenedor