CREATE TABLE SalidaEncabezado(
	[IdSalidaEncabezado] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdEmbarqueEncabezado] [int] NULL,
	[NombreChofer] varchar(80) NULL,
	[PlacaTractoCamion] VARCHAR(15) NULL,
	[NoLicencia] VARCHAR(15) NULL,
	[Telefono] VARCHAR(13) NULL,
	[PesoBruto] [float] NULL,
	[PesoTara] [float] NULL,
	[PesoNeto] [float] NULL,
	[Destino] [varchar](150) NULL,
	[FolioSalida] [int] NULL,
	[NoFactura] [varchar](12) NULL,
	[CantidadPacas] [int] NULL,
	[FechaEntrada] [datetime] NULL,
	[FechaSalida] [datetime] NULL,
	[Observaciones] [varchar](max) NULL,
	[EstatusSalida] [int] NULL
)