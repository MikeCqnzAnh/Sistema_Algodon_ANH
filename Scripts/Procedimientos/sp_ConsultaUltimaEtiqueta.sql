CREATE procedure sp_ConsultaUltimaEtiqueta  
--declare   
@Etiqueta int,  
@IdPlantaOrigen int  
as  
declare  
@Secuencia int = (select secuencia + 1   
				  from [FolioEtiqueta]   
				  where idplantaorigen = @IdPlantaOrigen)   
  
if not exists (select idplantaorigen   
			   from [FolioEtiqueta]   
			   where IdplantaOrigen = @IdPlantaOrigen )  
begin  
  INSERT INTO [FolioEtiqueta] (Etiqueta,Secuencia,IdPlantaOrigen,Observacion)   
  values (@Etiqueta,@Etiqueta+1,@IdPlantaOrigen,'')  
end  
else   
BEGIN  
while exists (select foliocia  from [ProduccionDetalle] where foliocia = @secuencia AND IdplantaOrigen = @IdPlantaOrigen)  
 begin  
 set @secuencia = @secuencia +1  
 end   
    UPDATE [FolioEtiqueta]  
    SET    Etiqueta  = @etiqueta,  
        Secuencia = @secuencia  
    WHERE  IdPlantaOrigen = @IdPlantaOrigen  
 END