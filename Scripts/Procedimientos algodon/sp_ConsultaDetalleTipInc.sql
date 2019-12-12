create procedure sp_ConsultaDetalleTipInc
as
select a.IdTipoIncidencia,
		a.Descripcion,
			a.IdEstatus
from [dbo].[TipoIncidencia] a
where a.IdEstatus=1