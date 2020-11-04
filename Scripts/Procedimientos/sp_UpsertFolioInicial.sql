alter procedure sp_UpsertFolioInicial
@IdPlantaOrigen int,
@FolioInicial bigint
as
if not exists (select idplantaorigen   
      from [FolioEtiqueta]   
      where IdplantaOrigen = @IdPlantaOrigen )  
begin  
  INSERT INTO [FolioEtiqueta] (Etiqueta,Secuencia,IdPlantaOrigen,Observacion,FolioInicial)   
  values (@FolioInicial-1,@FolioInicial,@IdPlantaOrigen,'',@FolioInicial)  
end  
else   
BEGIN   
    UPDATE [FolioEtiqueta]  
    SET    Etiqueta  = @FolioInicial -1,  
           Secuencia = @FolioInicial,
		   FolioInicial = @FolioInicial  
    WHERE  IdPlantaOrigen = @IdPlantaOrigen  
END