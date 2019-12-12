create procedure sp_ConsultaMunicipiosMov
@IdEstadoMovilizacion int
as 
select a.IdMunicipio,
       a.Descripcion
from Municipios a
where a.IdEstado = @IdEstadoMovilizacion
and   a.IdEstatus = 1