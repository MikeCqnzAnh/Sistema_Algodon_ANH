alter proc Sp_ActualizaBoletaPeso
@IdBoleta int,
@NoTransporte int,
@FechaEntrada datetime,
@FechaSalida datetime,
@Bruto float,
@Tara float,
@Total float,
@FlagRevisada bit,
@FlagCancelada bit
as
update OrdenTrabajoDetalle
set NoTransporte = @NoTransporte,
	FechaEntrada = @FechaEntrada,
	FechaSalida = @FechaSalida,
	Bruto = @Bruto,
	Tara = @Tara,
	Total = @Total,
	FlagCancelada = @FlagCancelada,
	FlagRevisada = @FlagRevisada
where IdBoleta = @IdBoleta
