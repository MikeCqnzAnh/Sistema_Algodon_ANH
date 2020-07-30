CREATE TABLE [dbo].[AlmacenEncabezado]
(	[IdAlmacenEncabezado] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](20) NULL,
	[TipoAlmacen] [int] NULL,
	[CantidadLotes] [int] NULL,
	[CantidadNiveles] [int] NULL,
	[Columnas] [int] NULL,
	[Filas] [int] NULL,
	[FechaAlta] [datetime] NULL)