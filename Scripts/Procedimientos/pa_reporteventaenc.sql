CREATE procedure pa_reporteventaenc
@idventa int
as
BEGIN
    SET NOCOUNT ON;
    SELECT 
        vp.idventa,
        vp.idplanta,
        vp.idcomprador,
        cl.Nombre,
        vp.idcontrato,
        vp.tara,
        vp.checktara,
        vp.totalpacas,
        vp.subtotal,
        vp.castigomic,
        vp.castigoresistencia,
        vp.castigouhml,
        vp.castigoui,
        vp.deduccion,
        vp.totalprecio,
        vp.fechacreacion,
        vp.fechaactualizacion,
        vp.idestatus,
        CASE 
            WHEN vp.idestatus = 0 THEN 'Cancelado'
            WHEN vp.idestatus = 1 THEN 'Activo'
            WHEN vp.idestatus = 2 THEN 'Cerrado'
        END AS estatus,
		cc.IdUnidadPeso,
		up.Descripcion as Unidad,
		up.ValorConversion,
		cc.PrecioQuintal,
		cc.Puntos
    FROM ventapacasenc vp
    INNER JOIN Compradores cl ON vp.idcomprador = cl.IdComprador
	inner join ContratoVenta cc on vp.idcontrato = cc.IdContratoAlgodon
	inner join UnidadPesoVenta up on cc.IdUnidadPeso = up.IdUnidadPeso
    WHERE vp.idventa = @idventa;
END;