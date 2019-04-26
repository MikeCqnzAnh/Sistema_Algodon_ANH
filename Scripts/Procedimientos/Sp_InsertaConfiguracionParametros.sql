Create procedure Sp_InsertaConfiguracionParametros
	 @IdConfiguracion int output
	,@NombrePC varchar(30)
	,@DireccionIP varchar(15)
	,@NombrePuerto varchar(6)
	,@InicialModulo int
	,@NoCaracterModulo int
	,@InicialTransporte int
	,@NoCaracterTransporte int
	,@InicialBoletasBruto int
	,@NoCaracterBoletasBruto int
	,@InicialBoletasTara int
	,@NoCaracterBoletasTara int
	,@InicialBoletasNeto int
	,@NoCaracterBoletasNeto int
	,@InicialPacas int
	,@NoCaracteresPacas int
	,@TextoCadenaPesoModulos int
	,@TextoCadenaPesoPacas int
	,@IdSerieBanxico varchar(10)
	,@CampoValorBanxico varchar(10)
	,@PosicionValorBanxico int
	,@LongitudValorBanxico int
	,@SitioBanxico varchar(max)
as
begin
set nocount on
merge dbo.configuracionparametros as target
using (select @IdConfiguracion
			 ,@NombrePC
			 ,@DireccionIP
			 ,@NombrePuerto
			 ,@InicialModulo
			 ,@NoCaracterModulo
			 ,@InicialTransporte
			 ,@NoCaracterTransporte
			 ,@InicialBoletasBruto
			 ,@NoCaracterBoletasBruto
			 ,@InicialBoletasTara
			 ,@NoCaracterBoletasTara
			 ,@InicialBoletasNeto
			 ,@NoCaracterBoletasNeto
			 ,@InicialPacas
			 ,@NoCaracteresPacas
			 ,@TextoCadenaPesoModulos
			 ,@TextoCadenaPesoPacas
			 ,@IdSerieBanxico
			 ,@CampoValorBanxico
			 ,@PosicionValorBanxico
			 ,@LongitudValorBanxico
			 ,@sitiobanxico) 
		as source 
			 (IdConfiguracion
			 ,NombrePC
			 ,DireccionIP
			 ,NombrePuerto
			 ,InicialModulo
			 ,NoCaracterModulo
			 ,InicialTransporte
			 ,NoCaracterTransporte
			 ,InicialBoletasBruto
			 ,NoCaracterBoletasBruto
			 ,InicialBoletasTara
			 ,NoCaracterBoletasTara
			 ,InicialBoletasNeto
			 ,NoCaracterBoletasNeto
			 ,InicialPacas
			 ,NoCaracteresPacas
			 ,TextoCadenaPesoModulos
			 ,TextoCadenaPesoPacas
			 ,IdSerieBanxico
			 ,CampoValorBanxico
			 ,PosicionValorBanxico
			 ,LongitudValorBanxico
			 ,SitioBanxico)
ON (target.IdConfiguracion = source.IdConfiguracion)
WHEN MATCHED THEN
UPDATE SET   NombrePC =	source.NombrePC
			,DireccionIP = source.DireccionIP
			,NombrePuerto = source.NombrePuerto
			,InicialModulo = source.InicialModulo
			,NoCaracterModulo = source.NoCaracterModulo
			,InicialTransporte = source.InicialTransporte
			,NoCaracterTransporte = source.NoCaracterTransporte
			,InicialBoletasBruto = source.InicialBoletasBruto
			,NoCaracterBoletasBruto	= source.NoCaracterBoletasBruto
			,InicialBoletasTara	= source.InicialBoletasTara
			,NoCaracterBoletasTara = source.NoCaracterBoletasTara
			,InicialBoletasNeto	= source.InicialBoletasNeto
			,NoCaracterBoletasNeto = source.NoCaracterBoletasNeto
			,InicialPacas = source.InicialPacas
			,NoCaracteresPacas = source.NoCaracteresPacas
			,TextoCadenaPesoModulos	= source.TextoCadenaPesoModulos
			,TextoCadenaPesoPacas = source.TextoCadenaPesoPacas
			,IdSerieBanxico	= source.IdSerieBanxico
			,CampoValorBanxico = source.CampoValorBanxico
			,PosicionValorBanxico = source.PosicionValorBanxico
			,LongitudValorBanxico = source.LongitudValorBanxico
			,SitioBanxico = source.sitiobanxico
WHEN NOT MATCHED THEN
INSERT (NombrePC
	   ,DireccionIP
	   ,NombrePuerto
	   ,InicialModulo
	   ,NoCaracterModulo
	   ,InicialTransporte
	   ,NoCaracterTransporte
	   ,InicialBoletasBruto
	   ,NoCaracterBoletasBruto
	   ,InicialBoletasTara
	   ,NoCaracterBoletasTara
	   ,InicialBoletasNeto
	   ,NoCaracterBoletasNeto
	   ,InicialPacas
	   ,NoCaracteresPacas
	   ,TextoCadenaPesoModulos
	   ,TextoCadenaPesoPacas
	   ,IdSerieBanxico
	   ,CampoValorBanxico
	   ,PosicionValorBanxico
	   ,LongitudValorBanxico
	   ,SitioBanxico)
VALUES (source.NombrePC
       ,source.DireccionIP
	   ,source.NombrePuerto
	   ,source.InicialModulo
	   ,source.NoCaracterModulo
	   ,source.InicialTransporte
	   ,source.NoCaracterTransporte
	   ,source.InicialBoletasBruto
	   ,source.NoCaracterBoletasBruto
	   ,source.InicialBoletasTara
	   ,source.NoCaracterBoletasTara
	   ,source.InicialBoletasNeto
	   ,source.NoCaracterBoletasNeto
	   ,source.InicialPacas
	   ,source.NoCaracteresPacas
	   ,source.TextoCadenaPesoModulos
	   ,source.TextoCadenaPesoPacas
	   ,source.IdSerieBanxico
	   ,source.CampoValorBanxico
	   ,source.PosicionValorBanxico
	   ,source.LongitudValorBanxico
	   ,source.SitioBanxico);
		SET @IdConfiguracion = SCOPE_IDENTITY()
END
RETURN  @IdConfiguracion