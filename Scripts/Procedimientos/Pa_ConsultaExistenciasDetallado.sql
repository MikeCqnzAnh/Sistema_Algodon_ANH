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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdEmbarqueEncabezado = @IdEmbarque
	order by cc.Baleid
end
else if @IdPlanta > 0 and @IdComprador = 0 and @CkEmbarque = 0 and @CkSinEmbarque = 0
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdPlantaOrigen = @IdPlanta 
	order by cc.Baleid
end
else if @IdPlanta > 0 and @IdComprador > 0 and @CkSalidas = 0 and @CkExistencias = 1
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdPlantaOrigen = @IdPlanta and cc.IdSalidaEncabezado is null and vp.IdComprador = @IdComprador
	order by cc.Baleid
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdSalidaEncabezado is not null and cc.IdComprador = @IdComprador
	order by cc.Baleid
end
else if @CkExistencias = 1 and @IdComprador = 0
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdSalidaEncabezado is null
	order by cc.Baleid
end
else if @CkExistencias = 1 and @IdComprador > 0
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	where cc.IdSalidaEncabezado is null and cc.IdComprador = @IdComprador
	order by cc.Baleid
end
else 
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
								 inner join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdPlantaOrigen = hd.IdPlantaOrigen
								 inner join ProduccionDetalle Pd on hd.IdPlantaOrigen = pd.IdPlantaOrigen and hd.Baleid = pd.FolioCia
								 inner join Produccion Pe on pd.IdProduccion = Pe.IdProduccion
								 inner join Clientes Cl on Pe.IdCliente = Cl.IdCliente
								 inner join VentaPacas vp on cc.idventaenc = vp.IdVenta
								 inner join Compradores co on vp.IdComprador = co.IdComprador
	order by cc.Baleid
end