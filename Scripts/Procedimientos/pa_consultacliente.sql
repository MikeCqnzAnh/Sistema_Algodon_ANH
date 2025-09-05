alter PROCEDURE pa_consultacliente
    @idcliente INT = 0,
    @nombre NVARCHAR(100) = ''
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        Idcliente,
        nombre,
		CorreoFisica
    FROM Clientes
    WHERE
        (@idcliente > 0 AND Idcliente = @idcliente)
        OR (@idcliente = 0 AND @nombre <> '' AND nombre LIKE '%' + @nombre + '%')
        OR (@idcliente = 0 AND @nombre = '')
    ORDER BY nombre;
END
