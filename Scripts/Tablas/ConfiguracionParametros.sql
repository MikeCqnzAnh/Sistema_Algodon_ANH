CREATE TABLE [dbo].[ConfiguracionParametros](
	 [IdConfiguracion] [int] IDENTITY(1,1) NOT NULL
	,[NombrePC] [varchar](30) NULL
	,[DireccionIP] [varchar](15) NULL
	,[NombrePuerto] [varchar](6) NULL
	,[IndicadorID]	[varchar](10)
	,[IndicadorEntrada]	[varchar](10)
	,[IndicadorSalida]	[varchar](10)
	,[IndicadorBruto]	[varchar](10)
	,[IndicadorTara]	[varchar](10)
	,[IndicadorNeto]	[varchar](10)
	,[IndicadorPacasBruto]	[varchar](10)
	,[IndicadorPacasTara]	[varchar](10)
	,[IndicadorPacasNeto]	[varchar](10)
	,[PosicionID]	[int]
	,[PosicionEntrada]	[int]
	,[PosicionSalida]	[int]
	,[PosicionBruto]	[int]
	,[PosicionTara]	[int]
	,[PosicionNeto]	[int]
	,[PacasPosicionBruto]	[int]
	,[PacasPosicionTara]	[int]
	,[PacasPosicionNeto]	[int]
	,[CaracterID]	[int]
	,[CaracterEntrada]	[int]
	,[CaracterSalida]	[int]
	,[CaracterBruto]	[int]
	,[CaracterTara]	[int]
	,[CaracterNeto]	[int]
	,[PacasCaracterBruto]	[int]
	,[PacasCaracterTara]	[int]
	,[PacasCaracterNeto]	[int]
	)