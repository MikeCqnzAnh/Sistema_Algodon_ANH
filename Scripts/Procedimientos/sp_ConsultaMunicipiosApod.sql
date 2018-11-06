create procedure sp_ConsultaMunicipiosApod
@IdEstadoApoderado int
as 
select a.IdMunicipio,
       a.Descripcion
from Municipios a
where a.IdEstado = @IdEstadoApoderado
and   a.IdEstatus = 1