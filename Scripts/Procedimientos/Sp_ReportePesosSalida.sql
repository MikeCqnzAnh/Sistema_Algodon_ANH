alter Procedure Sp_ReportePesosSalida
@IdSalidaPacas int,
@IdComprador int
as
if @IdSalidaPacas = 0 and @IdComprador = 0
	begin 
		select cc.Nombre
			  ,count(hd.BaleID) as Cantidad
			  ,sum(hd.Kilos) as KilosOrigen 
			  ,sum (ed.Kilos) as KilosVenta 
			  ,se.PesoNeto as KilosSalida
			  ,se.Destino
			  ,se.NoFactura
			  ,se.FechaEntrada
			  ,se.FechaSalida
		from HviDetalle hd inner join  EmbarqueDetalle ed on hd.BaleID = ed.BaleID and hd.IdPlantaOrigen = ed.IdPlanta
						   inner join  SalidaPacasEncabezado se on ed.IdEmbarqueEncabezado = se.IdEmbarqueEncabezado and ed.NoLote = se.NoLote
						   inner join  Compradores cc on ed.IdComprador = cc.IdComprador
		where se.EstatusSalida = 1 --and se.IdSalidaEncabezado = @IdSalidaPacas
		group by se.PesoNeto,
				 cc.Nombre,
				 se.FechaEntrada, 
				 se.FechaSalida,
				 se.Destino,
				 se.NoFactura
	end
else if  @IdSalidaPacas > 0 and @IdComprador = 0
	begin
		select cc.Nombre
			  ,count(hd.BaleID) as Cantidad
			  ,sum(hd.Kilos) as KilosOrigen 
			  ,sum (ed.Kilos) as KilosVenta 
			  ,se.PesoNeto as KilosSalida
			  ,se.Destino
			  ,se.NoFactura
			  ,se.FechaEntrada
			  ,se.FechaSalida
		from HviDetalle hd inner join  EmbarqueDetalle ed on hd.BaleID = ed.BaleID and hd.IdPlantaOrigen = ed.IdPlanta
						   inner join  SalidaPacasEncabezado se on ed.IdEmbarqueEncabezado = se.IdEmbarqueEncabezado and ed.NoLote = se.NoLote
						   inner join  Compradores cc on ed.IdComprador = cc.IdComprador
		where se.EstatusSalida = 1 and se.IdSalidaEncabezado = @IdSalidaPacas
		group by se.PesoNeto,
				 cc.Nombre,
				 se.FechaEntrada, 
				 se.FechaSalida,
				 se.Destino,
				 se.NoFactura
	end
else if @IdSalidaPacas = 0 and @IdComprador > 0
	begin
		select cc.Nombre
			  ,count(hd.BaleID) as Cantidad
			  ,sum(hd.Kilos) as KilosOrigen 
			  ,sum (ed.Kilos) as KilosVenta 
			  ,se.PesoNeto as KilosSalida
			  ,se.Destino
			  ,se.NoFactura
			  ,se.FechaEntrada
			  ,se.FechaSalida
		from HviDetalle hd inner join  EmbarqueDetalle ed on hd.BaleID = ed.BaleID and hd.IdPlantaOrigen = ed.IdPlanta
						   inner join  SalidaPacasEncabezado se on ed.IdEmbarqueEncabezado = se.IdEmbarqueEncabezado and ed.NoLote = se.NoLote
						   inner join  Compradores cc on ed.IdComprador = cc.IdComprador
		where se.EstatusSalida = 1 and ed.IdComprador = @IdComprador
		group by se.PesoNeto,
				 cc.Nombre,
				 se.FechaEntrada, 
				 se.FechaSalida,
				 se.Destino,
				 se.NoFactura	
	end
