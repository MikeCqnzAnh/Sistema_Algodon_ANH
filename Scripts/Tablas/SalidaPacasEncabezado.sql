Create Table SalidaPacasEncabezado
(
IdSalidaEncabezado int primary key identity(1,1),
IdEmbarqueEncabezado int,
NoLote varchar(15),
PesoBruto float,
PesoTara float,
PesoNeto float,
Destino varchar(150),
NoFactura varchar(12),
FechaEntrada datetime,
FechaSalida datetime,
Observaciones varchar(max),
EstatusSalida int
)