create procedure pa_consultagradosclasif
@idclase int
as
select GradoColor
from GradosClasificacion
where IdClase = @idclase
group by GradoColor
order by GradoColor