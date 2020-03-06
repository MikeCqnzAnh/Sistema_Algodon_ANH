CREATE TABLE [dbo].[EmbarqueEncabezado](
	[IdEmbarqueEncabezado] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[IdComprador] [int] NULL,
	[NombreChofer] [varchar](80) NULL,
	[PlacaTractoCamion] [varchar](15) NULL,
	[NoLicencia] [varchar](15) NULL,
	[NoLote1] [varchar](15) NULL,
	[NoLote2] [varchar](15) NULL,
	[Telefono] [varchar](13) NULL,
	[CantidadCajas] [int] NULL,
	[NoContenedorCaja1] [varchar](13) NULL,
	[PlacaCaja1] [varchar](13) NULL,
	[NoContenedorCaja2] [varchar](13) NULL,
	[PlacaCaja2] [varchar](13) NULL,
	[CantidadPacas] [int] NULL,
	[Fecha] [datetime] NULL,
	[Observaciones] [varchar](300) NULL)

