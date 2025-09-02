CREATE TABLE [dbo].[LargosFibraDetalle](
	[IdModoDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdModoEncabezado] [int] NULL,
	[Rango1] [decimal](6, 2) NULL,
	[Rango2] [decimal](6, 2) NULL,
	[ColorGrade] [varchar] (5) null,
	[Castigo] [decimal](6, 2) NULL,
	[IdEstatus] [int] NULL
)