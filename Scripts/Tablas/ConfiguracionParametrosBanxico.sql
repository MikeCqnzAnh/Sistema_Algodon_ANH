CREATE TABLE [dbo].[ConfiguracionParametrosBanxico]
(
	 [IdConfiguracionBanxico] int primary key identity(1,1)
	,[Sitio] [varchar](max) NULL
	,[Serie] [varchar](15) NULL
	,[Token] [varchar](max) NULL
)