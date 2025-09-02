CREATE TABLE [dbo].[SalidaPacasEncabezado](
	[IdSalidaEncabezado] [int] IDENTITY(1,1) primary key NOT NULL,
	[IdEmbarqueEncabezado] [int] NULL,
	[IdCompradorPorCuentaDe] [int] NULL,
	[NombreChofer] [varchar](80) NULL,
	[PlacaTractoCamion] [varchar](15) NULL,
	[NoLicencia] [varchar](15) NULL,
	[Telefono] [varchar](13) NULL,
	[PesoBruto] [float] NULL,
	[PesoTara] [float] NULL,
	[PesoNeto] [float] NULL,
	[Destino] [varchar](150) NULL,
	[FolioSalida] [int] NULL,
	[NoFactura] [varchar](12) NULL,
	[NoContenedor] [varchar](12) NULL,
	[PlacaCaja] [varchar](12) NULL,
	[FechaEntrada] [datetime] NULL,
	[FechaSalida] [datetime] NULL,
	[Observaciones] [varchar](max) NULL,
	[EstatusSalida] [int] NULL)


