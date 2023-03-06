create procedure pa_consultaliquidaciones
@idordentrabajo int,
@nombre varchar(100)
as
if @idordentrabajo = 0 and @nombre = ''
	begin
		select lr.IdLiquidacion
			  ,lr.IdOrdenTrabajo
			  ,cl.IdCliente
			  ,cl.Nombre
			  ,lr.Fecha
			  ,lr.TotalBoletas
			  ,lr.TotalPacas
		from LiquidacionesPorRomaneaje lr inner join Clientes cl on lr.IdCliente = cl.IdCliente 
	end
else if @idordentrabajo > 0 and @nombre = ''
	begin
		select lr.IdLiquidacion
			  ,lr.IdOrdenTrabajo
			  ,cl.IdCliente
			  ,cl.Nombre
			  ,lr.Fecha
			  ,lr.TotalBoletas
			  ,lr.TotalPacas
		from LiquidacionesPorRomaneaje lr inner join Clientes cl on lr.IdCliente = cl.IdCliente 
		where lr.IdOrdenTrabajo = @idordentrabajo
	end
else if @idordentrabajo = 0 and @nombre <> ''
	begin
		select lr.IdLiquidacion
			  ,lr.IdOrdenTrabajo
			  ,cl.IdCliente
			  ,cl.Nombre
			  ,lr.Fecha
			  ,lr.TotalBoletas
			  ,lr.TotalPacas
		from LiquidacionesPorRomaneaje lr inner join Clientes cl on lr.IdCliente = cl.IdCliente 
		where cl.Nombre like '%'+@nombre+'%'
	end
else
	begin
		select lr.IdLiquidacion
			  ,lr.IdOrdenTrabajo
			  ,cl.IdCliente
			  ,cl.Nombre
			  ,lr.Fecha
			  ,lr.TotalBoletas
			  ,lr.TotalPacas
		from LiquidacionesPorRomaneaje lr inner join Clientes cl on lr.IdCliente = cl.IdCliente 
		where lr.IdOrdenTrabajo = @idordentrabajo and cl.Nombre like '%'+@nombre+'%'
	end