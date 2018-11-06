CREATE TABLE IncidenciasBoletasPorLotes(
	[IdIncidenciasBoletasPorLotes] [int] IDENTITY(1,1) NOT NULL,
	[IdBoleta] [int] NULL,
	[NoTransporte] [int] NULL,
	[Bruto] [float] NULL,
	[Tara] [float] NULL,
	[Neto] [float] NULL,
	[Revisada] [bit] null,
	[TipoFlete] [varchar](15) NULL,
	[FechaCreacion] [datetime] NULL,
	[IdUsuarioCreacion] [int] null,
	[FechaActualizacion] [Datetime] null,
	[IdUSuarioActualizacion] [int] null
)