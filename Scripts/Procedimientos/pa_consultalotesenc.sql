create PROCEDURE pa_consultalotesenc
@busqueda NVARCHAR(30)
AS
BEGIN
    SELECT 
        le.idlote,
		le.nolote,
        le.idcomprador,
        cp.Nombre,
        le.ubicacion,
        le.observaciones,
        le.totalpacas,
        le.totalkilos,
        le.fechacreacion,
        le.fechaactualizacion,
        le.idestatus,
        CASE 
            WHEN le.idestatus = 0 THEN 'Inactivo' 
            WHEN le.idestatus = 1 THEN 'Activo'
        END AS estatus
    FROM lotesenc le 
    INNER JOIN Compradores cp 
        ON le.idcomprador = cp.IdComprador
    WHERE 
        -- Buscar por idlote si el valor es numérico
        (TRY_CAST(@busqueda AS INT) IS NOT NULL 
         AND le.idlote = TRY_CAST(@busqueda AS INT))
        OR
        -- Buscar por idcomprador si es numérico
        (TRY_CAST(@busqueda AS INT) IS NOT NULL 
         AND le.idcomprador = TRY_CAST(@busqueda AS INT))
        OR
        -- Buscar por nombre si es texto
        (cp.Nombre LIKE '%' + @busqueda + '%')
		OR
		(le.nolote like '%' + @busqueda + '%');
END
