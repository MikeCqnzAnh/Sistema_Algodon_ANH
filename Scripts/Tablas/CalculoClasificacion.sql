create TABLE [dbo].[CalculoClasificacion](
	[IdCalculoClasificacion] [int] IDENTITY(1,1) NOT NULL,
	[IdPaqueteEncabezado] [int] NOT NULL,
	[IdHviDetalle] [int] NOT NULL,
	[IdOrdenTrabajo] [int] NOT NULL,
	[BaleId] [int] NULL,
	[Mic] [float] NULL,
	[ColorGrade] [varchar](4) NULL,
	[TrashId] [int] NULL,
	[Clase] [varchar](4) NULL,
	[UHML] [float] NULL,
	[Strength] [float] NULL,
	[SCI] [int] NULL,
	[FlagTerminado] [bit] NULL,
	[EstatusCompra] [int] Null
	)