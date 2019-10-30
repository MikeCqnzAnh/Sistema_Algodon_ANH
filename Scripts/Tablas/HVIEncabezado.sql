CREATE TABLE [dbo].[HVIEncabezado](
	[IdHviEnc] [int] IDENTITY(1,1) NOT NULL,
	[LotID] [Int] null,
	[CantidadPacas] [int] NULL,
	[IdPlanta] [int] NULL,
	[Fecha] [datetime] NULL,
	[IdEstatus] [int] NULL,
	[IdUsuarioCreacion] [int] NULL,
	[FechaCreacion] [datetime] NULL,
	[IdUsuarioActualizacion] [int] NULL,
	[FechaActualizacion] [datetime] NULL,
 ) 