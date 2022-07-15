CREATE TABLE [dbo].[ContratoVenta01](
	[IdContratoAlgodon] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[IdComprador] [int] NULL,
	[Pacas] [int] NULL,
	[PacasVendidas] [int] NULL,
	[PacasDisponibles] [int] NULL,
	[PacasDispContcomp] [int] NULL,
	[PrecioQuintal] [float] NULL,
	[IdUnidadPeso] [int] NULL,
	[ValorConversion] [float] NULL,
	[Puntos] [float] NULL,
	[FechaLiquidacion] [datetime] NULL,
	[Presidente] [varchar](100) NULL,
	[IdModalidadVenta] [int] NULL,
	[Temporada] [varchar](20) NULL,
	[PrecioSM] [float] NULL,
	[PrecioMP] [float] NULL,
	[PrecioM] [float] NULL,
	[PrecioSLMP] [float] NULL,
	[PrecioSLM] [float] NULL,
	[PrecioLMP] [float] NULL,
	[PrecioLM] [float] NULL,
	[PrecioSGO] [float] NULL,
	[PrecioGO] [float] NULL,
	[PrecioO] [float] NULL,
	[IdEstatus] [int] NULL,
	[IdUsuarioCreacion] [int] NULL,
	[FechaCreacion] [datetime] NULL,
	[FechaActualizacion] [datetime] NULL,
	[IdUsuarioActualizacion] [int] NULL)

GO

INSERT INTO ContratoVenta01 ([IdComprador]
      ,[Pacas]
      ,[PacasVendidas]
      ,[PacasDisponibles]
	  ,[PacasDispContcomp]
      ,[PrecioQuintal]
      ,[IdUnidadPeso]
      ,[ValorConversion]
      ,[Puntos]
      ,[FechaLiquidacion]
      ,[Presidente]
      ,[IdModalidadVenta]
      ,[Temporada]
      ,[PrecioSM]
      ,[PrecioMP]
      ,[PrecioM]
      ,[PrecioSLMP]
      ,[PrecioSLM]
      ,[PrecioLMP]
      ,[PrecioLM]
      ,[PrecioSGO]
      ,[PrecioGO]
      ,[PrecioO]
      ,[IdEstatus]
      ,[IdUsuarioCreacion]
      ,[FechaCreacion]
      ,[FechaActualizacion]
      ,[IdUsuarioActualizacion])
SELECT [IdComprador]
      ,[Pacas]
      ,[PacasVendidas]
      ,[PacasDisponibles]
	  ,0
      ,[PrecioQuintal]
      ,[IdUnidadPeso]
      ,[ValorConversion]
      ,[Puntos]
      ,[FechaLiquidacion]
      ,[Presidente]
      ,[IdModalidadVenta]
      ,[Temporada]
      ,[PrecioSM]
      ,[PrecioMP]
      ,[PrecioM]
      ,[PrecioSLMP]
      ,[PrecioSLM]
      ,[PrecioLMP]
      ,[PrecioLM]
      ,[PrecioSGO]
      ,[PrecioGO]
      ,[PrecioO]
      ,[IdEstatus]
      ,[IdUsuarioCreacion]
      ,[FechaCreacion]
      ,[FechaActualizacion]
      ,[IdUsuarioActualizacion]
  FROM [dbo].[ContratoVenta]