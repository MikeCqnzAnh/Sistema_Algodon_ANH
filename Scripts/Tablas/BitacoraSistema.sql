CREATE TABLE [dbo].[BitacoraSistema](
	[IdBitacora] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] null,
	[Computadora] [varchar](30) NULL,
	[DireccionIP] [varchar](15) NULL,
	[IdUsuario] [int] NULL,
	[Usuario] [Varchar] (15) NULL,
	[Modulo] [varchar](50) NULL,
	[Opcion] [varchar](20) NULL,
	[Operacion] [varchar](100) NULL,
	[Observaciones] [varchar](max) NULL
) 