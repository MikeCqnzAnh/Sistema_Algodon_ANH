CREATE TABLE Moneda(
	[idMoneda] [int] IDENTITY(1,1) NOT NULL,
	[nombreMoneda] [varchar](12) NULL,
	[Abreviacion] [varchar](6) NULL,
	[IdEstatus] [int] NULL,
	[IdUsuarioCreacion] [int] null,
	[FechaCreacion] [Datetime] null,
	[IdUsuarioActualizacion] [int] null,
	[FechaActualizacion] [DateTime] null)