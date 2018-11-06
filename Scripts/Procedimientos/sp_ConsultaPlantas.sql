create procedure sp_ConsultaPlantas
as 
select a.IdPlanta,
	   a.Descripcion
from [dbo].[Plantas] a
where a.IdEstatus = 1