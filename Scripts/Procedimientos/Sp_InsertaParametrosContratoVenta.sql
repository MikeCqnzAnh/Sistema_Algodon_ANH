alter Procedure Sp_InsertaParametrosContratoVenta
@IdParametroContrato int output,
@IdContratoVenta Int ,
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
@CheckPrep bit,
@IdModoPrep int,
@CheckPrepLevel1 bit,
@CheckPrepLevel2 bit,
@CheckOther bit,
@IdModoOther int,
@CheckOtherLevel1 bit,
@CheckOtherLevel2 bit,
@CheckPlastic bit,
@IdModoPlastic int,
@CheckPlasticLevel1 bit,
@CheckPlasticLevel2 bit,
@EstatusPesoNeto bit,
@KilosNeto float
as
begin
set nocount on 
merge ParametrosContratoVenta as target
 using ( select @IdParametroContrato
			   ,@IdContratoVenta
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
			   ,@CheckPrep
			   ,@IdModoPrep
			   ,@CheckPrepLevel1
			   ,@CheckPrepLevel2
			   ,@CheckOther
			   ,@IdModoOther
			   ,@CheckOtherLevel1
			   ,@CheckOtherLevel2
			   ,@CheckPlastic
			   ,@IdModoPlastic
			   ,@CheckPlasticLevel1
			   ,@CheckPlasticLevel2
			   ,@EstatusPesoNeto
			   ,@KilosNeto
		) as Source 
		(	   IdParametroContrato
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
			   ,EstatusPesoNeto
			   ,KilosNeto
		)
 on (target.IdContratoVenta = Source.IdContratoVenta)
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
			   ,CheckPrep = Source.CheckPrep
			   ,IdModoPrep = Source.IdModoPrep
			   ,CheckPrepLevel1 = Source.CheckPrepLevel1
			   ,CheckPrepLevel2 = Source.CheckPrepLevel2
			   ,CheckOther = Source.CheckOther
			   ,IdModoOther = Source.IdModoOther
			   ,CheckOtherLevel1 = Source.CheckOtherLevel1
			   ,CheckOtherLevel2 = Source.CheckOtherLevel2
			   ,CheckPlastic = Source.CheckPlastic
			   ,IdModoPlastic = Source.IdModoPlastic
			   ,CheckPlasticLevel1 = Source.CheckPlasticLevel1
			   ,CheckPlasticLevel2 = Source.CheckPlasticLevel2
			   ,EstatusPesoNeto = Source.EstatusPesoNeto
			   ,KilosNeto = Source.KilosNeto
 when not matched then
	insert ( IdContratoVenta
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
			,EstatusPesoNeto
			,KilosNeto)
	values ( Source.IdContratoVenta
			,Source.CheckMicros
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
			,Source.CheckPrep
			,Source.IdModoPrep
			,Source.CheckPrepLevel1
			,Source.CheckPrepLevel2
			,Source.CheckOther
			,Source.IdModoOther
			,Source.CheckOtherLevel1
			,Source.CheckOtherLevel2
			,Source.IdModoPlastic
			,Source.IdModoPlastic
			,Source.CheckPlasticLevel1
			,Source.CheckPlasticLevel2
			,Source.EstatusPesoNeto
			,Source.KilosNeto);
	set @IdParametroContrato = SCOPE_IDENTITY()
end
return @IdParametroContrato
