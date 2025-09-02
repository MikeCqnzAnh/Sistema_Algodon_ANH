CREATE TABLE [dbo].[Moneda](
	[idMoneda] [int] IDENTITY(1,1) NOT NULL,
	[nombreMoneda] [varchar](50) NULL,
	[Abreviacion] [varchar](6) NULL,
	[TipoDeCambio] [Decimal](6,4) NULL,
	[IdEstatus] [int] NULL,
	[IdUsuarioCreacion] [int] NULL,
	[FechaCreacion] [datetime] NULL,
	[IdUsuarioActualizacion] [int] NULL,
	[FechaActualizacion] [datetime] NULL
) 

