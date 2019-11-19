Create Procedure Sp_ConsultaPacasFaltantes
@IdPlanta int ,
@RangoInicial int,
@RangoFinal int 
as
IF OBJECT_ID('tempdb..#Fuente') is not null
	begin
		DROP TABLE #Fuente
	end
		CREATE TABLE #Fuente (numero int)
	
--declare @RangoInicial int,@RangoFinal int
--set @RangoInicial = @PacaInicial
--set @RangoFinal = @PacaFinal
IF @RangoInicial > 0
	BEGIN 
		INSERT INTO #Fuente 
		select FolioCIA 
		from ProduccionDetalle 
		where FolioCIA >= @RangoInicial and FolioCIA <= @RangoFinal
		order by FolioCIA
	END
ELSE IF @RangoInicial > 0 AND @IdPlanta > 0
	BEGIN
		INSERT INTO #Fuente 
		select FolioCIA 
		from ProduccionDetalle 
		where FolioCIA >= @RangoInicial and FolioCIA <= @RangoFinal AND IdPlantaOrigen = @IdPlanta
		order by FolioCIA
	END
ELSE if @RangoInicial = 0 and @RangoFinal = 0 and @IdPlanta = 0
	BEGIN 
		INSERT INTO #Fuente 
		select FolioCIA 
		from ProduccionDetalle 
		order by FolioCIA
		 
		set @RangoInicial = (select min(numero) from #Fuente)
		set @RangoFinal = (select max(numero) from #Fuente)
	END
SET NOCOUNT ON
-- Creo mi tabla de soporte
IF OBJECT_ID('tempdb..#Rangos') is not null
	begin
		DROP TABLE #Rangos 
	end

		CREATE TABLE #Rangos (numero int)
	
INSERT INTO #Rangos values (@RangoInicial)
WHILE (SELECT ISNULL(MAX(numero),0) FROM #Rangos) < @RangoFinal
	BEGIN
		INSERT INTO #Rangos
		SELECT ISNULL(MAX(numero),0)+1 FROM #Rangos 
		CONTINUE
	END
SELECT #Rangos.numero FROM #Rangos FULL JOIN #Fuente ON #Rangos.numero = #Fuente.numero
WHERE #Fuente.numero IS NULL
order by numero