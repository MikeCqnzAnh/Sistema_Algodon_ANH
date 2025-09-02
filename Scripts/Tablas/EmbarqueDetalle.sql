CREATE TABLE [dbo].[EmbarqueDetalle](
	[IdEmbarqueDetalle] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[IdEmbarqueEncabezado] [int] NULL,
	[IdSalidaEncabezado] [int] NULL,
	[IdComprador] [int] NULL,
	[IdVentaEnc] [int] NULL,
	[IdPlanta] [int] NULL,
	[BaleID] [int] NULL,
	[Kilos] [int] NULL,
	[NoContenedor] [varchar](12) NULL,
	[NoLote] [varchar](12) NULL,
	[EstatusEmbarque] [int] NULL,
	[EstatusSalida] [int] NULL)



