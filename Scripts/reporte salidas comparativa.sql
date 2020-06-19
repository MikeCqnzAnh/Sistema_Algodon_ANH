		select ed.idembarqueencabezado
			  ,cc.Nombre
			  ,count(hd.BaleID) as Cantidad
			  ,sum(hd.Kilos) as KilosOrigen 
			  ,sum (ed.Kilos) as KilosVenta 
			  ,se.PesoNeto as KilosSalida
			  --,se.Destino
			  ,isnull(se.FolioSalida,0) as FolioSalida
			  --,se.NoFactura
			  ,se.FechaEntrada
			  ,se.FechaSalida
			  --,@HabilitaCampos as HabilitaCampos
		from HviDetalle hd inner join  CalculoClasificacion ed on hd.BaleID = ed.BaleID --and hd.IdPlantaOrigen = ed.IdPlantaOrigen
						   left join  SalidaPacasEncabezado se on ed.IdEmbarqueEncabezado = se.IdEmbarqueEncabezado and ed.NoLote = se.NoLote
						   left join  EmbarqueEncabezado ee on ee.idembarqueencabezado = se.idembarqueencabezado
						   left join  Compradores cc on ed.IdComprador = cc.IdComprador
		where se.EstatusSalida = 1 --and se.IdSalidaEncabezado = @IdSalidaPacas
		group by ed.idembarqueencabezado,
				 se.PesoNeto,
				 cc.Nombre,
				 se.FechaEntrada, 
				 se.FechaSalida,
				 --se.Destino,
			     se.FolioSalida
				 --se.NoFactura

select cal.idembarqueencabezado
	  ,sae.IdSalidaEncabezado
	  ,com.Nombre
	  ,count(hvi.BaleID) as Cantidad
	  ,sum(hvi.Kilos) as KilosOrigen 
	  ,sum (cal.Kilos) as KilosVenta
	  ,sae.PesoNeto as KilosSalida
	  ,sae.Destino
	  ,sae.FolioSalida  
from embarqueencabezado eme inner join SalidaPacasEncabezado sae on eme.IdEmbarqueEncabezado = sae.IdEmbarqueEncabezado
							inner join calculoclasificacion cal on sae.IdEmbarqueEncabezado = cal.IdEmbarqueEncabezado
							inner join hvidetalle hvi on cal.BaleID = hvi.BaleID and cal.IdPlantaOrigen = hvi.IdPlantaOrigen
							inner join Compradores com on cal.IdComprador = com.idcomprador 
group by cal.idembarqueencabezado
		,sae.Idsalidaencabezado
		,sae.PesoNeto 
		,com.Nombre
		,sae.Destino
		,sae.FolioSalida
order by cal.idembarqueencabezado


select * from embarqueencabezado
select * from SalidaPacasEncabezado
select * from calculoclasificacion
select * from hvidetalle
select * from hviencabezado
select * from compradores