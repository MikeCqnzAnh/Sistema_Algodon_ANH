CREATE procedure sp_ExistePaqueteHVI
@LotID int 
as 
if exists (select lotID from HVIEncabezado where  lotID = @LotID)
	begin
		Select 1 ExistePaquete,IdHviEnc from HVIEncabezado where  lotID = @LotID 
	end
else
	begin
		select 0 ExistePaquete, 0 as IdHviEnc
	end
