create procedure pa_reportecompraenc
@idcompra int
as
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
        END AS estatus,
		cc.IdUnidadPeso,
		up.Descripcion as Unidad,
		up.ValorConversion,
		cc.PrecioQuintal,
		cc.Puntos
    FROM comprapacasenc cp
    INNER JOIN Clientes cl ON cp.idproductor = cl.IdCliente
	inner join ContratoCompra cc on cp.idcontrato = cc.IdContratoAlgodon
	inner join UnidadPesoVenta up on cc.IdUnidadPeso = up.IdUnidadPeso
    WHERE cp.idcompra = @idcompra;
END;