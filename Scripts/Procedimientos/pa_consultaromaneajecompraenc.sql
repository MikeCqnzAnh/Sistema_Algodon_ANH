create procedure pa_consultaromaneajecompraenc
@IdCompra int,
@CheckStatus bit
as
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
	  ,@CheckStatus as CheckStatus
from comprapacas cp inner join HviDetalle hd on cp.IdCompra = hd.IdCompraEnc 
					inner join LiquidacionesPorRomaneaje lr on hd.idordentrabajo = lr.idordentrabajo
					inner join clientes cl on cp.idproductor = cl.IdCliente
where cp.IdCompra = @IdCompra
group by cp.idcompra,cp.idproductor,cl.nombre,hd.idordentrabajo,lr.idliquidacion,lr.fecha,lr.totalhueso,lr.totalpluma,lr.PorcentajePluma,
lr.TotalBorregos,
lr.TotalPlumaBorregos,
lr.TotalMerma,
lr.PorcentajeMerma,
lr.TotalPacas,
lr.TotalSemilla,
lr.PorcentajeSemilla
order by cp.idcompra