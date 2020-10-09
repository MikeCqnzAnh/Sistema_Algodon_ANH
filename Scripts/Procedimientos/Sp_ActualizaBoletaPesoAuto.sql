Alter proc Sp_ActualizaBoletaPesoAuto
@IdBoleta as int ,
@NoTransporte as int,
@PesoBruto as float,
@Tara as float ,
@Neto as float ,
@FechaActualizacion as datetime,
@TipoFlete as varchar(9)
as
IF @TipoFlete = 'INBOUND' and (select Bruto from [dbo].[OrdenTrabajoDetalle] a where a.IdBoleta = @IdBoleta) = 0 and (select notransporte from OrdenTrabajoDetalle where IdBoleta = @IdBoleta) = 0
BEGIN
	update [dbo].[OrdenTrabajoDetalle]
	set NoTransporte = @NoTransporte,
		Bruto = @PesoBruto,
		fechaorden = @FechaActualizacion,
		fechaEntrada = @FechaActualizacion
	where IdBoleta = @IdBoleta 

END
ELSE IF @TipoFlete = 'INBOUND' and (select Bruto from [dbo].[OrdenTrabajoDetalle] a where a.IdBoleta = @IdBoleta) <> 0 and (select NoTransporte from [dbo].[OrdenTrabajoDetalle] a where a.IdBoleta = @IdBoleta) <> @NoTransporte
BEGIN
	INSERT INTO IncidenciasBoletasPorLotes (IdBoleta,NoTransporte,Bruto,Tara,Neto,revisada,TipoFlete,FechaCreacion) values (@IdBoleta,@NoTransporte,@PesoBruto,@Tara,@Neto,0,@TipoFlete,@FechaActualizacion)
END
ELSE IF @TipoFlete = 'RECALLED' and (select Tara from [dbo].[OrdenTrabajoDetalle] a where a.IdBoleta = @IdBoleta) = 0 and (select NoTransporte from [dbo].[OrdenTrabajoDetalle] a where a.IdBoleta = @IdBoleta) = @NoTransporte
BEGIN
	update [dbo].[OrdenTrabajoDetalle]
	set Tara = @Tara,
		Total = @Neto,
		FechaSalida = @FechaActualizacion
	where IdBoleta = @IdBoleta

END
ELSE IF @TipoFlete = 'RECALLED' and (select Tara from [dbo].[OrdenTrabajoDetalle] a where a.IdBoleta = @IdBoleta) <> 0 and (select NoTransporte from [dbo].[OrdenTrabajoDetalle] a where a.IdBoleta = @IdBoleta) <> @NoTransporte
BEGIN
	INSERT INTO IncidenciasBoletasPorLotes (IdBoleta,NoTransporte,Bruto,Tara,Neto,revisada,TipoFlete,FechaCreacion) values (@IdBoleta,@NoTransporte,@PesoBruto,@Tara,@Neto,0,@TipoFlete,@FechaActualizacion)
END

if exists (select IdOrdenTrabajo from OrdenTrabajoDetalle where IdBoleta = @IdBoleta) and  @TipoFlete = 'RECALLED'
	begin
	select IdOrdenTrabajo from OrdenTrabajoDetalle where IdBoleta = @IdBoleta 
	end
else
	begin
	select 0 as IdOrdenTrabajo
	end
