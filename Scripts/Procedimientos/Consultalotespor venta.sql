select isnull(NoLote,'SIN LOTE') AS NoLote,sum(kilos) as TotalKilos,count(baleid)CantidadPacas,IdVentaEnc as IdVenta 
from CalculoClasificacion where IdVentaEnc in (11,12) group by NoLote,IdVentaEnc order by NoLote