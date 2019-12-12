Create Procedure Sp_ConsultaFechaTipoCambio
@Abreviacion varchar(6),
@FechaHoy date
as
if @FechaHoy > (select cast(FechaActualizacion as date) As FechaActualizacion from Moneda where Abreviacion = @Abreviacion)
begin
	Select 1 as Respuesta
end
else if @FechaHoy <= (select cast(FechaActualizacion as date) As FechaActualizacion from Moneda where Abreviacion = @Abreviacion)
begin
	Select 0 as Respuesta
end
