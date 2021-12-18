select ot.IdOrdentrabajo as 'Orden trb',
	   otd.IdBoleta as NoModulo,
	   pla.descripcion as Planta,
	   --ot.Predio,
	   cli.Nombre,
	   otd.Bruto,
	   otd.Tara,
	   otd.Total as Neto,
	   --ot.Predio,
	   otd.FechaEntrada,
	   otd.FechaSalida
from ordentrabajo ot inner join OrdenTrabajoDetalle otd on ot.IdOrdenTrabajo = otd.IdOrdenTrabajo
					 inner join clientes cli on ot.idproductor = cli.IdCliente
					 inner join Plantas pla on ot.IdPlanta = pla.IdPlanta
where otd.tara > 0 