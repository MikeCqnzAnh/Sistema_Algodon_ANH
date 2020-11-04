alter procedure sp_ActualizaEscaneoEtiqueta
--declare   
@Etiqueta bigint,  
@IdPlantaOrigen int  
as  
declare  
@secuencia bigint = @Etiqueta +1
--@Secuencia int = (select secuencia + 1   
--				  from [FolioEtiqueta]   
--				  where idplantaorigen = @IdPlantaOrigen)   
  
if not exists (select idplantaorigen   
			   from [FolioEtiqueta]   
			   where IdplantaOrigen = @IdPlantaOrigen )  and @IdPlantaOrigen > 0
begin  
  INSERT INTO [FolioEtiqueta] (Etiqueta,Secuencia,IdPlantaOrigen,Observacion)   
  values (@Etiqueta,@Etiqueta+1,@IdPlantaOrigen,'')  
end  
else   
BEGIN  
--while exists (select foliocia  from [ProduccionDetalle] where foliocia = @secuencia AND IdplantaOrigen = @IdPlantaOrigen)  
--while exists (select foliocia  from [ProduccionDetalle] where  IdplantaOrigen = @IdPlantaOrigen) 
 --begin  
 --set @Secuencia = @Etiqueta +1  
 --end   
    UPDATE [FolioEtiqueta]  
    SET    Etiqueta  = @etiqueta,  
        Secuencia = @secuencia  
    WHERE  IdPlantaOrigen = @IdPlantaOrigen  
 END