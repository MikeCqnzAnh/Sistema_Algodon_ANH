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
	  ,CheckPrep
	  ,IdModoPrep
	  ,CheckPrepLevel1
	  ,CheckPrepLevel2
	  ,CheckOther
	  ,IdModoOther
	  ,CheckOtherLevel1
	  ,CheckOtherLevel2
	  ,CheckPlastic
	  ,IdModoPlastic
	  ,CheckPlasticLevel1
	  ,CheckPlasticLevel2
From ParametrosContratoVenta
where IdContratoVenta = @IdContratoVenta
