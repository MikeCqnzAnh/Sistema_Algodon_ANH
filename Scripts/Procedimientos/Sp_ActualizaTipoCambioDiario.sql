Create Procedure Sp_ActualizaTipoCambioDiario
@TipoDeCambio decimal(6,4),
@Abreviacion varchar(6)
as
	Update Moneda
	set TipoDeCambio = @TipoDeCambio,
		FechaActualizacion = GETDATE()
	where Abreviacion = @Abreviacion