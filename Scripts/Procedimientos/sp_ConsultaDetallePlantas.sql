create procedure sp_ConsultaDetallePlantas
as
select a.IdPlanta,
		a.Descripcion,
		a.Registro,
		a.IdEstatus
from [dbo].[Plantas] a
where a.IdEstatus = 1