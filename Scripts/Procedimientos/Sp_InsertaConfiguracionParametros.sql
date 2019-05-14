create procedure Sp_InsertaConfiguracionParametros
	 @IdConfiguracion [int] output
	,@NombrePC [varchar](30)
	,@DireccionIP [varchar](15)
	,@NombrePuerto [varchar](6)
	,@IndicadorID	[varchar](10)
	,@IndicadorModulo [varchar](5)
	,@IndicadorEntrada	[varchar](10)
	,@IndicadorSalida	[varchar](10)
	,@IndicadorBruto	[varchar](10)
	,@IndicadorTara	[varchar](10)
	,@IndicadorNeto	[varchar](10)
	,@IndicadorPacasBruto	[varchar](10)
	,@IndicadorPacasTara	[varchar](10)
	,@IndicadorPacasNeto	[varchar](10)
	,@PosicionID	[int]
	,@PosicionModulo [int]
	,@PosicionEntrada	[int]
	,@PosicionSalida	[int]
	,@PosicionBruto	[int]
	,@PosicionTara	[int]
	,@PosicionNeto	[int]
	,@PacasPosicionBruto	[int]
	,@PacasPosicionTara	[int]
	,@PacasPosicionNeto	[int]
	,@CaracterID	[int]
	,@CaracterModulo [int]
	,@CaracterEntrada	[int]
	,@CaracterSalida	[int]
	,@CaracterBruto	[int]
	,@CaracterTara	[int]
	,@CaracterNeto	[int]
	,@PacasCaracterBruto	[int]
	,@PacasCaracterTara	[int]
	,@PacasCaracterNeto	[int]
	,@PesoMinimoPaca [int]

as
begin
set nocount on
merge dbo.configuracionparametros as target
using (select @IdConfiguracion
			,@NombrePC
			,@DireccionIP
			,@NombrePuerto
			,@IndicadorID
			,@IndicadorModulo
			,@IndicadorEntrada
			,@IndicadorSalida
			,@IndicadorBruto
			,@IndicadorTara
			,@IndicadorNeto
			,@IndicadorPacasBruto
			,@IndicadorPacasTara
			,@IndicadorPacasNeto
			,@PosicionID
			,@PosicionModulo
			,@PosicionEntrada
			,@PosicionSalida
			,@PosicionBruto
			,@PosicionTara
			,@PosicionNeto
			,@PacasPosicionBruto
			,@PacasPosicionTara
			,@PacasPosicionNeto
			,@CaracterID
			,@CaracterModulo
			,@CaracterEntrada
			,@CaracterSalida
			,@CaracterBruto
			,@CaracterTara
			,@CaracterNeto
			,@PacasCaracterBruto
			,@PacasCaracterTara
			,@PacasCaracterNeto
			,@PesoMinimoPaca) 
		as source 
			(IdConfiguracion
			,NombrePC
			,DireccionIP
			,NombrePuerto
			,IndicadorID
			,IndicadorModulo
			,IndicadorEntrada
			,IndicadorSalida
			,IndicadorBruto
			,IndicadorTara
			,IndicadorNeto
			,IndicadorPacasBruto
			,IndicadorPacasTara
			,IndicadorPacasNeto
			,PosicionID
			,PosicionModulo
			,PosicionEntrada
			,PosicionSalida
			,PosicionBruto
			,PosicionTara
			,PosicionNeto
			,PacasPosicionBruto
			,PacasPosicionTara
			,PacasPosicionNeto
			,CaracterID
			,CaracterModulo
			,CaracterEntrada
			,CaracterSalida
			,CaracterBruto
			,CaracterTara
			,CaracterNeto
			,PacasCaracterBruto
			,PacasCaracterTara
			,PacasCaracterNeto
			,PesoMinimoPaca
)
ON (target.IdConfiguracion = source.IdConfiguracion)
WHEN MATCHED THEN
UPDATE SET   NombrePC =	source.NombrePC
			,DireccionIP = source.DireccionIP
			,NombrePuerto = source.NombrePuerto
			,IndicadorID = source.IndicadorID
			,IndicadorModulo = source.IndicadorModulo
			,IndicadorEntrada = source.IndicadorEntrada
			,IndicadorSalida = source.IndicadorSalida
			,IndicadorBruto = source.IndicadorBruto
			,IndicadorTara = source.IndicadorTara
			,IndicadorNeto = source.IndicadorNeto
			,IndicadorPacasBruto = source.IndicadorPacasBruto
			,IndicadorPacasTara = source.IndicadorPacasTara
			,IndicadorPacasNeto = source.IndicadorPacasNeto
			,PosicionID = source.PosicionID
			,PosicionModulo = source.PosicionModulo
			,PosicionEntrada = source.PosicionEntrada
			,PosicionSalida = source.PosicionSalida
			,PosicionBruto = source.PosicionBruto
			,PosicionTara = source.PosicionTara
			,PosicionNeto = source.PosicionNeto
			,PacasPosicionBruto = source.PacasPosicionBruto
			,PacasPosicionTara = source.PacasPosicionTara
			,PacasPosicionNeto = source.PacasPosicionNeto
			,CaracterID = source.CaracterID
			,CaracterModulo = source.CaracterModulo
			,CaracterEntrada = source.CaracterEntrada
			,CaracterSalida = source.CaracterSalida
			,CaracterBruto = source.CaracterBruto
			,CaracterTara = source.CaracterTara
			,CaracterNeto = source.CaracterNeto
			,PacasCaracterBruto = source.PacasCaracterBruto
			,PacasCaracterTara = source.PacasCaracterTara
			,PacasCaracterNeto = source.PacasCaracterNeto
			,PesoMinimoPaca = source.PesoMinimoPaca

