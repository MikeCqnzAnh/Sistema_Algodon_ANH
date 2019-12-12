create procedure sp_ConsultaDetalleCamiones
as
select a.IdCamion,
       a.Descripcion, 
	   a.Placas,
	   a.IdEstatus
from [dbo].[Camiones] a
where a.IdEstatus = 1