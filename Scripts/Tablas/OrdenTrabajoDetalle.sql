CREATE TABLE [dbo].[OrdenTrabajoDetalle](
	[IdBoleta] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[IdOrdenTrabajo] [int] NULL,
	[IdPlanta] [int] NULL,
	[FechaOrden] [datetime] NULL,
	[Bruto] [float] NULL,
	[Tara] [float] NULL,
	[Total] [float] NULL,
	[IdProductor] [int] NULL,
	[IdBodega] [int] NULL,
	[NoTransporte] [int] NULL,
	[FlagCancelada] [bit] NULL,
	[FlagRevisada] [bit] NULL,
	[IdEstatus] [int] NULL,
	[IdUsuarioCreacion] [int] NULL,
	[FechaEntrada] [datetime] NULL,
	[IdUsuarioActualizacion] [int] NULL,
	[FechaSalida] [datetime] NULL)

