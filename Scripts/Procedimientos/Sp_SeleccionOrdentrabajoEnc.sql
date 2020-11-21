Create Procedure Sp_SeleccionOrdentrabajoEnc
@IdOrdenTrabajo int
as
select
ot.IdOrdenTrabajo
,ot.IdPlanta
,ot.IdProductor
,cl.Nombre	
,ot.RangoInicio	
,ot.RangoFin	
,ot.NumeroModulos	
,ot.PesoModulos	
,ot.IdVariedadAlgodon	
,ot.IdColonia	
,ot.Predio	
,ot.IdEstatus	
,ot.IdUsuarioCreacion	
,ot.FechaCreacion	
,ot.IdUsuarioActualizacion	
,ot.FechaActualizacion
from ordentrabajo ot inner join clientes cl on ot.idproductor = cl.idcliente
where IdOrdenTrabajo = @IdOrdenTrabajo