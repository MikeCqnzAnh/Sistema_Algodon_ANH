create procedure sp_ConsultaDetalleColonias
as
select a.IdColonia,
       a.Descripcion,
	   a.NoPacas,
	   a.IdEstatus
from [dbo].[Colonias] a
where a.IdEstatus = 1