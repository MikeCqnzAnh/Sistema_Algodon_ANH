alter procedure sp_ConsultaMunicipios
@IdEstadoFisica int
as
select a.IdMunicipio,
       a.Descripcion
from Municipios a
where a.IdEstado = @IdEstadoFisica and a.IdEstatus = 1
order by a.Descripcion