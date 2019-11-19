Create table HviDetalle1
(
[IdHviDet]	INT PRIMARY KEY IDENTITY(1,1)	,
[IdHviEnc]	INT	,
[IdPlantaOrigen]	INT	,
[IdCompraEnc]	INT	,
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
[castigoMicCompra]	FLOAT	,
[CastigoLargoFibraCompra]	FLOAT	,
[CastigoResistenciaFibraCompra]	FLOAT	,
[CastigoUICompra]	FLOAT	,
[CastigoBarkLevel1Compra]	FLOAT	,
[CastigoBarkLevel2Compra]	FLOAT	,
[CastigoPrepLevel1Compra]	FLOAT	,
[CastigoPrepLevel2Compra]	FLOAT	,
[CastigoOtherLevel1Compra]	FLOAT	,
[CastigoOtherLevel2Compra]	FLOAT	,
[CastigoPlasticLevel1Compra]	FLOAT	,
[CastigoPlasticLevel2Compra]	FLOAT	,
[FlagTerminado]	BIT	,
[EstatusCompra]	INT	,
[Seleccion]	BIT	
)
go
insert into HviDetalle1
SELECT [IdHviEnc]
      ,[IdPlantaOrigen]
      ,[IdCompraEnc]
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
      ,[castigoMicCompra]
      ,[CastigoLargoFibraCompra]
      ,[CastigoResistenciaFibraCompra]
      ,[CastigoUICompra]
      ,[CastigoBarkLevel1Compra]
      ,[CastigoBarkLevel2Compra]
      ,[CastigoPrepLevel1Compra]
      ,[CastigoPrepLevel2Compra]
      ,[CastigoOtherLevel1Compra]
      ,[CastigoOtherLevel2Compra]
      ,[CastigoPlasticLevel1Compra]
      ,[CastigoPlasticLevel2Compra]
      ,[FlagTerminado]
      ,[EstatusCompra]
      ,[Seleccion]
  FROM [HviDetalle]
--order by hd.IdHviDet