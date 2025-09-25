CREATE PROCEDURE Pa_ConsultaPacasporlote
    @IdComprador INT,
    @Nolote VARCHAR(15),
    @IdPlanta INT,
    @SinComprador BIT,
    @SinLote BIT,
    @Sel BIT = 0
AS
BEGIN
    SELECT 
        ISNULL(pe.idComprador,0) AS idcomprador,
        ISNULL(co.Nombre,'SIN COMPRADOR') AS Nombre,
        ISNULL(lc.Nolote,'SIN LOTE') AS NoLote,
        pl.Descripcion AS Planta,
        pd.BaleID,
        pd.Kilos AS kilosneto,
        ISNULL(pd.kilosventa,0) AS kilosventa,
        ISNULL(pd.IdPaqueteEncabezado,0) AS IdPaquete,
        ISNULL(pd.IdVentaEnc,0) AS IdVenta,
        ISNULL(pd.IdLote,0) AS IdLote,	   
        ISNULL(pd.IdEmbarqueEncabezado,0) AS IdEmbarque,
        ISNULL(pd.IdSalidaEncabezado,0) AS IdSalida
    FROM ProduccionDetalle pd
    LEFT JOIN PaqueteEncabezado pe ON pd.IdPaqueteEncabezado = pe.IdPaquete
    LEFT JOIN Compradores co ON pe.idComprador = co.IdComprador
    LEFT JOIN Lotesenc lc ON pd.IdLote = lc.idlote
    LEFT JOIN Plantas pl ON pd.IdPlantaOrigen = pl.IdPlanta
    WHERE 
        (@IdComprador = 0 OR pe.idComprador = @IdComprador)
        AND (@IdPlanta = 0 OR pd.IdPlantaOrigen = @IdPlanta)
        AND (
             (@Nolote = '' AND @SinLote = 0) 
             OR (lc.Nolote = @Nolote AND @Nolote <> '' AND @Nolote <> 'SIN LOTE')
             OR (lc.Nolote IS NULL AND @SinLote = 1)
        )
        AND (
             (@SinComprador = 0) 
             OR (co.Nombre IS NULL AND @SinComprador = 1)
        )
    ORDER BY lc.NoLote, co.Nombre, pd.IdEmbarqueEncabezado, pd.IdSalidaEncabezado;
END
GO
