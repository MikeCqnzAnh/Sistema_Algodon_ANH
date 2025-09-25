CREATE Procedure Pa_ConsultaLotesPacas
@IdComprador int,
@Nolote varchar(15),
@IdPlanta int,
@SinComprador bit,
@SinLote bit,
@Sel bit = 0
as
if @IdComprador = 0 and @NoLote ='' and @IdPlanta = 0 and @SinComprador = 0 and @SinLote = 0
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
end
else if @IdComprador = 0 and @NoLote ='' and @IdPlanta = 0 and @SinComprador = 1 and @SinLote = 0
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	where co.Nombre is null
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
end
else if @IdComprador = 0 and @NoLote ='' and @IdPlanta > 0 and @SinComprador = 1 and @SinLote = 0
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	where co.Nombre is null and pd.idplantaorigen = @IdPlanta
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
end
else if @IdComprador = 0 and @NoLote ='' and @IdPlanta > 0 and @SinComprador = 0 and @SinLote = 1
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	where pd.IdLote is null and pd.idplantaorigen = @IdPlanta
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
end
else if @IdComprador = 0 and @NoLote ='' and @IdPlanta = 0 and @SinComprador = 0 and @SinLote = 1
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	where pd.IdLote is null
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
end
else if @IdComprador = 0 and @NoLote ='' and @IdPlanta > 0
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	where pd.IdPlantaOrigen = @IdPlanta
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
end
else if @IdComprador > 0 and @Nolote = '' and @IdPlanta = 0
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	where vp.IdComprador = @IdComprador
	--and pd.IdSalidaEncabezado is not null 
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
end
else if @IdComprador > 0 and @Nolote = '' and @IdPlanta > 0
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	where vp.IdComprador = @IdComprador and pd.IdPlantaOrigen = @IdPlanta
	--and pd.IdSalidaEncabezado is not null 
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
end
else if @IdComprador = 0 and @Nolote <> '' and @IdPlanta = 0
begin
	IF @Nolote <> 'SIN LOTE'
	BEGIN
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	where lc.Nolote = @Nolote
	--and pd.IdSalidaEncabezado is not null 
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
	END
	ELSE
	BEGIN
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	where lc.Nolote IS NULL
	--and pd.IdSalidaEncabezado is not null 
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
	END
end
else if @IdComprador > 0 and @Nolote <> '' and @IdPlanta = 0
begin
	IF @Nolote <> 'SIN LOTE'
	BEGIN
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	where vp.IdComprador = @IdComprador and pd.Nolote = @Nolote
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
	END
	ELSE 
	BEGIN
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	where vp.IdComprador = @IdComprador and lc.Nolote IS NULL
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
	END

end
else if @IdComprador > 0 and @Nolote <> '' and @IdPlanta > 0
begin
	IF @Nolote <> 'SIN LOTE'
	BEGIN
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	where vp.IdComprador = @IdComprador and lc.Nolote = @Nolote and pd.idplantaorigen = @idplanta
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
	END
	ELSE 
	BEGIN
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(lc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(pd.BaleID) AS Pacas
		  ,isnull(Sum(pd.Kilos),0) as Kilos
		  ,isnull(pd.IdPaqueteEncabezado,0) as IdPaquete
		  ,isnull(pd.idlote ,0) as IdLote
		  ,ISNULL(pd.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(pd.IdSalidaEncabezado,0) as IdSalida
	from PaqueteEncabezado vp right join ProduccionDetalle pd on vp.IdPaquete = pd.IdPaqueteEncabezado
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on pd.IdPlantaOrigen = pl.idplanta
					   left join Lotesenc lc on lc.idlote = pd.IdLote
	where vp.IdComprador = @IdComprador and lc.Nolote IS NULL and pd.idplantaorigen = @idplanta
	group by pd.IdPaqueteEncabezado,lc.NoLote,pd.IdLote,co.nombre,pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by pd.IdEmbarqueEncabezado,pd.IdSalidaEncabezado,lc.NoLote,co.Nombre--,pd.BaleID
	END

end