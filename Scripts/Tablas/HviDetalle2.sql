CREATE TABLE HviDetalle2(
	[IdHviDet] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[IdHviEnc] [int] NULL,
	[IdPlantaOrigen] [int] NULL,
	[IdCompraEnc] [int] NULL,
	[IdOrdenTrabajo] [int] NULL,
	[Kilos] [int] NULL,
	[LotID] [int] NULL,
	[BaleID] [bigint] UNIQUE NULL,
	[BaleGroup] [varchar](5) NULL,
	[Operator] [varchar](25) NULL,
	[Date] [datetime] NULL,
	[Temperature] [float] NULL,
	[Humidity] [float] NULL,
	[Amount] [float] NULL,
	[UHML] [float] NULL,
	[UI] [float] NULL,
	[Strength] [float] NULL,
	[Elongation] [float] NULL,
	[SFI] [float] NULL,
	[Maturity] [float] NULL,
	[Grade] [varchar](6) NULL,
	[Moist] [float] NULL,
	[Mic] [float] NULL,
	[Rd] [float] NULL,
	[Plusb] [float] NULL,
	[ColorGrade] [varchar](4) NULL,
	[TrashCount] [int] NULL,
	[TrashArea] [float] NULL,
	[TrashID] [int] NULL,
	[SCI] [int] NULL,
	[Nep] [int] NULL,
	[UV] [float] NULL,
	[Quintales] [float] NULL,
	[PrecioClase] [float] NULL,
	[PrecioDls] [float] NULL,
	[TipoCambio] [float] NULL,
	[PrecioMxn] [float] NULL,
	[castigoMicCompra] [float] NULL,
	[CastigoLargoFibraCompra] [float] NULL,
	[CastigoResistenciaFibraCompra] [float] NULL,
	[CastigoUICompra] [float] NULL,
	[CastigoBarkLevel1Compra] [float] NULL,
	[CastigoBarkLevel2Compra] [float] NULL,
	[CastigoPrepLevel1Compra] [float] NULL,
	[CastigoPrepLevel2Compra] [float] NULL,
	[CastigoOtherLevel1Compra] [float] NULL,
	[CastigoOtherLevel2Compra] [float] NULL,
	[CastigoPlasticLevel1Compra] [float] NULL,
	[CastigoPlasticLevel2Compra] [float] NULL,
	[FlagTerminado] [bit] NULL,
	[EstatusCompra] [int] NULL,
	[Seleccion] [bit] NULL)

