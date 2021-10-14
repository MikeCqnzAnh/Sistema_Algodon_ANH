--insert into [SERVER2008\SERVER12].[ALGODON2020].DBO.EMBARQUEDET
select cc.IdEmbarqueEncabezado,count(baleid) as CantidadPacas,NoContenedor,NoLote,PlacaCaja,ee.fecha,getdate() as FechaActualizacion 
from calculoclasificacion cc inner join embarqueencabezado ee on cc.idembarqueencabezado = ee.IdEmbarqueEncabezado 
--where NoLote is not null and cc.IdEmbarqueEncabezado > 335 
group by cc.IdEmbarqueEncabezado,NoContenedor,NoLote,PlacaCaja,ee.Fecha 
order by cc.IdEmbarqueEncabezado

select * from embarqueencabezado

