select IdCompraEnc
	   ,Grade
	   ,count(baleid)as Cantidad
	   ,sum(Kilos) as Kilos
	   ,sum(Quintales) as Quintales
	   ,PrecioClase 
	   ,sum(PrecioDls) as PrecioDls	  
from HviDetalle
where IdCompraEnc = 1
group by IdCompraEnc, Grade,precioclase

select * from HviDetalle where IdOrdenTrabajo = 1