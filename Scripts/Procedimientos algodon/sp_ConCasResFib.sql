create procedure sp_ConCasResFib
as
select a.IdResistenciaFibra,
       a.Rango1,
	   a.Rango2,
	   a.castigo
from [dbo].[ResistenciaFibra] a
where a.IdEstatus = 1