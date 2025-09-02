alter Procedure Sp_ReportePacasPorClases
--declare
@IdProductor int,
@IdPlanta int ,
@IdClase int ,
@IdOrdenProduccion int
as
if @IdProductor = 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion = 0 
	begin
		SELECT '' as NOMBRE,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES,0 as IdOrdenTrabajo,0 as NumeroModulos,'' as predio
		from ProduccionDetalle PD left join HviDetalle HD on PD.IdPlantaOrigen = HD.IdPlantaOrigen and PD.FolioCIA = HD.BaleID and HD.IdOrdenTrabajo = PD.IdOrdenTrabajo
									left join Produccion Pr on PD.idproduccion = Pr.idproduccion and PD.IdOrdenTrabajo = Pr.IdOrdenTrabajo  
									left join clientes cl on Pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on HD.ColorGrade = Gc.GradoColor and HD.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		GROUP BY CC.CLAVECORTA,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end
else if @IdProductor > 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion = 0 
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES,0 as IdOrdenTrabajo,0 as NumeroModulos,'' as predio
		from ProduccionDetalle PD left join HviDetalle HD on PD.IdPlantaOrigen = HD.IdPlantaOrigen and PD.FolioCIA = HD.BaleID and HD.IdOrdenTrabajo = PD.IdOrdenTrabajo
									left join Produccion Pr on PD.idproduccion = Pr.idproduccion and PD.IdOrdenTrabajo = Pr.IdOrdenTrabajo  
									left join clientes cl on Pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on HD.ColorGrade = Gc.GradoColor and HD.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase = 0 and @IdOrdenProduccion = 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES,0 as IdOrdenTrabajo,0 as NumeroModulos,'' as predio
	    from ProduccionDetalle PD left join HviDetalle HD on PD.IdPlantaOrigen = HD.IdPlantaOrigen and PD.FolioCIA = HD.BaleID and HD.IdOrdenTrabajo = PD.IdOrdenTrabajo
									left join Produccion Pr on PD.idproduccion = Pr.idproduccion and PD.IdOrdenTrabajo = Pr.IdOrdenTrabajo  
									left join clientes cl on Pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on HD.ColorGrade = Gc.GradoColor and HD.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and Pr.IdPlantaOrigen = @idplanta
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase > 0 and @IdOrdenProduccion = 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES,0 as IdOrdenTrabajo,0 as NumeroModulos,'' as predio
		from ProduccionDetalle PD left join HviDetalle HD on PD.IdPlantaOrigen = HD.IdPlantaOrigen and PD.FolioCIA = HD.BaleID and HD.IdOrdenTrabajo = PD.IdOrdenTrabajo
									left join Produccion Pr on PD.idproduccion = Pr.idproduccion and PD.IdOrdenTrabajo = Pr.IdOrdenTrabajo  
									left join clientes cl on Pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on HD.ColorGrade = Gc.GradoColor and HD.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and Pr.IdPlantaOrigen = @idplanta and cc.IdClasificacion = @IdClase
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase > 0 and @IdOrdenProduccion > 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES,ot.IdOrdenTrabajo,ot.NumeroModulos,ot.predio
		from ProduccionDetalle PD left join HviDetalle HD on PD.IdPlantaOrigen = HD.IdPlantaOrigen and PD.FolioCIA = HD.BaleID and HD.IdOrdenTrabajo = PD.IdOrdenTrabajo
									left join Produccion Pr on PD.idproduccion = Pr.idproduccion and PD.IdOrdenTrabajo = Pr.IdOrdenTrabajo  
									left join clientes cl on Pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on HD.ColorGrade = Gc.GradoColor and HD.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
									left join ordentrabajo ot on pd.IdOrdenTrabajo = ot.IdOrdenTrabajo
		where pr.IdCliente = @IdProductor and pd.IdPlantaOrigen = @idplanta and cc.IdClasificacion = @IdClase and pr.IdOrdenTrabajo = @IdOrdenProduccion
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion,ot.idordentrabajo,ot.numeromodulos,ot.Predio	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion > 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES,ot.IdOrdenTrabajo,ot.NumeroModulos,ot.predio
		from ProduccionDetalle PD left join HviDetalle HD on PD.IdPlantaOrigen = HD.IdPlantaOrigen and PD.FolioCIA = HD.BaleID and HD.IdOrdenTrabajo = PD.IdOrdenTrabajo
									left join Produccion Pr on PD.idproduccion = Pr.idproduccion and PD.IdOrdenTrabajo = Pr.IdOrdenTrabajo  
									left join clientes cl on Pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on HD.ColorGrade = Gc.GradoColor and HD.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
									left join ordentrabajo ot on pd.IdOrdenTrabajo = ot.IdOrdenTrabajo
		where pr.IdOrdenTrabajo = @IdOrdenProduccion and pr.IdCliente = @IdProductor
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion,ot.idordentrabajo,ot.numeromodulos,ot.Predio	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor = 0 and @IdPlanta > 0 and @IdClase = 0 and @IdOrdenProduccion = 0
	begin
		SELECT '' as NOMBRE,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES,0 as IdOrdenTrabajo,0 as NumeroModulos,'' as predio
		from ProduccionDetalle PD left join HviDetalle HD on PD.IdPlantaOrigen = HD.IdPlantaOrigen and PD.FolioCIA = HD.BaleID and HD.IdOrdenTrabajo = PD.IdOrdenTrabajo
									left join Produccion Pr on PD.idproduccion = Pr.idproduccion and PD.IdOrdenTrabajo = Pr.IdOrdenTrabajo  
									left join clientes cl on Pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on HD.ColorGrade = Gc.GradoColor and HD.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where PD.IdPlantaOrigen = @IdPlanta
		GROUP BY  CC.CLAVECORTA,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase = 0 and @IdOrdenProduccion > 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES,ot.IdOrdenTrabajo,ot.NumeroModulos,ot.predio
		from ProduccionDetalle PD left join HviDetalle HD on PD.IdPlantaOrigen = HD.IdPlantaOrigen and PD.FolioCIA = HD.BaleID and HD.IdOrdenTrabajo = PD.IdOrdenTrabajo
									left join Produccion Pr on PD.idproduccion = Pr.idproduccion and PD.IdOrdenTrabajo = Pr.IdOrdenTrabajo  
									left join clientes cl on Pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on HD.ColorGrade = Gc.GradoColor and HD.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
									left join ordentrabajo ot on pd.IdOrdenTrabajo = ot.IdOrdenTrabajo
		where pr.IdCliente = @IdProductor and pd.IdPlantaOrigen = @idplanta and pr.IdOrdenTrabajo = @IdOrdenProduccion
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion,ot.idordentrabajo,ot.numeromodulos,ot.Predio	
	    ORDER BY CC.IdClasificacion	
	end
