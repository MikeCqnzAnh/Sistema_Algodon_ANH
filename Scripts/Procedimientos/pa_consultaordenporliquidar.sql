create procedure pa_consultaordenporliquidar
@idordentrabajo int,
@nombre varchar(100)
as
if @idordentrabajo = 0 and @nombre = ''
	begin
		select ot.IdOrdenTrabajo
			  ,ot.IdProductor
			  ,cl.Nombre
			  ,ot.RangoInicio
			  ,ot.RangoFin
			  ,ot.NumeroModulos
			  ,ot.Predio
			  ,ot.FechaCreacion 
		from OrdenTrabajo ot inner join Clientes cl on ot.IdProductor = cl.IdCliente
		where ot.IdOrdenTrabajo not in (select IdOrdenTrabajo from LiquidacionesPorRomaneaje)
	end
else if @idordentrabajo > 0 and @nombre = ''
	begin
		select ot.IdOrdenTrabajo
			  ,ot.IdProductor
			  ,cl.Nombre
			  ,ot.RangoInicio
			  ,ot.RangoFin
			  ,ot.NumeroModulos
			  ,ot.Predio
			  ,ot.FechaCreacion 
		from OrdenTrabajo ot inner join Clientes cl on ot.IdProductor = cl.IdCliente
		where ot.IdOrdenTrabajo not in (select IdOrdenTrabajo from LiquidacionesPorRomaneaje)
			  and ot.IdOrdenTrabajo = @idordentrabajo
	end
else if @idordentrabajo = 0 and @nombre <> ''
	begin
		select ot.IdOrdenTrabajo
			  ,ot.IdProductor
			  ,cl.Nombre
			  ,ot.RangoInicio
			  ,ot.RangoFin
			  ,ot.NumeroModulos
			  ,ot.Predio
			  ,ot.FechaCreacion 
		from OrdenTrabajo ot inner join Clientes cl on ot.IdProductor = cl.IdCliente
		where ot.IdOrdenTrabajo not in (select IdOrdenTrabajo from LiquidacionesPorRomaneaje)
			  and cl.Nombre like '%'+@nombre+'%'
	end
else
	begin
		select ot.IdOrdenTrabajo
			  ,ot.IdProductor
			  ,cl.Nombre
			  ,ot.RangoInicio
			  ,ot.RangoFin
			  ,ot.NumeroModulos
			  ,ot.Predio
			  ,ot.FechaCreacion 
		from OrdenTrabajo ot inner join Clientes cl on ot.IdProductor = cl.IdCliente
		where ot.IdOrdenTrabajo not in (select IdOrdenTrabajo from LiquidacionesPorRomaneaje)
			  and ot.IdOrdenTrabajo = @idordentrabajo and cl.Nombre like '%'+@nombre+'%'
	end

