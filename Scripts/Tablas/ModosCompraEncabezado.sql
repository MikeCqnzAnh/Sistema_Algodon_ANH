CREATE TABLE [dbo].[ModosCompraEncabezado](
	[IdModoEncabezado] int primary key IDENTITY(1,1) NOT NULL,
	[Descripcion] varchar(30) NULL,
	[IdEstatus] int NULL,
	[IdUsuarioCreacion] int NULL,
	[FechaCreacion] datetime NULL)