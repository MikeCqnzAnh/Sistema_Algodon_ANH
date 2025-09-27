CREATE PROCEDURE pa_consultacomprador
    @idcomprador INT = 0,
    @nombre NVARCHAR(100) = ''
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        IdComprador,
        nombre,
		Correo
    FROM Compradores
    WHERE
        (@idcomprador > 0 AND IdComprador = @idcomprador)
        OR (@idcomprador = 0 AND @nombre <> '' AND nombre LIKE '%' + @nombre + '%')
        OR (@idcomprador = 0 AND @nombre = '')
    ORDER BY nombre;
END
