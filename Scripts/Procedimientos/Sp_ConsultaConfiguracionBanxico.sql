create procedure Sp_ConsultaConfiguracionBanxico
as
Select top 1 idconfiguracionbanxico
	  ,Sitio
	  ,Serie
	  ,Token	  
from ConfiguracionParametrosBanxico
		