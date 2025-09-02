create table CalculoClasificacion1
(
IdCalculoClasificacion	INT PRIMARY KEY IDENTITY(1,1)	,
[IdVentaEnc]	INT	,
[IdPlantaOrigen]	INT	,
[IdPaqueteEncabezado]	INT	,
[IdOrdenTrabajo]	INT	,
[Kilos]	INT	,
[LotID]	INT	,
[BaleID]	INT	,
[BaleGroup]	VARCHAR(5)	,
[Operator]	VARCHAR(25)	,
[Date]	DATETIME	,
[Temperature]	FLOAT	,
[Humidity]	FLOAT	,
[Amount]	FLOAT	,
[UHML]	FLOAT	,
[UI]	FLOAT	,
[Strength]	FLOAT	,
[Elongation]	FLOAT	,
[SFI]	FLOAT	,
[Maturity]	FLOAT	,
[Grade]	VARCHAR(6)	,
[Moist]	FLOAT	,
[Mic]	FLOAT	,
[Rd]	FLOAT	,
[Plusb]	FLOAT	,
[ColorGrade]	VARCHAR(4)	,
[TrashCount]	INT	,
[TrashArea]	FLOAT	,
[TrashID]	INT	,
[SCI]	INT	,
[Nep]	INT	,
[UV]	FLOAT	,
[Quintales] FLOAT,
[PrecioDls] FLOAT,
[TipoCambio] FLOAT,
[PrecioMxn] FLOAT,
[castigoMicVenta]	FLOAT	,
[CastigoLargoFibraVenta]	FLOAT	,
[CastigoResistenciaFibraVenta]	FLOAT	,
[CastigoUIVenta]	FLOAT	,
[CastigoBarkLevel1Venta]	FLOAT	,
[CastigoBarkLevel2Venta]	FLOAT	,
[CastigoPrepLevel1Venta]	FLOAT	,
[CastigoPrepLevel2Venta]	FLOAT	,
[CastigoOtherLevel1Venta]	FLOAT	,
[CastigoOtherLevel2Venta]	FLOAT	,
[CastigoPlasticLevel1Venta]	FLOAT	,
[CastigoPlasticLevel2Venta]	FLOAT	,
[FlagTerminado]	BIT	,
[EstatusVenta]	INT	,
[Seleccion]	BIT	
)
INSERT INTO CalculoClasificacion1
SELECT [IdVentaEnc]
      ,[IdPlantaOrigen]
      ,[IdPaqueteEncabezado]
      ,[IdOrdenTrabajo]
      ,[Kilos]
      ,[LotID]
      ,[BaleID]
      ,[BaleGroup]
      ,[Operator]
      ,[Date]
      ,[Temperature]
      ,[Humidity]
      ,[Amount]
      ,[UHML]
      ,[UI]
      ,[Strength]
      ,[Elongation]
      ,[SFI]
      ,[Maturity]
      ,[Grade]
      ,[Moist]
      ,[Mic]
      ,[Rd]
      ,[Plusb]
      ,[ColorGrade]
      ,[TrashCount]
      ,[TrashArea]
      ,[TrashID]
      ,[SCI]
      ,[Nep]
      ,[UV]
	  ,NULL AS [Quintales]
	  ,NULL AS [PrecioDls] 
	  ,NULL AS [TipoCambio]
	  ,NULL AS [PrecioMxn]
      ,[castigoMicVenta]
      ,[CastigoLargoFibraVenta]
      ,[CastigoResistenciaFibraVenta]
      ,[CastigoUIVenta]
      ,[CastigoBarkLevel1Venta]
      ,[CastigoBarkLevel2Venta]
      ,[CastigoPrepLevel1Venta]
      ,[CastigoPrepLevel2Venta]
      ,[CastigoOtherLevel1Venta]
      ,[CastigoOtherLevel2Venta]
      ,[CastigoPlasticLevel1Venta]
      ,[CastigoPlasticLevel2Venta]
      ,[FlagTerminado]
      ,[EstatusVenta]
      ,[Seleccion]
  FROM [CalculoClasificacion]