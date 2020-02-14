Create Procedure Sp_InsertaParametrosContratoCompra
@IdParametroContrato int output,
@IdContratoCompra Int,
@CheckMicros bit,
@IdModoMicros int,
@CheckLargo bit,
@IdModoLargoFibra int,
@CheckResistencia bit,
@IdModoResistencia int,
@CheckUniformidad bit,
@IdModoUniformidad int,
@CheckBark bit,
@IdModoBark int,
@CheckBarkLevel1 bit,
@CheckBarkLevel2 bit,
@IdModoPrep int,
@CheckPrepLevel1 bit,
@CheckPrepLevel2 bit,
@IdModoOther int,
@CheckOtherLevel1 bit,
@CheckOtherLevel2 bit,
@IdModoPlastic int,
@CheckPlasticLevel1 bit,
@CheckPlasticLevel2 bit
as
begin
set nocount on 
merge ParametrosContratoCompra as target
 using ( select @IdParametroContrato
			   ,@IdContratoCompra
			   ,@CheckMicros
			   ,@IdModoMicros
			   ,@CheckLargo
			   ,@IdModoLargoFibra
			   ,@CheckResistencia
			   ,@IdModoResistencia
			   ,@CheckUniformidad
			   ,@IdModoUniformidad
			   ,@CheckBark
			   ,@IdModoBark
			   ,@CheckBarkLevel1
			   ,@CheckBarkLevel2
			   ,@IdModoPrep
			   ,@CheckPrepLevel1
			   ,@CheckPrepLevel2
			   ,@IdModoOther
			   ,@CheckOtherLevel1
			   ,@CheckOtherLevel2
			   ,@IdModoPlastic
			   ,@CheckPlasticLevel1
			   ,@CheckPlasticLevel2
		) as Source 
		(	   IdParametroContrato
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
		)
 on (target.IdParametroContrato = Source.IdParametroContrato and target.IdContratoCompra = Source.IdContratoCompra)
 when matched then
	update set CheckMicros = Source.CheckMicros
			  ,IdModoMicros = Source.IdModoMicros
			   ,CheckLargo = Source.CheckLargo
			   ,IdModoLargoFibra = Source.IdModoLargoFibra
			   ,CheckResistencia = Source.CheckResistencia
			   ,IdModoResistencia = Source.IdModoResistencia
			   ,CheckUniformidad = Source.CheckUniformidad
			   ,IdModoUniformidad = Source.IdModoUniformidad
			   ,CheckBark = Source.CheckBark
			   ,IdModoBark = Source.IdModoBark
			   ,CheckBarkLevel1 = Source.CheckBarkLevel1
			   ,CheckBarkLevel2 = Source.CheckBarkLevel2
			   ,IdModoPrep = Source.IdModoPrep
			   ,CheckPrepLevel1 = Source.CheckPrepLevel1
			   ,CheckPrepLevel2 = Source.CheckPrepLevel2
			   ,IdModoOther = Source.IdModoOther
			   ,CheckOtherLevel1 = Source.CheckOtherLevel1
			   ,CheckOtherLevel2 = Source.CheckOtherLevel2
			   ,IdModoPlastic = Source.IdModoPlastic
			   ,CheckPlasticLevel1 = Source.CheckPlasticLevel1
			   ,CheckPlasticLevel2 = Source.CheckPlasticLevel2
 when not matched then
	insert (CheckMicros
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
			,CheckPlasticLevel2)
	values (Source.CheckMicros
			,Source.IdModoMicros
			,Source.CheckLargo
			,Source.IdModoLargoFibra
			,Source.CheckResistencia
			,Source.IdModoResistencia
			,Source.CheckUniformidad
			,Source.IdModoUniformidad
			,Source.CheckBark
			,Source.IdModoBark
			,Source.CheckBarkLevel1
			,Source.CheckBarkLevel2
			,Source.IdModoPrep
			,Source.CheckPrepLevel1
			,Source.CheckPrepLevel2
			,Source.IdModoOther
			,Source.CheckOtherLevel1
			,Source.CheckOtherLevel2
			,Source.IdModoPlastic
			,Source.CheckPlasticLevel1
			,Source.CheckPlasticLevel2);
	set @IdContratoCompra = SCOPE_IDENTITY()
end
return @IdContratoCompra