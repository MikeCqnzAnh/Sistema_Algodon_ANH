create procedure sp_ConsultaDetalleRangos
as
select a.IdRango,
       a.RangoInicial,
	   a.RangoFinal,
	   a.DentroLimite,
	   a.IdEstatus
from [dbo].[RangoTemperatura] a
where a.IdEstatus = 1