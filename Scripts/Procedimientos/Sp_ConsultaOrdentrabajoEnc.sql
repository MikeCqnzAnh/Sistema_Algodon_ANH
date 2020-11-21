Create Procedure Sp_ConsultaOrdentrabajoEnc
@IdOrdenTrabajo int
as
if @idordentrabajo <> 0 
begin
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
order by ot.idordentrabajo
end
else
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
order by ot.idordentrabajo