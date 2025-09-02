CREATE TABLE [dbo].[VentaPacas](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdContratoAlgodon] [int] NULL,
	[IdComprador] [int] NULL,
	[IdPlanta] [int] NULL,
	[IdModalidadVenta] [int] NULL,
	[Fecha] [datetime] NULL,
	[TotalPacas] [int] NULL,
	[Observaciones] [varchar](max) NULL,
	[CastigoMicros] [float] NULL,
	[CastigoLargoFibra] [float] NULL,
	[CastigoResistenciaFibra] [float] NULL,
	[InteresPesosMx] [float] NULL,
	[InteresDlls] [float] NULL,
	[PrecioQuintal] [float] NULL,
	[PrecioQuintalBorregos] [float] NULL,
	[PrecioDolar] [float] NULL,
	[Subtotal] [float] NULL,
	[CastigoDls] [float] NULL,
	[AnticipoDls] [float] NULL,
	[TotalDlls] [float] NULL,
	[TotalPesosMx] [float] NULL,
	[IdEstatusCompra] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO