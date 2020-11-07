alter Procedure Sp_ConsultaBitacora
@FechaInicio date ,
@FechaFin date,
@Usuario varchar(15),
@Modulo varchar(50),
@Operacion varchar(100)
as
if @FechaInicio = convert(date,getdate()) and @Usuario = '' and @Modulo = '' and @Operacion = ''
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
		   Observaciones,
		   BaseDeDatos 
	from BitacoraSistema 
	where convert(date,fecha) between DATEADD(day,-1, convert(date,getdate())) and convert(date,getdate())
	order by IdBitacora desc 
end
else if @FechaInicio = convert(date,getdate()) and @Usuario <> '' and @Modulo = '' and @Operacion = ''
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
		   Observaciones,
		   BaseDeDatos 
	from BitacoraSistema 
	where convert(date,fecha) between DATEADD(day,-1, convert(date,getdate())) and convert(date,getdate()) and Usuario = @Usuario
	order by IdBitacora desc 
end
else if @FechaInicio = convert(date,getdate()) and @Usuario = '' and @Modulo <> '' and @Operacion = ''
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
		   Observaciones,
		   BaseDeDatos 
	from BitacoraSistema 
	where convert(date,fecha) between DATEADD(day,-1, convert(date,getdate())) and convert(date,getdate()) and Modulo = @Modulo
	order by IdBitacora desc 
end
else if @FechaInicio = convert(date,getdate()) and @Usuario = '' and @Modulo = '' and @Operacion <> ''
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
		   Observaciones,
		   BaseDeDatos 
	from BitacoraSistema 
	where convert(date,fecha) between DATEADD(day,-1, convert(date,getdate())) and convert(date,getdate()) and Operacion = @Operacion
	order by IdBitacora desc 
end
else if @FechaInicio < convert(date,getdate()) and @Usuario <> '' and @Modulo = '' and @Operacion = ''
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
		   Observaciones,
		   BaseDeDatos 
	from BitacoraSistema 
	where convert(date,fecha) <= @FechaFin and convert(date,fecha) >=  @FechaInicio and Usuario = @Usuario
	order by IdBitacora desc 
end
else if @FechaInicio < convert(date,getdate()) and @Usuario = '' and @Modulo <> '' and @Operacion = ''
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
		   Observaciones,
		   BaseDeDatos 
	from BitacoraSistema 
	where convert(date,fecha) <= @FechaFin and convert(date,fecha) >=  @FechaInicio and Modulo = @Modulo
	order by IdBitacora desc 
end
else if @FechaInicio < convert(date,getdate()) and @Usuario = '' and @Modulo = '' and @Operacion <> ''
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
		   Observaciones,
		   BaseDeDatos 
	from BitacoraSistema 
	where convert(date,fecha) <= @FechaFin and convert(date,fecha) >=  @FechaInicio and Operacion = @Operacion
	order by IdBitacora desc 
end
else if @FechaInicio < convert(date,getdate()) and @Usuario = '' and @Modulo = '' and @Operacion = ''
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
		   Observaciones,
		   BaseDeDatos 
	from BitacoraSistema 
	where convert(date,fecha) <= @FechaFin and convert(date,fecha) >=  @FechaInicio 
	order by IdBitacora desc 
end