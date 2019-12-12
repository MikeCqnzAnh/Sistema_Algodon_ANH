create proc ActualizaBoletaPeso
@IdBoleta int,
@Bruto float,
@Tara float,
@Total float
as
update BoletasPorOrden
set Bruto = @Bruto,
	Tara = @Tara,
	Total = @Total
where IdBoleta = @IdBoleta