CREATE Procedure Sp_ReportePacasPorClases
--declare
@IdProductor int,
@IdPlanta int ,
@IdClase int ,
@IdOrdenProduccion int
as
if @IdProductor = 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion = 0 
	begin
		SELECT '' as NOMBRE,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen = PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		GROUP BY CC.CLAVECORTA,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end
else if @IdProductor > 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion = 0 
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen = PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase = 0 and @IdOrdenProduccion = 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen= PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and Pr.IdPlantaOrigen = @idplanta
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase > 0 and @IdOrdenProduccion = 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen= PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and Pr.IdPlantaOrigen = @idplanta and cc.IdClasificacion = @IdClase
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase > 0 and @IdOrdenProduccion > 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen= PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and pd.IdPlantaOrigen = @idplanta and cc.IdClasificacion = @IdClase and pr.IdOrdenTrabajo = @IdOrdenProduccion
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion > 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen= PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdOrdenTrabajo = @IdOrdenProduccion and pr.IdCliente = @IdProductor
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor = 0 and @IdPlanta > 0 and @IdClase = 0 and @IdOrdenProduccion = 0
	begin
		SELECT '' as NOMBRE,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen= PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdPlantaOrigen = @IdPlanta
		GROUP BY  CC.CLAVECORTA,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase = 0 and @IdOrdenProduccion > 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen= PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and pd.IdPlantaOrigen = @idplanta and pr.IdOrdenTrabajo = @IdOrdenProduccion
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 