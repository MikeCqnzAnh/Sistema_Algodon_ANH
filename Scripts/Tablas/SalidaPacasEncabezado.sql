CREATE TABLE [dbo].[SalidaPacasEncabezado](
	[IdSalidaEncabezado] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[IdEmbarqueEncabezado] [int] NULL,
	[NoLote] [varchar](15) NULL,
	[PesoBruto] [float] NULL,
	[PesoTara] [float] NULL,
	[PesoNeto] [float] NULL,
	[Destino] [varchar](150) NULL,
	[FolioSalida] [int] NULL,
	[NoFactura] [varchar](12) NULL,
	[FechaEntrada] [datetime] NULL,
	[FechaSalida] [datetime] NULL,
	[Observaciones] [varchar](max) NULL,
	[EstatusSalida] [int] NULL)