WHEN NOT MATCHED THEN
INSERT (NombrePC
	   ,DireccionIP
	   ,NombrePuerto
	   ,IndicadorID
	   ,IndicadorModulo
		,IndicadorEntrada
		,IndicadorSalida
		,IndicadorBruto
		,IndicadorTara
		,IndicadorNeto
		,IndicadorPacasBruto
		,IndicadorPacasTara
		,IndicadorPacasNeto
		,PosicionID
		,PosicionModulo
		,PosicionEntrada
		,PosicionSalida
		,PosicionBruto
		,PosicionTara
		,PosicionNeto
		,PacasPosicionBruto
		,PacasPosicionTara
		,PacasPosicionNeto
		,CaracterID
		,CaracterModulo
		,CaracterEntrada
		,CaracterSalida
		,CaracterBruto
		,CaracterTara
		,CaracterNeto
		,PacasCaracterBruto
		,PacasCaracterTara
		,PacasCaracterNeto
		,PesoMinimoPaca
)
VALUES (source.NombrePC
       ,source.DireccionIP
	   ,source.NombrePuerto
	   ,source.IndicadorID
	   ,source.IndicadorModulo
		,source.IndicadorEntrada
		,source.IndicadorSalida
		,source.IndicadorBruto
		,source.IndicadorTara
		,source.IndicadorNeto
		,source.IndicadorPacasBruto
		,source.IndicadorPacasTara
		,source.IndicadorPacasNeto
		,source.PosicionID
		,source.PosicionModulo
		,source.PosicionEntrada
		,source.PosicionSalida
		,source.PosicionBruto
		,source.PosicionTara
		,source.PosicionNeto
		,source.PacasPosicionBruto
		,source.PacasPosicionTara
		,source.PacasPosicionNeto
		,source.CaracterID
		,source.CaracterModulo
		,source.CaracterEntrada
		,source.CaracterSalida
		,source.CaracterBruto
		,source.CaracterTara
		,source.CaracterNeto
		,source.PacasCaracterBruto
		,source.PacasCaracterTara
		,source.PacasCaracterNeto
		,source.PesoMinimoPaca
);
		SET @IdConfiguracion = SCOPE_IDENTITY()
END
RETURN  @IdConfiguracion