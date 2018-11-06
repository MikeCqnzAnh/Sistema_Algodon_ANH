CREATE TABLE [dbo].[ModosCompraDetalle](
	[IdModoDetalle] [int] primary key IDENTITY(1,1) NOT NULL,
	[IdModoEncabezado] [int] NULL,
	[IdClasificacion] [int] NULL,
	[Diferencial] [int] NULL)
	