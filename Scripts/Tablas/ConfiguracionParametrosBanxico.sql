CREATE TABLE [dbo].[ConfiguracionParametrosBanxico]
(
	 [IdConfiguracionBanxico] int primary key identity(1,1)
	,[IdSerieBanxico] [nchar](10) NULL
	,[CampoValorBanxico] [nchar](10) NULL
	,[PosicionValorBanxico] [int] NULL
	,[LongitudValorBanxico] [int] NULL
	,[SitioBanxico] [varchar](max) NULL
)