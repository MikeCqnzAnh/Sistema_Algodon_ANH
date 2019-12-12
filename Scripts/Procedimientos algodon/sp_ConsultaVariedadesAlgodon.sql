create procedure sp_ConsultaVariedadesAlgodon
as
select a.IdVariedadAlgodon,
		a.Descripcion,
		a.IdEstatus
from [dbo].[VariedadesAlgodon] a
where a.IdEstatus = 1