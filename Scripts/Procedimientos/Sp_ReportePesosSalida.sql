CREATE Procedure Sp_ReportePesosSalida
@HabilitaCampos bit = 0,
@IdSalidaPacas int ,
@IdComprador int
as
if @IdSalidaPacas = 0 and @IdComprador = 0
	begin 
		select cal.idembarqueencabezado
		,sae.IdSalidaEncabezado
		,cal.NoLote
		,com.Nombre
		,count(hvi.BaleID) as Cantidad
		,sum(hvi.Kilos) as KilosOrigen 
		,sum (cal.Kilos) as KilosVenta
		,sae.PesoNeto as KilosSalida
		,sae.Destino
		,isnull(sae.FolioSalida,0) as FolioSalida
		,sae.NoFactura
		,sae.FechaEntrada
		,sae.FechaSalida
		,sae.EstatusSalida
		,@HabilitaCampos as HabilitaCampos  
		from embarqueencabezado eme inner join SalidaPacasEncabezado sae on eme.IdEmbarqueEncabezado = sae.IdEmbarqueEncabezado
						inner join calculoclasificacion cal on   sae.idsalidaencabezado = cal.idsalidaencabezado
						inner join hvidetalle hvi on cal.BaleID = hvi.BaleID and cal.IdPlantaOrigen = hvi.IdPlantaOrigen and cal.idordentrabajo = hvi.IdOrdenTrabajo
						inner join Compradores com on cal.IdComprador = com.idcomprador 
		where sae.EstatusSalida = 1
		group by cal.idembarqueencabezado
		,sae.IdSalidaEncabezado
		,sae.PesoNeto 
		,com.Nombre
		,sae.Destino
		,sae.FolioSalida
		,cal.nolote
		,sae.NoFactura
		,sae.FechaEntrada
		,sae.FechaSalida
		,sae.EstatusSalida
		order by cal.idembarqueencabezado
	end
else if  @IdSalidaPacas > 0 and @IdComprador = 0
	begin
		select cal.idembarqueencabezado
		,sae.IdSalidaEncabezado
		,cal.NoLote
		,com.Nombre
		,count(hvi.BaleID) as Cantidad
		,sum(hvi.Kilos) as KilosOrigen 
		,sum (cal.Kilos) as KilosVenta
		,sae.PesoNeto as KilosSalida
		,sae.Destino
		,isnull(sae.FolioSalida,0) as FolioSalida
		,sae.NoFactura
		,sae.FechaEntrada
		,sae.FechaSalida
		,sae.EstatusSalida
		,@HabilitaCampos as HabilitaCampos  
		from embarqueencabezado eme inner join SalidaPacasEncabezado sae on eme.IdEmbarqueEncabezado = sae.IdEmbarqueEncabezado
						inner join calculoclasificacion cal on   sae.idsalidaencabezado = cal.idsalidaencabezado
						inner join hvidetalle hvi on cal.BaleID = hvi.BaleID and cal.IdPlantaOrigen = hvi.IdPlantaOrigen and cal.idordentrabajo = hvi.IdOrdenTrabajo
						inner join Compradores com on cal.IdComprador = com.idcomprador 
		where sae.EstatusSalida = 1 and sae.IdSalidaEncabezado = @IdSalidaPacas
		group by cal.idembarqueencabezado
		,sae.IdSalidaEncabezado
		,sae.PesoNeto 
		,com.Nombre
		,sae.Destino
		,sae.FolioSalida
		,cal.nolote
		,sae.NoFactura
		,sae.FechaEntrada
		,sae.FechaSalida
		,sae.EstatusSalida
		order by cal.idembarqueencabezado
	end
else if @IdSalidaPacas = 0 and @IdComprador > 0
	begin
		select cal.idembarqueencabezado
		,sae.IdSalidaEncabezado
		,cal.NoLote
		,com.Nombre
		,count(hvi.BaleID) as Cantidad
		,sum(hvi.Kilos) as KilosOrigen 
		,sum (cal.Kilos) as KilosVenta
		,sae.PesoNeto as KilosSalida
		,sae.Destino
		,isnull(sae.FolioSalida,0) as FolioSalida
		,sae.NoFactura
		,sae.FechaEntrada
		,sae.FechaSalida
		,sae.EstatusSalida
		,@HabilitaCampos as HabilitaCampos  
		from embarqueencabezado eme inner join SalidaPacasEncabezado sae on eme.IdEmbarqueEncabezado = sae.IdEmbarqueEncabezado
						inner join calculoclasificacion cal on   sae.idsalidaencabezado = cal.idsalidaencabezado
						inner join hvidetalle hvi on cal.BaleID = hvi.BaleID and cal.IdPlantaOrigen = hvi.IdPlantaOrigen and cal.idordentrabajo = hvi.IdOrdenTrabajo
						inner join Compradores com on cal.IdComprador = com.idcomprador 
		where sae.EstatusSalida = 1 and cal.IdComprador = @IdComprador
		group by cal.idembarqueencabezado
		,sae.IdSalidaEncabezado
		,sae.PesoNeto 
		,com.Nombre
		,sae.Destino
		,sae.FolioSalida
		,cal.nolote
		,sae.NoFactura
		,sae.FechaEntrada
		,sae.FechaSalida
		,sae.EstatusSalida
		order by cal.idembarqueencabezado
	end