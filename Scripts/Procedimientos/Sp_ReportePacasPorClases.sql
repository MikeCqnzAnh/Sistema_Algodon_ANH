Create Procedure Sp_ReportePacasPorClases
@IdProductor int,
@IdPlanta int,
@IdClase int,
@IdOrdenProduccion int
as
if @IdProductor = 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion = 0 
	begin
		SELECT '' as NOMBRE,CC.CLAVECORTA AS CLASE,COUNT(BALEID) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD LEFT JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlanta = PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		GROUP BY  CC.CLAVECORTA
	end
else if @IdProductor > 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion = 0 
	begin
			SELECT cl.Nombre,CC.CLAVECORTA AS CLASE,COUNT(BALEID) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD LEFT JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlanta = PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor
		GROUP BY  CC.CLAVECORTA,cl.Nombre
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase = 0 and @IdOrdenProduccion = 0
	begin
			SELECT cl.Nombre,CC.CLAVECORTA AS CLASE,COUNT(BALEID) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD LEFT JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlanta = PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and hd.IdPlanta = @idplanta
		GROUP BY  CC.CLAVECORTA,cl.Nombre
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase > 0 and @IdOrdenProduccion = 0
	begin
			SELECT cl.Nombre,CC.CLAVECORTA AS CLASE,COUNT(BALEID) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD LEFT JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlanta = PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and hd.IdPlanta = @idplanta and cc.IdClasificacion = @IdClase
		GROUP BY  CC.CLAVECORTA,cl.Nombre
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase > 0 and @IdOrdenProduccion > 0
	begin
			SELECT cl.Nombre,CC.CLAVECORTA AS CLASE,COUNT(BALEID) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD LEFT JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlanta = PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and hd.IdPlanta = @idplanta and cc.IdClasificacion = @IdClase and pr.IdOrdenTrabajo = @IdOrdenProduccion
		GROUP BY  CC.CLAVECORTA,cl.Nombre
	end 
else if @IdProductor = 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion > 0
	begin
			SELECT cl.Nombre,CC.CLAVECORTA AS CLASE,COUNT(BALEID) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD LEFT JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlanta = PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdOrdenTrabajo = @IdOrdenProduccion
		GROUP BY  CC.CLAVECORTA,cl.Nombre
	end 