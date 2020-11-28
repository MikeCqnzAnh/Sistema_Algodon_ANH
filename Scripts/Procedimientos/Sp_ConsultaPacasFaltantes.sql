alter Procedure Sp_ConsultaPacasFaltantes
@IdPlanta int  ,
@RangoInicial bigint ,
@RangoFinal bigint ,
@Valor bigint = 0
as
IF OBJECT_ID('tempdb..#Fuente') is not null
	begin
		DROP TABLE #Fuente
	end
		CREATE TABLE #Fuente (numero bigint)

		INSERT INTO #Fuente 
		select FolioCIA 
		from ProduccionDetalle 
		where FolioCIA >= @RangoInicial and FolioCIA <= @RangoFinal AND IdPlantaOrigen = @IdPlanta
		order by FolioCIA

SET NOCOUNT ON
-- Creo mi tabla de soporte
IF OBJECT_ID('tempdb..#Rangos') is not null
	begin
		DROP TABLE #Rangos 
	end
		CREATE TABLE #Rangos (numero bigint)
set @Valor = @RangoInicial
WHILE @valor <= @RangoFinal
	BEGIN 
		if exists (select foliocia from ProduccionDetalle where IdPlantaOrigen = @IdPlanta and FolioCIA = @Valor)
			begin
				set  @valor = @Valor + 1

				CONTINUE
			end
		else
			begin 
				INSERT INTO #Rangos(numero)
				values (@Valor)

				set  @valor = @Valor + 1
				CONTINUE
			end		
	END
SELECT #Rangos.numero FROM #Rangos FULL JOIN #Fuente ON #Rangos.numero = #Fuente.numero
WHERE #Fuente.numero IS NULL
order by numero
