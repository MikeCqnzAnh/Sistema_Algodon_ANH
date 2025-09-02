CREATE TABLE [dbo].[AlmacenDetalle](
	[IdAlmacenDetalle] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[IdAlmacenEncabezado] [int] NULL,
	[IdLote] [int] NULL,
	[Nivel] [varchar](1) NULL,
	[PosicionColumna] [int] NULL,
	[PosicionFila] [int] NULL,
	[BaleID] [int] NULL,
	[EstatusAlmacen] [int] NULL)