alter Procedure Sp_ReporteDetalladoPacas
--Declare
@IdProductor int ,
@IdPlanta int ,
@IdClase int ,
@IdOrdenProduccion int 
as
if @IdProductor = 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion = 0 
	begin
select isnull(pd.FolioCIA,0) as FolioCIA,
		isnull(pd.idordentrabajo, 0) as IdOrdenTrabajo,
		isnull(cl.Nombre,'') as Nombre,
		isnull(pd.IdPlantaOrigen,'') as Planta,
		isnull(((OT.PesoModulos/Pr.plumapacas)*pd.Kilos),0) as KilosHueso,
		isnull(pd.Kilos,0) as Kilos,
		isnull(ot.FechaCreacion,'') as Fecha,
		isnull(cc.ClaveCorta,'') as Clase,
		isnull(hd.Mic,0) as Mic,
		isnull(hd.UHML,0) as UHML,
		isnull(hd.Strength,0) as Strength,
		ISNULL(hd.UI,0) as Uniformidad
		from ProduccionDetalle pd left join HVIDetalle hd on pd.IdOrdenTrabajo = hd.idOrdentrabajo and pd.IdPlantaOrigen = hd.idplantaorigen and pd.FolioCIA = hd.BaleID
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join Plantas pl on hd.IdPlantaOrigen = pl.IdPlanta
							left join OrdenTrabajo OT on pr.IdOrdenTrabajo = OT.IdOrdenTrabajo
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
order by pd.IdPlantaOrigen,pd.foliocia
	end
if @IdProductor > 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion = 0 
	begin
select isnull(pd.FolioCIA,0) as FolioCIA,
		isnull(pd.idordentrabajo, 0) as IdOrdenTrabajo,
		isnull(cl.Nombre,'') as Nombre,
		isnull(pd.IdPlantaOrigen,'') as Planta,
		isnull(((OT.PesoModulos/Pr.plumapacas)*pd.Kilos),0) as KilosHueso,
		isnull(pd.Kilos,0) as Kilos,
		isnull(ot.FechaCreacion,'') as Fecha,
		isnull(cc.ClaveCorta,'') as Clase,
		isnull(hd.Mic,0) as Mic,
		isnull(hd.UHML,0) as UHML,
		isnull(hd.Strength,0) as Strength,
		ISNULL(hd.UI,0) as Uniformidad
		from ProduccionDetalle pd left join HVIDetalle hd on pd.IdOrdenTrabajo = hd.idOrdentrabajo and pd.IdPlantaOrigen = hd.idplantaorigen and pd.FolioCIA = hd.BaleID
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join Plantas pl on hd.IdPlantaOrigen = pl.IdPlanta
							left join OrdenTrabajo OT on pr.IdOrdenTrabajo = OT.IdOrdenTrabajo
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor
		order by pd.IdPlantaOrigen,pd.foliocia
	end
if @IdProductor > 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion > 0 
	begin
select isnull(pd.FolioCIA,0) as FolioCIA,
		isnull(pd.idordentrabajo, 0) as IdOrdenTrabajo,
		isnull(cl.Nombre,'') as Nombre,
		isnull(pd.IdPlantaOrigen,'') as Planta,
		isnull(((OT.PesoModulos/Pr.plumapacas)*pd.Kilos),0) as KilosHueso,
		isnull(pd.Kilos,0) as Kilos,
		isnull(ot.FechaCreacion,'') as Fecha,
		isnull(cc.ClaveCorta,'') as Clase,
		isnull(hd.Mic,0) as Mic,
		isnull(hd.UHML,0) as UHML,
		isnull(hd.Strength,0) as Strength,
		ISNULL(hd.UI,0) as Uniformidad
		from ProduccionDetalle pd left join HVIDetalle hd on pd.IdOrdenTrabajo = hd.idOrdentrabajo and pd.IdPlantaOrigen = hd.idplantaorigen and pd.FolioCIA = hd.BaleID
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join Plantas pl on hd.IdPlantaOrigen = pl.IdPlanta
							left join OrdenTrabajo OT on pr.IdOrdenTrabajo = OT.IdOrdenTrabajo
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and pd.IdOrdenTrabajo = @IdOrdenProduccion
		order by pd.IdPlantaOrigen,pd.foliocia
	end
if @IdProductor > 0 and @IdPlanta > 0 and @IdClase = 0 and @IdOrdenProduccion > 0 
	begin
