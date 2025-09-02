CREATE TABLE [dbo].[HVIEncabezado](
	[IdHviEnc] [int] primary key IDENTITY(1,1) NOT NULL,
	[LotID] [int] NULL,
	[CantidadPacas] [int] NULL,
	[IdPlanta] [int] NULL,
	[Fecha] [datetime] NULL,
	[IdEstatus] [int] NULL,
	[IdUsuarioCreacion] [int] NULL,
	[FechaCreacion] [datetime] NULL,
	[IdUsuarioActualizacion] [int] NULL,
	[FechaActualizacion] [datetime] NULL
) 