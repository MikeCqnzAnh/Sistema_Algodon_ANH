CREATE TABLE CompraPacas1(
	IdCompra int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	IdContratoAlgodon int NULL,
	IdProductor int NULL,
	IdPlanta int NULL,
	IdModalidadCompra int NULL,
	Fecha datetime NULL,
	TotalPacas int NULL,
	Observaciones varchar(max) NULL,
	CastigoMicros float NULL,
	CastigoLargoFibra float NULL,
	CastigoResistenciaFibra float NULL,
	CastigoUI float,
	CastigoBarkLevel1 float,
	CastigoBarkLevel2 float,
	CastigoPrepLevel1 float,
	CastigoPrepLevel2 float,
	CastigoOtherLevel1 float,
	CastigoOtherLevel2 float,
	CastigoPlasticLevel1 float,
	CastigoPlasticLevel2 float,
	IdUnidadPeso int,
	ValorConversion float,
	Unidad int,
	InteresPesosMx float NULL,
	InteresDlls float NULL,
	PrecioQuintal float NULL,
	PrecioQuintalBorregos float NULL,
	PrecioDolar float NULL,
	Subtotal float NULL,
	CastigoDls float NULL,
	AnticipoDls float NULL,
	TotalDlls float NULL,
	TotalPesosMx float NULL,
	IdEstatusCompra int NULL)

INSERT INTO CompraPacas1
SELECT IdContratoAlgodon
      ,IdProductor
      ,IdPlanta
      ,IdModalidadCompra
      ,Fecha
      ,TotalPacas
      ,Observaciones
      ,CastigoMicros
      ,CastigoLargoFibra
      ,CastigoResistenciaFibra
	  , NULL AS CastigoUI 
	  , NULL AS CastigoBarkLevel1 
	  , NULL AS CastigoBarkLevel2 
	  , NULL AS CastigoPrepLevel1 
	  , NULL AS CastigoPrepLevel2 
	  , NULL AS CastigoOtherLevel1 
	  , NULL AS CastigoOtherLevel2 
	  , NULL AS CastigoPlasticLevel1 
	  , NULL AS CastigoPlasticLevel2 
	  , NULL AS IdUnidadPeso 
	  , NULL AS ValorConversion 
	  , NULL AS Unidad 
      ,InteresPesosMx
      ,InteresDlls
      ,PrecioQuintal
      ,PrecioQuintalBorregos
      ,PrecioDolar
      ,Subtotal
      ,CastigoDls
      ,AnticipoDls
      ,TotalDlls
      ,TotalPesosMx
      ,IdEstatusCompra
FROM CompraPacas