select isnull(pd.FolioCIA,0) as FolioCIA,
		isnull(pd.idordentrabajo, 0) as IdOrdenTrabajo,
		isnull(cl.Nombre,'') as Nombre,
		isnull(pd.IdPlantaOrigen,'') as Planta,
		isnull(((OT.PesoModulos/Pr.plumapacas)*pd.Kilos),0) as KilosHueso,
		isnull(pd.Kilos,0) as Kilos,
		isnull(ot.FechaCreacion,'') as Fecha,
		isnull(cc.ClaveCorta,'') as Clase,
		isnull(hd.Mic,0) as Mic,
		isnull(hd.UHML,0) as UHML,
		isnull(hd.Strength,0) as Strength,
		ISNULL(hd.UI,0) as Uniformidad
		from ProduccionDetalle pd left join HVIDetalle hd on pd.IdOrdenTrabajo = hd.idOrdentrabajo and pd.IdPlantaOrigen = hd.idplantaorigen and pd.FolioCIA = hd.BaleID
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join Plantas pl on hd.IdPlantaOrigen = pl.IdPlanta
							left join OrdenTrabajo OT on pr.IdOrdenTrabajo = OT.IdOrdenTrabajo
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and pd.IdOrdenTrabajo = @IdOrdenProduccion and pd.IdPlantaOrigen = @IdPlanta
		order by pd.IdPlantaOrigen,pd.foliocia
	end
if @IdProductor > 0 and @IdPlanta > 0 and @IdClase > 0 and @IdOrdenProduccion > 0 
	begin
select isnull(pd.FolioCIA,0) as FolioCIA,
		isnull(pd.idordentrabajo, 0) as IdOrdenTrabajo,
		isnull(cl.Nombre,'') as Nombre,
		isnull(pd.IdPlantaOrigen,'') as Planta,
		isnull(((OT.PesoModulos/Pr.plumapacas)*pd.Kilos),0) as KilosHueso,
		isnull(pd.Kilos,0) as Kilos,
		isnull(ot.FechaCreacion,'') as Fecha,
		isnull(cc.ClaveCorta,'') as Clase,
		isnull(hd.Mic,0) as Mic,
		isnull(hd.UHML,0) as UHML,
		isnull(hd.Strength,0) as Strength,
		ISNULL(hd.UI,0) as Uniformidad
		from ProduccionDetalle pd left join HVIDetalle hd on pd.IdOrdenTrabajo = hd.idOrdentrabajo and pd.IdPlantaOrigen = hd.idplantaorigen and pd.FolioCIA = hd.BaleID
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join Plantas pl on hd.IdPlantaOrigen = pl.IdPlanta
							left join OrdenTrabajo OT on pr.IdOrdenTrabajo = OT.IdOrdenTrabajo
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and pd.IdOrdenTrabajo = @IdOrdenProduccion and pd.IdPlantaOrigen = @IdPlanta and cc.IdClasificacion = @IdClase
		order by pd.IdPlantaOrigen,pd.foliocia
	end
if @IdProductor > 0 and @IdPlanta = 0 and @IdClase > 0 and @IdOrdenProduccion = 0 
	begin
select isnull(pd.FolioCIA,0) as FolioCIA,
		isnull(pd.idordentrabajo, 0) as IdOrdenTrabajo,
		isnull(cl.Nombre,'') as Nombre,
		isnull(pd.IdPlantaOrigen,'') as Planta,
		isnull(((OT.PesoModulos/Pr.plumapacas)*pd.Kilos),0) as KilosHueso,
		isnull(pd.Kilos,0) as Kilos,
		isnull(ot.FechaCreacion,'') as Fecha,
		isnull(cc.ClaveCorta,'') as Clase,
		isnull(hd.Mic,0) as Mic,
		isnull(hd.UHML,0) as UHML,
		isnull(hd.Strength,0) as Strength,
		ISNULL(hd.UI,0) as Uniformidad
		from ProduccionDetalle pd left join HVIDetalle hd on pd.IdOrdenTrabajo = hd.idOrdentrabajo and pd.IdPlantaOrigen = hd.idplantaorigen and pd.FolioCIA = hd.BaleID
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join Plantas pl on hd.IdPlantaOrigen = pl.IdPlanta
							left join OrdenTrabajo OT on pr.IdOrdenTrabajo = OT.IdOrdenTrabajo
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and cc.IdClasificacion = @IdClase
		order by pd.IdPlantaOrigen,pd.foliocia
	end
