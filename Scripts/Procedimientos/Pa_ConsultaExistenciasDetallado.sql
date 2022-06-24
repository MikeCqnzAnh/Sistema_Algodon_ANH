alter Procedure Pa_ConsultaExistenciasDetallado
@IdCompra as Int,
@IdPaqVenta as Int,
@IdVenta as int,
@IdEmbarque as int,
@IdPlanta as int,
@IdSalida as int,
@IdComprador as int,
@IdProductor as int,
@CkCompradas as bit,
@CksinComprar as bit,
@CkVendidas as bit,
@CkSinVender as bit,
@CkEmbarque as bit,
@CkSinEmbarque as bit,
@CkSalidas as bit,
@CkExistencias as bit
as
if @IdCompra > 0 
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where hd.IdCompraEnc = @IdCompra
	order by cc.Baleid
end
else if @IdPaqVenta > 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdPaqueteEncabezado = @IdPaqVenta
	order by cc.Baleid
end
else if @IdVenta > 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdventaEnc = @IdVenta
	order by cc.Baleid
end
else if @IdSalida > 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdSalidaEncabezado = @IdSalida
	order by cc.Baleid
end
else if @IdEmbarque > 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdEmbarqueEncabezado = @IdEmbarque
	order by cc.Baleid
end
else if @IdPlanta > 0 and @IdComprador = 0 and @CkEmbarque = 0 and @CkSinEmbarque = 0
begin
	select pd.Foliocia as BaleID,
		   pd.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdVentaEnc,0) as IdVentaEnc,
		   ISNULL(cc.IdEmbarqueEncabezado , 0 ) as IdEmbarqueEncabezado,
		   ISNULL(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from ventapacas vp inner join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   full join producciondetalle pd on cc.baleid = pd.foliocia and cc.Idordentrabajo = pd.Idordentrabajo
					   full join HviDetalle hd on pd.Foliocia = hd.BaleID and pd.Idordentrabajo = hd.Idordentrabajo 
					   full join Compradores co on vp.IdComprador=co.IdComprador
					   full join produccion pe on pd.idproduccion = pe.idproduccion
					   full join Plantas as Pl on pd.IdPlantaOrigen = pl.IdPlanta
					   full join Clientes Cl on Pe.IdCliente = cl.IdCliente	
	where pd.IdPlantaOrigen = @IdPlanta 
	order by pd.Foliocia
end
else if @IdPlanta > 0 and @IdComprador > 0 and @CkSalidas = 0 and @CkExistencias = 1
begin
	select pd.Foliocia as BaleID,
		   pd.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdVentaEnc,0) as IdVentaEnc,
		   ISNULL(cc.IdEmbarqueEncabezado , 0 ) as IdEmbarqueEncabezado,
		   ISNULL(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from ventapacas vp inner join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   full join producciondetalle pd on cc.baleid = pd.foliocia and cc.Idordentrabajo = pd.Idordentrabajo
					   full join HviDetalle hd on pd.Foliocia = hd.BaleID and pd.Idordentrabajo = hd.Idordentrabajo 
					   full join Compradores co on vp.IdComprador=co.IdComprador
					   full join produccion pe on pd.idproduccion = pe.idproduccion
					   full join Plantas as Pl on pd.IdPlantaOrigen = pl.IdPlanta
					   full join Clientes Cl on Pe.IdCliente = cl.IdCliente	
	where pd.IdPlantaOrigen = @IdPlanta and cc.IdSalidaEncabezado is null and vp.IdComprador = @IdComprador
	order by pd.Foliocia
end
else if @IdPlanta > 0 and @IdComprador > 0 and @CkSalidas = 1 and @CkExistencias = 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdPlantaOrigen = @IdPlanta and cc.IdSalidaEncabezado is not null and vp.IdComprador = @IdComprador
	order by cc.Baleid
end
else if @IdPlanta > 0 and @IdComprador > 0 and @CkEmbarque = 0 and @CkSinEmbarque = 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdPlantaOrigen = @IdPlanta and cc.IdEmbarqueEncabezado is not null and vp.IdComprador = @IdComprador
	order by cc.Baleid
end
else if @IdPlanta > 0 and @IdComprador > 0 and @CkEmbarque = 1
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdPlantaOrigen = @IdPlanta and vp.IdComprador = @IdComprador and cc.IdEmbarqueEncabezado is not null
	order by cc.Baleid
end
else if @IdPlanta > 0 and @IdComprador > 0 and @CkSinEmbarque = 1
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdPlantaOrigen = @IdPlanta and vp.IdComprador = @IdComprador and cc.IdEmbarqueEncabezado is null
	order by cc.Baleid
end
else if @IdPlanta > 0 and @CkEmbarque = 1
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdPlantaOrigen = @IdPlanta and cc.IdEmbarqueEncabezado is not null
	order by cc.Baleid
end
else if @CkCompradas = 1 and @IdComprador > 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where hd.IdCompraEnc is not null and vp.IdComprador = @IdComprador
	order by cc.Baleid
end
else if @CkCompradas = 1 and @IdComprador = 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where hd.IdCompraEnc is not null
	order by cc.Baleid
end
else if @CksinComprar = 1 and @IdComprador > 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where hd.IdCompraEnc is null and  vp.IdComprador = @IdComprador
	order by cc.Baleid
end
else if @CksinComprar = 1 and @IdComprador = 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where hd.IdCompraEnc is null
	order by cc.Baleid
end
else if @CksinComprar = 0 and @IdComprador > 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where  vp.IdComprador = @IdComprador
	order by cc.Baleid
end
else if @CkVendidas = 1 and @IdComprador > 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdventaEnc is not null and vp.IdComprador = @IdComprador
	order by cc.Baleid
end
else if @CkVendidas = 1 and @IdComprador = 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdventaEnc is not null 
	order by cc.Baleid
end
else if @CkSinVender = 1 and @IdComprador > 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdventaEnc is null and vp.IdComprador = @IdComprador
	order by cc.Baleid
end
else if @CkSinVender = 1 and @IdComprador = 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   isnull(co.Nombre , 'Sin Comprador') as Comprador ,
		   cc.Kilos as KilosVenta,	   
		   isnull(cc.Quintales,0) as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc left join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 left join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 left join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 left join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 left join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 left join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 left join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdventaEnc is null 
	order by cc.Baleid
end
else if @CkEmbarque = 1 and @IdComprador = 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdEmbarqueEncabezado is not null 
	order by cc.Baleid
end
else if @CkEmbarque = 1 and @IdComprador > 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdEmbarqueEncabezado is not null and vp.IdComprador = @IdComprador 
	order by cc.Baleid
end
else if @CksinEmbarque = 1 and @IdComprador = 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdEmbarqueEncabezado is  null
	order by cc.Baleid
end
else if @CkSinEmbarque = 1 and @IdComprador > 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdEmbarqueEncabezado is null and vp.IdComprador = @IdComprador 
	order by cc.Baleid
end
else if @CkSinEmbarque = 0 and @IdComprador > 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where vp.IdComprador = @IdComprador 
	order by cc.Baleid
end
else if @CkSalidas = 1 and @IdComprador = 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdSalidaEncabezado is not null
	order by cc.Baleid
end
else if @CkSalidas = 1 and  @IdComprador > 0
begin
	select cc.BaleID,
		   cc.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,	   
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from CalculoClasificacion cc inner join Plantas as Pl on cc.idplantaorigen = pl.idplanta
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.Idordentrabajo = hd.Idordentrabajo
								 inner join ProduccionDetalle Pd on hd.Idordentrabajo = pd.Idordentrabajo and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdSalidaEncabezado is not null and cc.IdComprador = @IdComprador
	order by cc.Baleid
end
else if @CkExistencias = 1 and @IdComprador = 0
begin
select pd.Foliocia as BaleID,
	   pd.IdPlantaOrigen,
	   pl.Descripcion as Planta,
	   cl.Nombre as Productor,
	   hd.kilos as KilosCompra,
	   hd.quintales as QuintalCompra,
	   co.Nombre as Comprador,
	   cc.Kilos as KilosVenta,
	   cc.Quintales as ValorVenta,
	   case 
		when cc.Quintales >= 10 then 'Libra'
		else 'Quintal' end as Unidad,
	   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
	   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
	   isnull(cc.IdVentaEnc,0) as IdVentaEnc,
	   ISNULL(cc.IdEmbarqueEncabezado , 0 ) as IdEmbarqueEncabezado,
	   ISNULL(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
	   isnull(cc.NoLote,'') as NoLote
from ventapacas vp inner join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
				   full join producciondetalle pd on cc.baleid = pd.foliocia and cc.Idordentrabajo = pd.Idordentrabajo
				   full join HviDetalle hd on pd.Foliocia = hd.BaleID and pd.Idordentrabajo = hd.Idordentrabajo 
				   full join Compradores co on vp.IdComprador=co.IdComprador
				   full join produccion pe on pd.idproduccion = pe.idproduccion
				   full join Plantas as Pl on pd.IdPlantaOrigen = pl.IdPlanta
				   full join Clientes Cl on Pe.IdCliente = cl.IdCliente				   
where pd.Foliocia is not null and cc.IdSalidaEncabezado is null
order by pd.Foliocia
end
else if @CkExistencias = 1 and @IdComprador > 0
begin
	select pd.Foliocia as BaleID,
		   pd.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   hd.kilos as KilosCompra,
		   hd.quintales as QuintalCompra,
		   co.Nombre as Comprador,
		   cc.Kilos as KilosVenta,
		   cc.Quintales as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdVentaEnc,0) as IdVentaEnc,
		   ISNULL(cc.IdEmbarqueEncabezado , 0 ) as IdEmbarqueEncabezado,
		   ISNULL(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from ventapacas vp left join calculoclasificacion cc on vp.IdVenta = cc.IdVentaEnc
					   left join producciondetalle pd on cc.baleid = pd.foliocia and cc.idordentrabajo = pd.Idordentrabajo
					   left join HviDetalle hd on pd.Foliocia = hd.BaleID and pd.Idordentrabajo = hd.Idordentrabajo 
					   left join Compradores co on vp.IdComprador=co.IdComprador
					   left join produccion pe on pd.idproduccion = pe.idproduccion
					   left join Plantas as Pl on pd.IdPlantaOrigen = pl.IdPlanta
					   left join Clientes Cl on Pe.IdCliente = cl.IdCliente		
	where pd.Foliocia is not null and cc.IdSalidaEncabezado is null and vp.IdComprador = @IdComprador
	order by pd.Foliocia
end
else 
begin
	select pd.FolioCia as BaleID,
		   Pd.IdPlantaOrigen,
		   pl.Descripcion as Planta,
		   cl.Nombre as Productor,
		   isnull(hd.kilos,0) as KilosCompra,
		   isnull(hd.quintales,0) as QuintalCompra,
		   isnull(co.Nombre,'') as Comprador,
		   isnull(cc.Kilos,0) as KilosVenta,	   
		   isnull(cc.Quintales,0) as ValorVenta,
		   case 
			when cc.Quintales >= 10 then 'Libra'
			else 'Quintal' end as Unidad,
		   isnull(hd.IdCompraEnc,0) as IdCompraEnc,
		   isnull(cc.IdPaqueteEncabezado,0) as IdPaqueteEncabezado,
		   isnull(cc.IdventaEnc,0) as IdventaEnc,
		   isnull(cc.IdEmbarqueEncabezado,0) as IdEmbarqueEncabezado,
		   isnull(cc.IdSalidaEncabezado,0) as IdSalidaEncabezado,
		   isnull(cc.NoLote,'') as NoLote
	from ProduccionDetalle pd left join CalculoClasificacion cc on pd.foliocia = cc.baleid and pd.Idordentrabajo = cc.Idordentrabajo
							  left join HviDetalle hd on cc.BaleID = hd.BaleID and cc.idordentrabajo = hd.idordentrabajo
							  left join Plantas as Pl on pd.idplantaorigen = pl.idplanta
							  left join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
							  left join Clientes Cl on Pe.IdCliente = Cl.IdCliente
							  left join VentaPacas vp on cc.idventaenc = vp.IdVenta
							  left join Compradores co on vp.IdComprador = co.IdComprador
	order by cc.Baleid
end