CREATE PROCEDURE pa_consultaventaenc
    @busqueda NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        cp.idventa,
        cp.idplanta,
        cp.idcomprador,
        cl.Nombre,
        cp.idcontrato,
        cp.tara,
        cp.checktara,
        cp.totalpacas,
        cp.subtotal,
        cp.castigomic,
        cp.castigoresistencia,
        cp.castigouhml,
        cp.castigoui,
        cp.deduccion,
        cp.totalprecio,
        cp.fechacreacion,
        cp.fechaactualizacion,
        cp.idestatus,
        CASE 
            WHEN cp.idestatus = 0 THEN 'Cancelado'
            WHEN cp.idestatus = 1 THEN 'Activo'
            WHEN cp.idestatus = 2 THEN 'Cerrado'
        END AS estatus
    FROM ventapacasenc cp
    INNER JOIN Compradores cl ON cp.idcomprador = cl.IdComprador
    WHERE 
        (@busqueda IS NULL OR @busqueda = '') 
        OR (cl.Nombre LIKE '%' + @busqueda + '%'
            OR cp.idventa LIKE '%' + @busqueda + '%'
            OR cp.idcontrato LIKE '%' + @busqueda + '%');
END;