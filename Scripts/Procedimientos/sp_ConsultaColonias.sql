create procedure sp_ConsultaColonias
as
select a.IdColonia,
       a.Descripcion
from [dbo].[Colonias] a
where a.IdEstatus = 1