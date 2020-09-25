alter Procedure Sp_InsertarConfiguracionBanxico
@idconfiguracionbanxico int output,
@Sitio varchar(max),
@Serie Varchar(10),
@Token varchar(max)
as
begin
set nocount on
merge dbo.ConfiguracionParametrosBanxico as target
using (select @idconfiguracionbanxico
			,@Sitio
			,@Serie
			,@Token
			) 
		as source 
			(IdConfiguracionBanxico
			,Sitio
			,Serie
			,Token
			)
ON (target.IdConfiguracionBanxico = source.IdConfiguracionBanxico)
WHEN MATCHED THEN
UPDATE SET   Sitio = source.Sitio
			,Serie = source.Serie
			,Token = source.Token			
	
WHEN NOT MATCHED THEN
INSERT (Sitio
	   ,Serie
	   ,Token
		)
VALUES (source.Sitio
       ,source.Serie
	   ,source.Token
		);
		SET @idconfiguracionbanxico = SCOPE_IDENTITY()
END
RETURN  @idconfiguracionbanxico
