CREATE PROCEDURE pa_consultacompraenc
    @busqueda NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        cp.idcompra,
        cp.idplanta,
        cp.idproductor,
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
    FROM comprapacasenc cp
    INNER JOIN Clientes cl ON cp.idproductor = cl.IdCliente
    WHERE 
        (@busqueda IS NULL OR @busqueda = '') 
        OR (cl.Nombre LIKE '%' + @busqueda + '%'
            OR cp.idcompra LIKE '%' + @busqueda + '%'
            OR cp.idcontrato LIKE '%' + @busqueda + '%');
END;
