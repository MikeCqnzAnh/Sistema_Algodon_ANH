create procedure sp_ConContComp
@IdComprador int
as
SELECT a.IdContratoAlgodon,
       a.Pacas,
	   a.PrecioQuintal,
	   a.FechaCreacion as Fecha
FROM ContratoVenta a
where a.IdEstatus = 1
and a.IdComprador = @IdComprador