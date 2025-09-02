Create procedure sp_ExistePaqueteClasificacion
@LotID int ,
@IdPlanta int
as 
if exists (select lotID from PaqueteEncabezado where IdPlanta = @IdPlanta and lotID = @LotID)
	begin
		Select 1 ExistePaquete,lotID from PaqueteEncabezado where IdPlanta = @IdPlanta and lotID = @LotID 
	end
else
	begin
		select 0 ExistePaquete, 0 as lotID
	end