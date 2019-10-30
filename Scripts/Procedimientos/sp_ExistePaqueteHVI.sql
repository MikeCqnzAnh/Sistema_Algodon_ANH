create procedure sp_ExistePaqueteHVI
@LotID int ,
@IdPlanta int
as 
if exists (select lotID from HVIEncabezado where IdPlanta = @IdPlanta and lotID = @LotID)
	begin
		Select 1 ExistePaquete,IdHviEnc from HVIEncabezado where IdPlanta = @IdPlanta and lotID = @LotID 
	end
else
	begin
		select 0 ExistePaquete, 0 as IdHviEnc
	end
