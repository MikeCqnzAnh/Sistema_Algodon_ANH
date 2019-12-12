alter proc Sp_ActualizaBoletaPeso
@IdBoleta int,
@Bruto float,
@Tara float,
@Total float,
@FlagRevisada bit,
@FlagCancelada bit
as
update OrdenTrabajoDetalle
set Bruto = @Bruto,
	Tara = @Tara,
	Total = @Total,
	FlagCancelada = @FlagCancelada,
	FlagRevisada = @FlagRevisada
where IdBoleta = @IdBoleta
