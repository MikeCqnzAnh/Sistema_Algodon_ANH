Create Procedure Sp_InsertarConfiguracionBanxico
@idconfiguracionbanxico int output,
@IdSerieBanxico varchar(10),
@CampoValorBanxico Varchar(10),
@PosicionValorBanxico int,
@LongitudValorBanxico int,
@SitioBanxico varchar(max)
as
begin
set nocount on
merge dbo.ConfiguracionParametrosBanxico as target
using (select @idconfiguracionbanxico
			,@IdSerieBanxico
			,@CampoValorBanxico
			,@PosicionValorBanxico
			,@LongitudValorBanxico
			,@SitioBanxico
			) 
		as source 
			(IdConfiguracionBanxico
			,IdSerieBanxico
			,CampoValorBanxico
			,PosicionValorBanxico
			,LongitudValorBanxico
			,SitioBanxico
			)
ON (target.IdConfiguracionBanxico = source.IdConfiguracionBanxico)
WHEN MATCHED THEN
UPDATE SET   IdSerieBanxico =	source.IdSerieBanxico
			,CampoValorBanxico = source.CampoValorBanxico
			,PosicionValorBanxico = source.PosicionValorBanxico
			,LongitudValorBanxico = source.LongitudValorBanxico
			,SitioBanxico = source.SitioBanxico
	
WHEN NOT MATCHED THEN
INSERT (IdSerieBanxico
	   ,CampoValorBanxico
	   ,PosicionValorBanxico
	   ,LongitudValorBanxico
	   ,SitioBanxico
		)
VALUES (source.IdSerieBanxico
       ,source.CampoValorBanxico
	   ,source.PosicionValorBanxico
	   ,source.LongitudValorBanxico
		,source.SitioBanxico
		);
		SET @idconfiguracionbanxico = SCOPE_IDENTITY()
END
RETURN  @idconfiguracionbanxico
