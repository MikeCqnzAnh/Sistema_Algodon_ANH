alter proc sp_ExistePacaHVI
@FolioCIA bigint  ,
@IdPlanta int 
as 
if exists (select hvid.BaleID from HVIEncabezado hvie right join HVIDetalle HVId on hvie.IdHviEnc = HVId.IdHviEnc where hvie.IdPlanta = @IdPlanta and hvid.BaleID = @FolioCIA)
	begin
		Select 1 ExistePaca,hvie.IdHviEnc from HVIEncabezado hvie right join HVIDetalle HVId on hvie.IdHviEnc = HVId.IdHviEnc where hvie.IdPlanta = @IdPlanta and hvid.BaleID = @FolioCIA
	end
else
	begin
		select 0 ExistePaca,0 as IdHviEnc
	end