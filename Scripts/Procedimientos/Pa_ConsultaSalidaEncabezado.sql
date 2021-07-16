Create Procedure Pa_ConsultaSalidaEncabezado
@IdSalidaEncabezado as int
as
select 	IdSalidaEncabezado,
	IdEmbarqueEncabezado,
	NombreChofer,
	PlacaTractoCamion,
	NoLicencia,
	Telefono,
	PesoBruto,
	PesoTara,
	PesoNeto,
	Destino,
	FolioSalida,
	NoFactura,
	CantidadPacas,
	FechaEntrada,
	FechaSalida,
	Observaciones,
	EstatusSalida
from SalidaEncabezado
where IdSalidaEncabezado = @IdSalidaEncabezado