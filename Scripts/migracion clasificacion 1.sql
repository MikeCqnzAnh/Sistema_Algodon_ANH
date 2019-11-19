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
GO
insert into CalculoClasificacion1
select 
[IdVentaEnc]	,
[IdPlantaOrigen]	,
[IdPaqueteEncabezado]	,
[IdOrdenTrabajo]	,
null as [Kilos]	,
[LotID]	,
[BaleID]	,
[BaleGroup]	,
[Operator]	,
[Date]	,
[Temperature]	,
[Humidity]	,
[Amount]	,
[UHML]	,
[UI]	,
[Strength]	,
[Elongation]	,
[SFI]	,
[Maturity]	,
[Grade]	,
[Moist]	,
[Mic]	,
[Rd]	,
[Plusb]	,
[ColorGrade]	,
[TrashCount]	,
[TrashArea]	,
[TrashID]	,
[SCI]	,
[Nep]	,
[UV]	,
[castigoMicVenta]	,
[CastigoLargoFibraVenta]	,
[CastigoResistenciaFibraVenta]	,
null as [CastigoUIVenta]	,
null as [CastigoBarkLevel1Venta]	,
null as [CastigoBarkLevel2Venta]	,
null as [CastigoPrepLevel1Venta]	,
null as [CastigoPrepLevel2Venta]	,
null as [CastigoOtherLevel1Venta]	,
null as [CastigoOtherLevel2Venta]	,
null as [CastigoPlasticLevel1Venta]	,
null as [CastigoPlasticLevel2Venta]	,
1 as [FlagTerminado]	,
1 as [EstatusVenta]	,
0 as [Seleccion]	
from CalculoClasificacion