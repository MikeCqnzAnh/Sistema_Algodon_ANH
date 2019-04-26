CREATE PROC Sp_ConsultaConfiguracionParametros
@IdConfiguracion int,
@DireccionIP varchar(15)
as
SELECT [IdConfiguracion]
      ,[NombrePC]
      ,[DireccionIP]
      ,[NombrePuerto]
      ,[InicialModulo]
      ,[NoCaracterModulo]
      ,[InicialTransporte]
      ,[NoCaracterTransporte]
      ,[InicialBoletasBruto]
      ,[NoCaracterBoletasBruto]
      ,[InicialBoletasTara]
      ,[NoCaracterBoletasTara]
      ,[InicialBoletasNeto]
      ,[NoCaracterBoletasNeto]
      ,[InicialPacas]
      ,[NoCaracteresPacas]
      ,[TextoCadenaPesoModulos]
      ,[TextoCadenaPesoPacas]
      ,[IdSerieBanxico]
      ,[CampoValorBanxico]
      ,[PosicionValorBanxico]
      ,[LongitudValorBanxico]
	  ,[SitioBanxico]
FROM CONFIGURACIONPARAMETROS
WHERE DireccionIP = @DireccionIP or idconfiguracion = @IdConfiguracion