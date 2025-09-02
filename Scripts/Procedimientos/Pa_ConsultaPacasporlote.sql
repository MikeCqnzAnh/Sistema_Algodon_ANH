alter Procedure Pa_ConsultaPacasporlote
@IdComprador int,
@Nolote varchar(15),
@IdPlanta int,
@SinComprador bit,
@SinLote bit,
@Sel bit = 0
as
if @IdComprador = 0 and @Nolote = '' and @IdPlanta = 0 and @SinComprador = 0 and @SinLote = 0
begin
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	order by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado
end
else if @IdComprador = 0 and @Nolote = '' and @IdPlanta = 0 and @SinComprador = 1 and @SinLote = 0
begin
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	where co.Nombre is null
	order by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado
end
else if @IdComprador = 0 and @Nolote = '' and @IdPlanta > 0 and @SinComprador = 1 and @SinLote = 0
begin
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	where co.Nombre is null and cc.idplantaorigen = @IdPlanta
	order by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado
end
else if @IdComprador = 0 and @Nolote = '' and @IdPlanta > 0 and @SinComprador = 0 and @SinLote = 1
begin
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	where cc.NoLote is null and cc.idplantaorigen = @IdPlanta
	order by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado
end
else if @IdComprador = 0 and @Nolote = '' and @IdPlanta = 0 and @SinComprador = 0 and @SinLote = 1
begin
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	where cc.Nolote is null
	order by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado
end

else if @IdComprador = 0 and @Nolote = '' and @IdPlanta > 0
begin
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	where cc.idplantaorigen = @idplanta
	order by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado
end
else if @idcomprador > 0 and @Nolote= '' and @IdPlanta = 0
begin 
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	where cc.baleid is not null and vp.idcomprador = @idcomprador
	order by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado
end
else if @idcomprador > 0 and @Nolote= '' and @IdPlanta > 0
begin 
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	where cc.baleid is not null and vp.idcomprador = @idcomprador and cc.idplantaorigen = @idplanta
	order by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado
end
else if @idcomprador = 0 and @Nolote<> '' and @IdPlanta = 0
begin 
	if @Nolote <> 'SIN LOTE'
	begin 
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	where cc.baleid is not null and cc.Nolote = @Nolote
	order by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado
	end
	else 
	begin
		select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	where cc.baleid is not null and cc.Nolote is null
	end
end
else if @idcomprador > 0 and @Nolote<> '' and @IdPlanta = 0
begin 
	if @NoLote <> 'SIN LOTE'
	BEGIN
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	where cc.baleid is not null and cc.Nolote = @Nolote and vp.idcomprador = @idcomprador
	order by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado
	END
	ELSE
	BEGIN
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	where cc.baleid is not null and cc.Nolote IS NULL and vp.idcomprador = @idcomprador
	order by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado
	END
end
else if @idcomprador > 0 and @Nolote<> '' and @IdPlanta > 0
begin 
	if @NoLote <> 'SIN LOTE'
	BEGIN
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	where cc.baleid is not null and cc.Nolote = @Nolote and vp.idcomprador = @idcomprador and cc.idplantaorigen = @idplanta
	order by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado
	END
	ELSE
	BEGIN
	select isnull(vp.IdComprador,0) as IdComprador
		  ,ISNULL(co.Nombre,'SIN COMPRADOR') as Comprador
		  ,isnull(cc.Nolote,'SIN LOTE') AS NoLote
		  ,pl.Descripcion as Planta
		  ,cc.BaleID
		  ,cast(isnull(pcv.kilosneto,0)+cc.Kilos as decimal(18,2)) as KilosBruto 
		  ,cast(isnull(pcv.kilosneto,0) as decimal(18,2)) as KilosTara
		  ,cc.Kilos as KilosNeto
		  ,ISNULL(cc.IdEmbarqueEncabezado, 0) as IdEmbarque
		  ,isnull(estatusEmbarque,0) as EstatusEmbarque
		  ,ISNULL(cc.IdSalidaEncabezado,0) as IdSalida
		  ,ISNULL(cc.EstatusSalida,0) as EstatusSalida
	from ventapacas vp right join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join parametroscontratoventa pcv on pcv.IdContratoVenta = vp.IdContratoAlgodon
					   left join plantas pl on cc.idplantaorigen = pl.idplanta
	where cc.baleid is not null and cc.Nolote IS NULL and vp.idcomprador = @idcomprador and cc.idplantaorigen = @idplanta
	order by cc.NoLote,co.nombre,cc.IdEmbarqueEncabezado,cc.IdSalidaEncabezado
	END
end