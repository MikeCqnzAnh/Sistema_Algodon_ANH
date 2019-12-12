CREATE procedure sp_ConsultaPacaExistente  
--DECLARE  
@FolioCIA int ,  
@IdPlantaOrigen int ,
@IdProduccion int   
AS  
BEGIN  
DECLARE @resultado INT   
IF exists (select 1 from [dbo].[ProduccionDetalle] a where a.FolioCIA = @FolioCIA and IdPlantaOrigen = @IdPlantaOrigen and IdProduccion = @IdProduccion)  
   BEGIN  
    SET @resultado = 1  
    --PRINT @resultado  
    select (@resultado) as Resultado,idproducciondetalle,FolioCIA from [ProduccionDetalle]a where a.FolioCIA = @FolioCIA and IdPlantaOrigen = @IdPlantaOrigen and IdProduccion = @IdProduccion
   END  
  ELSE  
   BEGIN  
    SET @resultado = 0  
    --PRINT @resultado  
    select (@resultado)  as Resultado  
   END    
END 


select * from ProduccionDetalle