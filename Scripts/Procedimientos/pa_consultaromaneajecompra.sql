select top 1 * from HVIEncabezado
select top 1 * from hvidetalle
select top 1 * from LiquidacionesPorRomaneaje
select top 1 * from comprapacas
select top 1 * from contratocompra
select top 1 * from Clientes

select * from LiquidacionesPorRomaneaje lr inner join CompraPacas cp on lr.IdOrdenTrabajo = cp.idor

select cp.IdCompra
	  ,hd.IdOrdenTrabajo
	  ,lr.IdLiquidacion
	  ,cp.idproductor 
	  ,CL.Nombre	  
	  ,lr.Fecha
	  ,(SELECT STUFF((SELECT '-'+convert(varchar(10),Idboleta) FROM ordentrabajodetalle where idordentrabajo = hd.IdOrdenTrabajo FOR XML PATH('')),1,1, '')) as Modulos
	  ,lr.totalhueso
	  ,lr.TotalPluma
	  ,lr.PorcentajePluma
	  ,lr.TotalBorregos
	  ,lr.TotalPlumaBorregos
	  ,lr.TotalMerma
	  ,lr.PorcentajeMerma
	  ,lr.TotalPacas
	  ,lr.TotalSemilla
	  ,lr.PorcentajeSemilla
	  
from comprapacas cp inner join HviDetalle hd on cp.IdCompra = hd.IdCompraEnc 
					inner join LiquidacionesPorRomaneaje lr on hd.idordentrabajo = lr.idordentrabajo
					inner join clientes cl on cp.idproductor = cl.IdCliente
group by cp.idcompra,cp.idproductor,cl.nombre,hd.idordentrabajo,lr.idliquidacion,lr.fecha,lr.totalhueso,lr.totalpluma,lr.PorcentajePluma,
lr.TotalBorregos,
lr.TotalPlumaBorregos,
lr.TotalMerma,
lr.PorcentajeMerma,
lr.TotalPacas,
lr.TotalSemilla,
lr.PorcentajeSemilla
order by cp.idcompra


