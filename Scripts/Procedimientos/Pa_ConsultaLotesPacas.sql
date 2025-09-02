alter Procedure Pa_ConsultaLotesPacas
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
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta

	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
end
else if @IdComprador = 0 and @NoLote ='' and @IdPlanta = 0 and @SinComprador = 1 and @SinLote = 0
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta
	where co.Nombre is null
	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
end
else if @IdComprador = 0 and @NoLote ='' and @IdPlanta > 0 and @SinComprador = 1 and @SinLote = 0
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta
	where co.Nombre is null and cc.idplantaorigen = @IdPlanta
	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
end
else if @IdComprador = 0 and @NoLote ='' and @IdPlanta > 0 and @SinComprador = 0 and @SinLote = 1
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta
	where cc.Nolote is null and cc.idplantaorigen = @IdPlanta
	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
end
else if @IdComprador = 0 and @NoLote ='' and @IdPlanta = 0 and @SinComprador = 0 and @SinLote = 1
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta
	where cc.Nolote is null
	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
end
else if @IdComprador = 0 and @NoLote ='' and @IdPlanta > 0
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta
	where cc.IdPlantaOrigen = @IdPlanta
	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
end
else if @IdComprador > 0 and @Nolote = '' and @IdPlanta = 0
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta

	where vp.IdComprador = @IdComprador
	--and cc.IdSalidaEncabezado is not null 
	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
end
else if @IdComprador > 0 and @Nolote = '' and @IdPlanta > 0
begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta

	where vp.IdComprador = @IdComprador and cc.IdPlantaOrigen = @IdPlanta
	--and cc.IdSalidaEncabezado is not null 
	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
end
else if @IdComprador = 0 and @Nolote <> '' and @IdPlanta = 0
begin
	IF @Nolote <> 'SIN LOTE'
	BEGIN
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta

	where cc.Nolote = @Nolote
	--and cc.IdSalidaEncabezado is not null 
	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
	END
	ELSE
	BEGIN
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta

	where cc.Nolote IS NULL
	--and cc.IdSalidaEncabezado is not null 
	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
	END
end
else if @IdComprador > 0 and @Nolote <> '' and @IdPlanta = 0
begin
	IF @Nolote <> 'SIN LOTE'
	BEGIN
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta
	where vp.IdComprador = @IdComprador and cc.Nolote = @Nolote
	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
	END
	ELSE 
	BEGIN
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta
	where vp.IdComprador = @IdComprador and cc.Nolote IS NULL
	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
	END

end
else if @IdComprador > 0 and @Nolote <> '' and @IdPlanta > 0
begin
	IF @Nolote <> 'SIN LOTE'
	BEGIN
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta
	where vp.IdComprador = @IdComprador and cc.Nolote = @Nolote and cc.idplantaorigen = @idplanta
	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
	END
	ELSE 
	BEGIN
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS Nolote
		  ,pl.Descripcion as Planta
		  ,count(cc.BaleID) AS Pacas
		  ,Sum(cc.Kilos) as Kilos
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join Plantas pl on cc.IdPlantaOrigen = pl.idplanta
	where vp.IdComprador = @IdComprador and cc.Nolote IS NULL and cc.idplantaorigen = @idplanta
	group by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,vp.IdComprador,pl.descripcion
	order by cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado,cc.NoLote,co.Nombre--,cc.BaleID
	END

end