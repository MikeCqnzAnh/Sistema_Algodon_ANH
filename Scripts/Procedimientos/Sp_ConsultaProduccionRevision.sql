Create Procedure Sp_ConsultaProduccionRevision
@IdProduccion int,
@IdOrdenTrabajo int,
@Nombre varchar(30)
as
if @idproduccion > 0 
	begin
		select penc.IdProduccion
			  ,penc.IdOrdenTrabajo
			  ,penc.IdPlantaOrigen
			  ,pl.Descripcion as Planta
			  ,penc.IdCliente
			  ,cl.Nombre
			  ,count(pdet.foliocia) as CantidadPacas
		from Produccion penc left join Producciondetalle pdet on penc.IdProduccion = pdet.IdProduccion and penc.IdOrdenTrabajo = pdet.IdOrdenTrabajo and penc.idplantaorigen = pdet.idplantaorigen
							 inner join Clientes cl on penc.idcliente = cl.idcliente
							 inner join Plantas pl on penc.idplantaorigen = pl.idplanta
		where penc.IdProduccion = @idproduccion
		group by penc.IdProduccion
				,penc.IdOrdenTrabajo
				,penc.IdPlantaOrigen
				,pl.Descripcion
				,penc.idcliente
				,cl.Nombre
		order by penc.idproduccion
	end
else if @IdOrdenTrabajo > 0
	begin
		select penc.IdProduccion
			  ,penc.IdOrdenTrabajo
			  ,penc.IdPlantaOrigen
			  ,pl.Descripcion as Planta
			  ,penc.IdCliente
			  ,cl.Nombre
			  ,count(pdet.foliocia) as CantidadPacas
		from Produccion penc left join Producciondetalle pdet on penc.IdProduccion = pdet.IdProduccion and penc.IdOrdenTrabajo = pdet.IdOrdenTrabajo and penc.idplantaorigen = pdet.idplantaorigen
							 inner join Clientes cl on penc.idcliente = cl.idcliente
							 inner join Plantas pl on penc.idplantaorigen = pl.idplanta
		where penc.IdOrdenTrabajo = @IdOrdenTrabajo
		group by penc.IdProduccion
				,penc.IdOrdenTrabajo
				,penc.IdPlantaOrigen
				,pl.Descripcion
				,penc.idcliente
				,cl.Nombre
		order by penc.idproduccion
	end
else if @Nombre <> ''
	begin
		select penc.IdProduccion
			  ,penc.IdOrdenTrabajo
			  ,penc.IdPlantaOrigen
			  ,pl.Descripcion as Planta
			  ,penc.IdCliente
			  ,cl.Nombre
			  ,count(pdet.foliocia) as CantidadPacas
		from Produccion penc left join Producciondetalle pdet on penc.IdProduccion = pdet.IdProduccion and penc.IdOrdenTrabajo = pdet.IdOrdenTrabajo and penc.idplantaorigen = pdet.idplantaorigen
							 inner join Clientes cl on penc.idcliente = cl.idcliente
							 inner join Plantas pl on penc.idplantaorigen = pl.idplanta
		where cl.Nombre like '%'+@Nombre+'%'
		group by penc.IdProduccion
				,penc.IdOrdenTrabajo
				,penc.IdPlantaOrigen
				,pl.Descripcion
				,penc.idcliente
				,cl.Nombre
		order by penc.idproduccion
	end
else
	begin	
		select penc.IdProduccion
			  ,penc.IdOrdenTrabajo
			  ,penc.IdPlantaOrigen
			  ,pl.Descripcion as Planta
			  ,penc.IdCliente
			  ,cl.Nombre
			  ,count(pdet.foliocia) as CantidadPacas
		from Produccion penc left join Producciondetalle pdet on penc.IdProduccion = pdet.IdProduccion and penc.IdOrdenTrabajo = pdet.IdOrdenTrabajo and penc.idplantaorigen = pdet.idplantaorigen
							 inner join Clientes cl on penc.idcliente = cl.idcliente
							 inner join Plantas pl on penc.idplantaorigen = pl.idplanta
		group by penc.IdProduccion
				,penc.IdOrdenTrabajo
				,penc.IdPlantaOrigen
				,pl.Descripcion
				,penc.idcliente
				,cl.Nombre
		order by penc.idproduccion
	end