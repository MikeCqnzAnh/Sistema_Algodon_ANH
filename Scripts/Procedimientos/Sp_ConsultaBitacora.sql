create Procedure Sp_ConsultaBitacora
@FechaInicio date ,
@FechaFin date 
as
if @FechaInicio = convert(date,getdate())
begin
	select IdBitacora,
		   Fecha,
		   Computadora,
		   DireccionIP,
		   IdUsuario,
		   Usuario,
		   Modulo,
		   Opcion,
		   Operacion,
		   Observaciones 
	from BitacoraSistema 
	where convert(date,fecha) between DATEADD(day,-1, convert(date,getdate())) and convert(date,getdate())
	order by IdBitacora desc 
end
else if @FechaInicio < convert(date,getdate())
begin
	select IdBitacora,
		   Fecha,
		   Computadora,
		   DireccionIP,
		   IdUsuario,
		   Usuario,
		   Modulo,
		   Opcion,
		   Operacion,
		   Observaciones 
	from BitacoraSistema 
	where convert(date,fecha) <= @FechaFin and convert(date,fecha) >=  @FechaInicio
	order by IdBitacora desc 
end