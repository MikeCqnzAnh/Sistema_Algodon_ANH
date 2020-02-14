Create Procedure Sp_ConsultaParametrosContratoVenta
@IdContratoVenta int
as
Select IdParametroContrato
	  ,IdContratoVenta
	  ,CheckMicros
	  ,IdModoMicros
	  ,CheckLargo
	  ,IdModoLargoFibra
	  ,CheckResistencia
	  ,IdModoResistencia
	  ,CheckUniformidad
	  ,IdModoUniformidad
	  ,CheckBark
	  ,IdModoBark
	  ,CheckBarkLevel1
	  ,CheckBarkLevel2
	  ,IdModoPrep
	  ,CheckPrepLevel1
	  ,CheckPrepLevel2
	  ,IdModoOther
	  ,CheckOtherLevel1
	  ,CheckOtherLevel2
	  ,IdModoPlastic
	  ,CheckPlasticLevel1
	  ,CheckPlasticLevel2
From ParametrosContratoVenta
where IdContratoVenta = @IdContratoVenta