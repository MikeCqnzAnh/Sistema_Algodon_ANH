Create Procedure Sp_ReportePacasPorLote
@IdOrdenTrabajo int
as
select cli.IdCliente
	  ,cli.Nombre
	  ,OTr.IdOrdenTrabajo
	  ,OTr.NumeroModulos
	  ,COUNT(PrD.FolioCIA) as CantidadPacas 
from clientes cli inner join OrdenTrabajo OTr on cli.IdCliente = OTr.IdProductor
				  inner join ProduccionDetalle PrD on OTr.IdOrdenTrabajo = PrD.IdOrdenTrabajo
where otr.idordentrabajo = @IdOrdenTrabajo
group by cli.IdCliente,cli.Nombre,OTr.NumeroModulos,otr.IdOrdenTrabajo  order by idordentrabajo