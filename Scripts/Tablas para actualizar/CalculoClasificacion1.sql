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
[PrecioClase] INT,
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
	  ,NULL AS [PrecioClase]
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

  GO

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
[PrecioClase] INT,
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
	  ,NULL AS [PrecioClase]
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

  GO

Create Table ExMatCompra
(
IdExmatCompra int primary key identity(1,1),
NombreMateria varchar(20),
Nivel1 float,
Nivel2 float
)

GO

Create Table ExMatVenta
(
IdExmatVenta int primary key identity(1,1),
NombreMateria varchar(20),
Nivel1 float,
Nivel2 float
)

GO

Create table LargosFibraEquivalente
(
IdLargoFibraEquivalente int primary key identity,
Rango1 float,
Rango2 float,
LenghtNDS int
)

GO

Create table LargosFibraEquivalenteVenta
(
IdLargoFibraEquivalente int primary key identity,
Rango1 float,
Rango2 float,
LenghtNDS int
)

GO

Create table UniformidadCompras
(
IdUniformidadCompra int primary key identity(1,1),
Rango1 float,
Rango2 float,
Castigo float
)

go

Create table UniformidadVentas
(
IdUniformidadVentas int primary key identity(1,1),
Rango1 float,
Rango2 float,
Castigo float
)
go
insert into UniformidadCompras (rango1,rango2,castigo) values
(0,77.9,1.05),
(78,78.9,0.6),
(79,79.9,0.5),
(80,100,0)

go 
insert into UniformidadVentas (rango1,rango2,castigo) values
(0,77.9,1.05),
(78,78.9,0.6),
(79,79.9,0.5),
(80,100,0)