Create Procedure Sp_ConsultaParametrosContratoCompra
@IdContratoCompra int
as
Select IdParametroContrato
	  ,IdContratoCompra
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
From ParametrosContratoCompra
where IdContratoCompra = @IdContratoCompra