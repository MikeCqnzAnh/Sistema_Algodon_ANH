create procedure Sp_ConsultaConfiguracionBanxico
as
Select top 1 idconfiguracionbanxico
	  ,IdSerieBanxico
	  ,CampoValorBanxico
	  ,PosicionValorBanxico
	  ,LongitudValorBanxico
	  ,SitioBanxico
from ConfiguracionParametrosBanxico
		