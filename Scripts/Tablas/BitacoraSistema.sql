CREATE TABLE [dbo].[BitacoraSistema](
	[IdBitacora] [int] primary key IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Computadora] [varchar](30) NULL,
	[DireccionIP] [varchar](15) NULL,
	[IdUsuario] [int] NULL,
	[Usuario] [varchar](15) NULL,
	[Modulo] [varchar](50) NULL,
	[Opcion] [varchar](20) NULL,
	[Operacion] [varchar](100) NULL,
	[Observaciones] [varchar](max) NULL,
	[BaseDeDatos] [varchar](20)
)